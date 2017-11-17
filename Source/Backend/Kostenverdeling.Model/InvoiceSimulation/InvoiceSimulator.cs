using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.DataImport;
using System.Collections.Generic;
using System.Linq;

namespace Kostenverdeling.Model.InvoiceSimulation
{
    public class InvoiceSimulator
    {

        public List<InvoiceSimulationResult> Calculate(EBloxImportResult import) {
            var invoiceSimulationResults = new List<InvoiceSimulationResult>();

            foreach(var department in import.DepartmentRepository.GetDepartments().Where(d => !d.CanIgnore)) {
                foreach (var invoiceLine in import.InvoiceSimulationSettings.InvoiceSections.SelectMany(s => s.InvoiceSectionLines)) {
                    var invoiceSimulationResult = new InvoiceSimulationResult {
                        Department = department,
                        Line = invoiceLine,
                        Value = 0                     
                    };

                    foreach(var division in department.Divisions.Where(d => (!d.CanIgnore))) {
                        var records = GetRecords(division, import,
                            codesToInclude: invoiceLine.CodesToInclude,
                            codesToIgnore: invoiceLine.CodesToIgnore);

                        foreach (var record in records) {
                            invoiceSimulationResult.Value += record.Value;
                        }                        
                    }

                    // Do tax multiplier if needed
                    if (invoiceLine.TaxMultiplier != 0) {
                        if (invoiceLine.IncludeOriginalValue) {
                            invoiceSimulationResult.Value = invoiceSimulationResult.Value * (1 + invoiceLine.TaxMultiplier);
                        }
                        else {
                            invoiceSimulationResult.Value = invoiceSimulationResult.Value * (invoiceLine.TaxMultiplier);
                        }
                    }

                    invoiceSimulationResults.Add(invoiceSimulationResult);
                }
            }

            return invoiceSimulationResults;
        }       

        private List<EBloxRecord> GetRecords(Division division, EBloxImportResult import, List<string> codesToInclude = null, List<string> codesToIgnore = null) {
            var records = import.Records
                        .Where(r => r.Department.Id == division.Department.Id)
                        .Where(r => r.Division.Id == division.Id)
                        .Where(r => r.InvoiceDate == import.SelectedInvoiceDate)
                        .Where(r => import.ImportOptions.TypesToInclude.Any(s => s.Equals(r.Type)))
                        .ToList();

            if (codesToInclude != null) {
                var tmp = new List<EBloxRecord>();

                foreach (var record in records) {
                    foreach (var code in codesToInclude) {
                        var c = code.Replace("*", "");
                        if (record.Category.Code.StartsWith(c)) {
                            tmp.Add(record);
                        }
                    }
                }

                records = tmp;
            }

            if (codesToIgnore != null && codesToIgnore.Count != 0) {
                var tmp = new List<EBloxRecord>();

                foreach (var record in records) {
                    foreach (var code in codesToIgnore) {
                        var c = code.Replace("*", "");
                        if (!record.Category.Code.StartsWith(c)) {
                            tmp.Add(record);
                        }
                    }
                }

                records = tmp;
            }

            return records.ToList();
        }
    }
}
