using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.DataImport;
using System;
using System.IO;
using System.Linq;

namespace Kostenverdeling.Model.ExcelImportConsoleTester
{
    class Program
    {
        static void Main(string[] args) {
           /* var fileName = @"160811_VERDELINGFACTUUR_201607.XLSX";
            var eBloxImportOptionsLoader = new EBloxImportOptionsJsonLoader(new FileInfo("Settings/EBloxImportOptions.json"));
            var businessDepartmentRepository = new DepartmentRepository(eBloxImportOptionsLoader.Load().Departments);
            var employeeRepository = new EmployeeRepository();
            var costCategoryRepository = new CostCategoryRepository();            
            Console.WriteLine("-- INIT --");

            // need to install access database engine: https://social.msdn.microsoft.com/Forums/en-US/1d5c04c7-157f-4955-a14b-41d912d50a64/how-to-fix-error-the-microsoftaceoledb120-provider-is-not-registered-on-the-local-machine?forum=vstsdb
            var importer = new EBloxOleDbExcelImporter(businessDepartmentRepository, employeeRepository, costCategoryRepository, eBloxImportOptionsLoader);
            var result = importer.Import(new FileInfo(fileName));
            Console.WriteLine("-- IMPORTING DONE --");
            Console.WriteLine();

            Console.WriteLine("-- RESULTS --");            
            foreach (var record in result.Records) {
                Console.WriteLine($"   * {record.Department.Name} @ {record.Division.Name} :: {record.Employee.Name}");
                Console.WriteLine($"     €{record.Value.ToString("#.00")}");
            }
            Console.WriteLine($"   Predicted 'begindatum': {result.StartDate.ToShortDateString()}");
            Console.WriteLine($"   Predicted 'einddatum': {result.EndDate.ToShortDateString()}");
            Console.WriteLine($"   Has unknown departments? {result.HasUnknownDepartments}");
            if (result.HasUnknownDepartments) {
                foreach(var d in result.UnknownDepartments) {
                    Console.WriteLine($"    - {d.Name}");
                }
            }
            Console.WriteLine($"   Has unknown divisions? {result.HasUnknownDivisions}");
            if (result.HasUnknownDivisions) {
                foreach (var d in result.UnknownDivisions.Distinct()) {
                    Console.WriteLine($"    - {d.Name}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("-- OVERZICHT DEPT/DIV --");
            foreach (var d in businessDepartmentRepository.GetDepartments()) {
                Console.WriteLine($"   + {d.Name} ({d.Id})");
                foreach (var dv in d.Divisions) {
                    Console.WriteLine($"    - {dv.Name} ({dv.Id})");
                }
            }

            Console.WriteLine();
            Console.WriteLine("-- END OF PROGRAM --");
            Console.ReadLine();*/
        }
    }
}
