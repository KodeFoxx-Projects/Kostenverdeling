using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.DataImport;
using Kostenverdeling.Model.Settings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kostenverdeling.Model.Calculation
{
    public class Calculator
    {
        private readonly EBloxImportResult _import;

        public Calculator(EBloxImportResult importResult) {
            _import = importResult;
        }

        public List<CalculationReport> Calculate() {
            var calculationReports = new List<CalculationReport>();

            foreach(var department in _import.DepartmentRepository.GetDepartments().Where(d => !d.CanIgnore)) {
                var calculationReport = new CalculationReport {
                    Department = department,
                    StartDate = _import.StartDateCorrection,
                    EndDate = _import.EndDateCorrection,
                    InvoiceDate = _import.SelectedInvoiceDate,
                    InvoiceNumber = "-",
                    SubReports = new List<CalculationSubReport>()
                };
                calculationReports.Add(calculationReport);

                // 01. Beheerskosten
                calculationReport.SubReports.AddRange(
                    GenerateSubReport(
                        department.Divisions.Where(d => !d.CanIgnore).ToList(),
                        _import.CalculationSettings.ManagementCosts
                    )
                );
                
                // 02. RSZ
                calculationReport.SubReports.AddRange(
                    GenerateSubReport(
                        department.Divisions.Where(d => !d.CanIgnore).ToList(),
                        _import.CalculationSettings.SocialSecurity
                    )
                );                

                // 03. Bedrijfsvoorheffing
                calculationReport.SubReports.AddRange(
                    GenerateSubReport(
                        department.Divisions.Where(d => !d.CanIgnore).ToList(),
                        _import.CalculationSettings.AdvanceTaxPayment
                    )
                );                

                // 04. Beheer Loonbeslag
                calculationReport.SubReports.AddRange(
                    GenerateSubReport(
                        department.Divisions.Where(d => !d.CanIgnore).ToList(),
                        _import.CalculationSettings.WageGarnishmentManagement
                    )
                );                

                // 05. Provisie
                calculationReport.SubReports.AddRange(
                    GenerateSubReport(
                        department.Divisions.Where(d => !d.CanIgnore).ToList(),
                        _import.CalculationSettings.SocialSecurityProvision
                    )
                );

                // 06. Loonbeslag
                calculationReport.SubReports.AddRange(
                    GenerateSubReport(
                        department.Divisions.Where(d => !d.CanIgnore).ToList(),
                        _import.CalculationSettings.WageGarnishment
                    )
                );
            }

            return calculationReports;
        }

        private List<CalculationSubReport> GenerateSubReport(List<Division> divisions, CalculationSettingsElement calculationSettingsElement) {
            var subReports = new List<CalculationSubReport>();

            foreach (var division in divisions) {
                var subReport = new CalculationSubReport {
                    Category = calculationSettingsElement.Name,
                    Division = division,
                    Value = 0,
                    IncludeInExcelReport = calculationSettingsElement.IncludeInExcelReport,
                    IncludeInExcelDetailReport = calculationSettingsElement.IncludeInExcelDetailReport,
                    CategoryElement = calculationSettingsElement,
                    CategoryTaxMultiplier = calculationSettingsElement.TaxMultiplier
                };

                double value = 0;
                var cnt = 1;
                var records = GetRecords(division, calculationSettingsElement.Codes, calculationSettingsElement.CodesToIgnore);
                foreach (var record in records) {
                    var val = record.Value + (record.Value * calculationSettingsElement.TaxMultiplier);
                    value += val;
                    subReport.CalculationDiary.Add($"RECORD '{cnt.ToString("000")}' op {String.Join("-", division.Ids.ToArray())}-{division.Name}");
                    subReport.CalculationDiary.Add($"  - TYPE '{record.Type}' | CODE '{record.Category.Code}-{record.Category.Description}'");
                    subReport.CalculationDiary.Add($"    EMPLOYEE '{record.Employee.Id}-{record.Employee.Name}'");
                    subReport.CalculationDiary.Add($"    INVOICE DATE '{record.InvoiceDate.ToString("dd/MM/yyyy")}'");
                    subReport.CalculationDiary.Add($"    VALUE '{record.Value.ToString()}'");
                    subReport.CalculationDiary.Add($"     - TAX MULTIPLIER '{calculationSettingsElement.TaxMultiplier}' => VALUE w/ TAX '{val}'");
                    subReport.CalculationDiary.Add($"     - CURRENT TOTAL VALUE '{value}'");
                    subReport.CalculationDiary.Add($"    /");
                    subReport.CalculationDiary.Add($"");
                    cnt++;
                    subReport.AddEBloxRecord(record);
                }
                subReport.Value = value;

                subReports.Add(subReport);
            }

            return subReports;
        }

        private List<EBloxRecord> GetRecords(Division division, List<string> codesToInclude = null, List<string> codesToIgnore = null) {
            var records = _import.Records
                        .Where(r => r.Department.Id == division.Department.Id)
                        .Where(r => r.Division.Id == division.Id)
                        .Where(r => r.InvoiceDate == _import.SelectedInvoiceDate)
                        .Where(r => _import.ImportOptions.TypesToInclude.Any(s => s.Equals(r.Type)))
                        .ToList();

            if(codesToInclude != null) {
                var tmp = new List<EBloxRecord>();

                foreach(var record in records) {
                    foreach(var code in codesToInclude) {
                        var c = code.Replace("*", "");
                        if(record.Category.Code.StartsWith(c)) {
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
