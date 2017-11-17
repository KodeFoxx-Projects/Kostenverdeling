using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace Kostenverdeling.Model.DataImport
{
    /// <summary>
    /// Imports e-blox data via an excel file.
    /// </summary>
    /// <remarks>
    /// Users need to install http://www.microsoft.com/download/en/confirmation.aspx?id=23734
    /// Or check this: http://stackoverflow.com/a/32247214/1155847
    /// </remarks>
    public class EBloxOleDbExcelImporter : IEBloxImporter<FileInfo>
    {
        private readonly IDepartmentRepository _businessDepartmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICostCategoryRepository _costCategoryRepository;
        private readonly IEBloxImportOptionsLoader _eBloxImportOptionsLoader;
        private readonly ICalculationSettingsLoader _calculationSettingsLoader;
        private readonly IInvoiceSimulationSettingsLoader _invoiceSimulationSettingsLoader;

        public EBloxOleDbExcelImporter(IDepartmentRepository businessDepartmentRepository, IEmployeeRepository employeeRepository, ICostCategoryRepository costCategoryRepository, IEBloxImportOptionsLoader eBloxImportOptionsLoader, ICalculationSettingsLoader calculationSettingsLoader, IInvoiceSimulationSettingsLoader invoiceSimulationSettingsLoader) {
            _businessDepartmentRepository = businessDepartmentRepository;
            _employeeRepository = employeeRepository;
            _costCategoryRepository = costCategoryRepository;
            _eBloxImportOptionsLoader = eBloxImportOptionsLoader;
            _calculationSettingsLoader = calculationSettingsLoader;
            _invoiceSimulationSettingsLoader = invoiceSimulationSettingsLoader;

            businessDepartmentRepository.AddFallbackAccountingDescriptions(eBloxImportOptionsLoader.Load().AccountingDescriptions);
        }

        public EBloxImportResult Import(FileInfo source) {
            if (!source.Exists) {
                throw new FileNotFoundException($"Het bestand {source.FullName} bestaat niet of kan niet geopend worden.");
            }

            var connectionString = CreateExcelConnectionString(source.FullName);
            var eBloxRecords = ParseExcelFile(connectionString);

            return new EBloxImportResult {
                Records = eBloxRecords.ToList(),
                ImportOptions = _eBloxImportOptionsLoader.Load(),
                CalculationSettings = _calculationSettingsLoader.Load(),
                InvoiceSimulationSettings = _invoiceSimulationSettingsLoader.Load(),
                DepartmentRepository = _businessDepartmentRepository,
                EmployeeRepository = _employeeRepository,
                CostCategoryRepository = _costCategoryRepository
            };
        }

        private IEnumerable<EBloxRecord> ParseExcelFile(string connectionString) {
            var eBloxRecords = new List<EBloxRecord>();

            using (var connection = new OleDbConnection(connectionString)) {

                // Open the connection 
                // - and create and empty command
                // - setup data table to store excel data in
                connection.Open();
                var command = new OleDbCommand() { Connection = connection };
                var table = new DataTable();

                // Get all the sheets in the excel file, and get the name of the first sheet
                var sheets = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                var sheetName = sheets.Rows[0]["TABLE_NAME"].ToString();
                table.TableName = sheetName;

                // Loop through the first sheet to get all data
                command.CommandText = $"SELECT * FROM [{sheetName}]";
                using (var dataAdapter = new OleDbDataAdapter(command)) {
                    dataAdapter.Fill(table);
                }
                var rowCounter = 1;                
                foreach (DataRow row in table.Rows) {                    
                    try {
                        var department = _businessDepartmentRepository.GetDepartment(Int32.Parse(row[2].ToString()));
                        if (department == null) {
                            department = _businessDepartmentRepository.GetOrAddUnknownDepartment(Int32.Parse(row[2].ToString()), $"NAAMLOOS-{Int32.Parse(row[2].ToString())}");
                        }
                        var division = _businessDepartmentRepository.GetDivision(Int32.Parse(row[1].ToString()), department);
                        if (division == null) {
                            division = _businessDepartmentRepository.GetOrAddUnknownDivision(Int32.Parse(row[1].ToString()), $"NAAMLOOS-{Int32.Parse(row[1].ToString())}", department);
                        }

                        var employee = _employeeRepository.GetOrAddEmployee(Int32.Parse(row[3].ToString()), row[4].ToString());
                        var category = _costCategoryRepository.GetOrAddCostCategory(row[11].ToString(), row[12].ToString());

                        eBloxRecords.Add(new EBloxRecord {
                            Group = Int32.Parse(row[0].ToString()),
                            Value = Double.Parse(row[13].ToString()),
                            StartDate = DateTime.Parse(row[5].ToString()),
                            EndDate = DateTime.Parse(row[6].ToString()),
                            InvoiceDate = DateTime.Parse(row[7].ToString()),
                            Division = division,
                            OriginalDivisionId = row[1].ToString(),
                            Type = row[10].ToString(),
                            Employee = employee,
                            Category = category
                        });

                        rowCounter++;
                    } catch(Exception ex) {
                        throw new Exception($"{ex.Message} - on {rowCounter} with departmenent='{Int32.Parse(row[2].ToString())}' and division='{Int32.Parse(row[1].ToString())} and employee='{row[4].ToString()}'.\n- DIVISIONS: {String.Join(", ", _businessDepartmentRepository.GetDivisions().Select(d => $"'{d.Id}-{d.Name} {d.Department.Name}({d.Department.Id})'"))}\n\n", ex);
                    }
                }                
            }

            return eBloxRecords;
        }

        private string CreateExcelConnectionString(string dataSource) {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Provider=Microsoft.ACE.OLEDB.12.0;");
            stringBuilder.Append("Extended Properties=Excel 12.0 XML;");
            stringBuilder.Append($"Data Source={dataSource};");

            return stringBuilder.ToString();
        }
    }
}
