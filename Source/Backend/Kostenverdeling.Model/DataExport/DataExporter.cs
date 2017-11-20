using Kostenverdeling.Model.Calculation;
using Kostenverdeling.Model.DataImport;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Linq;
using System;
using System.Drawing;
using System.Net.Mime;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.Settings;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;

namespace Kostenverdeling.Model.DataExport
{
    public class DataExporter
    {
        internal DirectoryInfo Directory { get; }
        public DirectoryInfo ExportDirectory { get; private set; }
        internal EBloxImportResult ImportResult { get; set; }
        internal List<CalculationReport> CalculationReports { get; set; }

        private BackgroundWorker _backgroundWorker;

        public event ProgressChangedEventHandler ProgressChanged;
        public event RunWorkerCompletedEventHandler Completed;

        public DataExporter(DirectoryInfo directory, EBloxImportResult import, List<CalculationReport> report) {
            Directory = directory;
            ImportResult = import;
            CalculationReports = report;
        }

        public void StartExportAsync() {
            if (_backgroundWorker == null) {
                _backgroundWorker = new BackgroundWorker();
                _backgroundWorker.WorkerReportsProgress = true;
                _backgroundWorker.ProgressChanged += (s, e) => {                    
                    RaiseProgressChanged(e);                    
                };
                _backgroundWorker.RunWorkerCompleted += (s, e) => {
                    RaiseCompleted(e);
                    _backgroundWorker.Dispose();
                    _backgroundWorker = null;
                };
                _backgroundWorker.DoWork += Export;
                _backgroundWorker.RunWorkerAsync();
            }
        }

        private void Export(object sender, DoWorkEventArgs e) {

            ExportDirectory = Directory;

            var divisions = ImportResult.DepartmentRepository.GetDivisions().Where(d => !d.CanIgnore);
            double total = divisions.Count();

            double current = 1;

            foreach (var department in divisions.Select(d => d.Department).Distinct()) {
                
                var categories = CalculationReports.Where(cr => cr.Department.Id == department.Id).SelectMany(cr => cr.SubReports).Where(sr => sr.Division.Department.Id == department.Id && sr.IncludeInExcelReport).Select(csr => csr.Category).Distinct();
                var reports = CalculationReports.Where(cr => cr.Department.Id == department.Id).ToList();
                var documentName = Path.Combine(Directory.FullName, $"VERDELING_FACTUUR-{reports[0].InvoiceNumber}-{department.Id}-{department.Name}.xlsx");
                var totalLines = 0;

                if (reports != null && reports.Count != 0) {

                    /* OVERZICHT EXCELS */
                    using (var xl = new ExcelPackage(new FileInfo(documentName))) {

                        var worksheetName = $"VERDELING_FACTUUR-{reports[0].InvoiceNumber}-{department.Id}-{department.Name}";
                        var ws = xl.Workbook.Worksheets.Add(worksheetName);
                        var categoryHeaders = new List<int>();
                        xl.Save();

                        // COLUMN A & B smaller
                        ws.Column(1).Width = 1.11d; // A
                        ws.Column(2).Width = 0; // B

                        // HEADER styles
                        ws.Cells[$"C1:E1"].Style.Font.Bold = true;
                        ws.Cells[$"C1:E1"].Style.Font.Size = 12;
                        ws.Cells["C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        ws.Cells["D1:E1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Cells[$"C1:E1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        ws.Cells[$"D1:E4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                        ws.Cells[$"C2:E4"].Style.VerticalAlignment = ExcelVerticalAlignment.Bottom;
                        ws.Cells[$"C1:E4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[$"C1:E4"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        ws.Row(1).Height = 25.50d;
                        ws.Row(2).Height = 19.20d;
                        ws.Row(3).Height = 19.20d;
                        ws.Row(4).Height = 19.20d;
                        // HEADER content
                        ws.Cells["C1"].Value = "SD WORX";
                        ws.Cells["D1"].Value = department.Name;
                        ws.Cells["D1:E1"].Merge = true;
                        ws.Cells["C2"].Value = "Periode";
                        ws.Cells["D2"].Value = reports[0].StartDate.ToShortDateString();
                        ws.Cells["E2"].Value = reports[0].EndDate.ToShortDateString();
                        ws.Cells["C3"].Value = "Factuurdatum";
                        ws.Cells["D3"].Value = reports[0].InvoiceDate.ToShortDateString();
                        ws.Cells["C4"].Value = "FactuurNummer";
                        ws.Cells["D4"].Value = reports[0].InvoiceNumber.ToString();
                        // HEADER save
                        xl.Save();

                        var divisionTotalsInformation = new Dictionary<string, List<Tuple<Division, string>>>();

                        var lineCounter = 5;
                        total = total + categories.Count();
                        foreach (var category in categories) {
                            // Category header
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 192, 0));
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Font.Bold = true;
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            ws.Cells[$"C{lineCounter}"].Value = category;
                            categoryHeaders.Add(lineCounter);
                            lineCounter++;

                            // Update progressbar
                            var percentage = (current / total) * 100;
                            if (percentage > 100) {
                                percentage = 100;
                            }
                            _backgroundWorker.ReportProgress(Convert.ToInt32(percentage), $"Maken van verdeling factuur overzicht excel bestand, berekeningen exporteren voor '{department.Name}' op categorie '{category}'...");
                            current++;

                            var divisionCounter = 0;
                            foreach (var division in divisions.Where(d => d.Department.Id == department.Id).Distinct()) {

                                ws.Cells[$"D{lineCounter}"].Value = ImportResult.DepartmentRepository.GetAccountingDescription(category, division).Description;
                                ws.Cells[$"D{lineCounter}"].Style.Font.Bold = false;
                                ws.Cells[$"D{lineCounter}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                                var subreport = CalculationReports.Where(cr => cr.Department.Id == department.Id).SelectMany(cr => cr.SubReports).Where(sr => sr.Division.Id == division.Id).Where(sr => sr.Category == category).SingleOrDefault();
                                ws.Cells[$"C{lineCounter}"].Value = division.Name;
                                if (subreport == null) {
                                    ws.Cells[$"E{lineCounter}"].Value = "FOUT";
                                }
                                else {
                                    ws.Cells[$"E{lineCounter}"].Value = Convert.ToDouble(subreport.Value.ToString("0.00"));
                                }
                                ws.Cells[$"E{lineCounter}"].Style.Numberformat.Format = "#,##0.00";

                                if (!divisionTotalsInformation.ContainsKey(division.Name)) {
                                    divisionTotalsInformation.Add(division.Name, new List<Tuple<Division, string>>());
                                }
                                divisionTotalsInformation[division.Name].Add(new Tuple<Division, string>(division, $"E{lineCounter}"));

                                lineCounter++;
                                divisionCounter++;
                            }

                            // Category footer
                            ws.Cells[$"D{lineCounter}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Font.Bold = true;
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(217, 217, 217));
                            ws.Cells[$"D{lineCounter}"].Value = $"Totaal {category}";
                            ws.Cells[$"E{lineCounter}"].Formula = $"=SUM(E{lineCounter - (divisionCounter)}:E{lineCounter - 1})";
                            ws.Cells[$"E{lineCounter}"].Style.Numberformat.Format = "#,##0.00";
                            lineCounter++;

                            totalLines = lineCounter;
                        }

                        // Division Totals
                        var totalsFormula = new List<string>();
                        foreach (var c in divisionTotalsInformation.Keys) {
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Font.Bold = true;
                            ws.Cells[$"C{lineCounter}"].IsRichText = true;
                            var rt = ws.Cells[$"C{lineCounter}"].RichText.Add($"Totaal {department.Name}");
                            rt.Bold = false;
                            rt = ws.Cells[$"C{lineCounter}"].RichText.Add($" {c}");
                            rt.Bold = true;
                            var formula = String.Join("+", divisionTotalsInformation[c].Select(t => t.Item2).ToArray());
                            ws.Cells[$"E{lineCounter}"].Formula = $"={formula}";
                            ws.Cells[$"E{lineCounter}"].Style.Numberformat.Format = "#,##0.00";

                            ws.Cells[$"D{lineCounter}"].Value = ImportResult.DepartmentRepository.GetAccountingDescription("_totaal", divisionTotalsInformation[c].Select(t => t.Item1).First()).Description;
                            ws.Cells[$"D{lineCounter}"].Style.Font.Bold = false;
                            ws.Cells[$"D{lineCounter}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            totalsFormula.Add($"E{lineCounter}");

                            lineCounter++;
                        }


                        // Division Totals Extras
                        var categoryElements = CalculationReports
                            .Where(cr => cr.Department.Id == department.Id)
                            .SelectMany(cr => cr.SubReports)
                            .Where(sr => sr.CategoryElement.IncludeInTotalsExcelReport).Distinct()
                            .Select(sr => sr.CategoryElement).Distinct();
                        foreach (var ce in categoryElements) {
                            var value = 0d;
                            foreach (var cr in CalculationReports.Where(cr => cr.Department.Id == department.Id).SelectMany(cr => cr.SubReports).Where(sr => sr.CategoryElement.Name == ce.Name)) {
                                value += cr.Value;
                            }
                            ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Font.Bold = true;
                            ws.Cells[$"C{lineCounter}"].Value = ce.Name.ToUpper();
                            ws.Cells[$"D{lineCounter}"].Value = ImportResult.DepartmentRepository.GetAccountingDescription($"_totaal_{ce.Name}", -1, -1).Description;
                            ws.Cells[$"D{lineCounter}"].Style.Font.Bold = false;
                            ws.Cells[$"D{lineCounter}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            ws.Cells[$"E{lineCounter}"].Value = value;
                            ws.Cells[$"E{lineCounter}"].Style.Numberformat.Format = "#,##0.00";
                            totalsFormula.Add($"E{lineCounter}");
                            lineCounter++;
                        }

                        // YELLOW SPLITTER
                        var yellowSplitterRow = lineCounter;
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Font.Bold = true;
                        ws.Cells[$"C{lineCounter}"].Value = "PROVISIE";
                        ws.Cells[$"E{lineCounter}"].Value = 0.00d;
                        ws.Cells[$"E{lineCounter}"].Style.Numberformat.Format = "#,##0.00";
                        lineCounter++;

                        // TOTAAL
                        var totalRow = lineCounter;
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(217, 217, 217));
                        ws.Cells[$"C{lineCounter}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        ws.Cells[$"C{lineCounter}"].Style.VerticalAlignment = ExcelVerticalAlignment.Bottom;
                        ws.Cells[$"C{lineCounter}"].Value = "TOTAAL van Projecten + BJB";
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Font.Bold = true;
                        ws.Cells[$"E{lineCounter}"].Formula = $"={String.Join("+", totalsFormula.ToArray())}+E{lineCounter-1}";
                        ws.Cells[$"E{lineCounter}"].Style.Numberformat.Format = "#,##0.00";
                        lineCounter++;

                        // TOTAAL Controle
                        var totalRowControl = lineCounter;
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(191, 191, 191));
                        ws.Cells[$"C{lineCounter}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        ws.Cells[$"C{lineCounter}"].Style.VerticalAlignment = ExcelVerticalAlignment.Bottom;
                        ws.Cells[$"C{lineCounter}"].Value = "Factuur Bedrag voor de Controle";
                        ws.Cells[$"C{lineCounter}:E{lineCounter}"].Style.Font.Bold = true;                        
                        ws.Cells[$"E{lineCounter}"].Value = Double.Parse(reports[0].OriginalInvoiceTotal.Trim().Replace(".", ","));
                        ws.Cells[$"E{lineCounter}"].Style.Numberformat.Format = "#,##0.00";

                        // TOTAAL Controle Red or Green Conditional Rules
                        var rangeToCompare = ws.Cells[$"E{lineCounter}"];
                        // ENFORCE RULES
                        var equalRule = ws.ConditionalFormatting.AddEqual(rangeToCompare);
                        equalRule.Formula = $"=E{lineCounter - 1}";
                        equalRule.Style.Fill.BackgroundColor.Color = Color.LawnGreen;
                        var notEqualRule = ws.ConditionalFormatting.AddNotEqual(rangeToCompare);
                        notEqualRule.Formula = $"=E{lineCounter - 1}";
                        notEqualRule.Style.Fill.BackgroundColor.Color = Color.Salmon;


                        // Up line count
                        lineCounter++;

                        // AUTOFIT & Save 
                        totalLines = lineCounter;
                        for (int i = 1; i < 6; i++) {
                            ws.Column(i).AutoFit();
                        }
                        ws.Cells["D1:E1"].Merge = true;
                        ws.Cells["D1:E1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Cells["D1:E1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        // COLUMN A & B smaller
                        ws.Column(1).Width = 1.11d; // A
                        ws.Column(2).Width = 0; // B
                        ws.Row(1).Height = 25.50d;
                        ws.Row(2).Height = 19.20d;
                        ws.Row(3).Height = 19.20d;
                        ws.Row(4).Height = 19.20d;
                        ws.Row(yellowSplitterRow).Height = 25.50d;
                        ws.Row(totalRow).Height = 25.50d;
                        ws.Row(totalRowControl).Height = 25.50d;
                        foreach (var row in categoryHeaders) {
                            ws.Row(row).Height = 18.60d;
                        }
                        ws.Cells[$"C1:E{totalLines - 1}"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        for (int row = 1; row < totalLines; row++) {
                            for (int col = 2; col < 5 + 1; col++) {
                                ws.Cells[row, col].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                        }

                        
                        xl.Save();
                    }
                }

                /* DETAIL EXCELS */
                var worksheets = new Dictionary<string, Tuple<string, Division, CalculationSettingsElement>>();
                documentName = Path.Combine(Directory.FullName, $"DETAILS_FACTUUR-{department.Id}-{department.Name}.xlsx");
                using (var xl = new ExcelPackage(new FileInfo(documentName))) {

                    var ctr = 0;
                    foreach (var division in divisions.Where(d => d.Department.Id == department.Id).OrderBy(dv => dv.Name)) {
                        categories = CalculationReports.Where(cr => cr.Department.Id == department.Id).SelectMany(cr => cr.SubReports).Where(sr => sr.Division.Id == division.Id && sr.IncludeInExcelDetailReport).Select(csr => csr.Category).Distinct();
                        
                        foreach (var category in categories.OrderBy(c => c)) {
                            var categoryElement = CalculationReports.SelectMany(cr => cr.SubReports).Where(sr => sr.Category == category).Distinct().First().CategoryElement;
                            var worksheetName = $"{division.Name}-{category}";
                            worksheets.Add($"{category};{(++ctr).ToString()}", new Tuple<string, Division, CalculationSettingsElement>(worksheetName, division, categoryElement));
                        }
                    }

                    // Update progressbar total.
                    total = worksheets.Keys.Count;
                    current = 0;

                    foreach (var worksheetOrder in worksheets.Keys.OrderBy(k => k)) {

                        var worksheetName = worksheets[worksheetOrder].Item1;
                        var division = worksheets[worksheetOrder].Item2;
                        var categoryElement = worksheets[worksheetOrder].Item3;
                        var category = worksheets[worksheetOrder].Item3.Name;

                        // Update progressbar
                        var percentage = (current / total) * 100;
                        if (percentage > 100) {
                            percentage = 100;
                        }
                        _backgroundWorker.ReportProgress(Convert.ToInt32(percentage), $"Maken van detail excel bestand uitsplitsingen voor '{division.Department.Name}' '{division.Name}'...");
                        current++;

                        // Make the sheet
                        var ws = xl.Workbook.Worksheets.Add(worksheetName);
                        ws.Cells["A1"].Value = "Nummer groep";
                        ws.Cells["B1"].Value = "Afdeling";
                        ws.Cells["C1"].Value = "Nummer werkgever";
                        ws.Cells["D1"].Value = "Nummer werknemer";
                        ws.Cells["E1"].Value = "Naam werknemer";
                        ws.Cells["F1"].Value = "Begindatum loonperiode";
                        ws.Cells["G1"].Value = "Einddatum loonperiode";
                        ws.Cells["H1"].Value = "Berekingsdatum";
                        ws.Cells["I1"].Value = "Code";
                        ws.Cells["J1"].Value = "Omschrijving";
                        ws.Cells["K1"].Value = "Waarde";
                        ws.Cells["A1:K1"].Style.Font.Bold = true;
                        xl.Save();

                        var lineCounter = 2;
                        var calculationReports = CalculationReports.Where(cr => cr.Department.Id == department.Id).SelectMany(cr => cr.SubReports).Where(sr => sr.Division.Id == division.Id).Where(cr => cr.Category == category).ToList();
                        var numberOfLines = calculationReports.SelectMany(x => x.EBloxRecordDiary).Count();
                        foreach (var calculationReport in calculationReports) {

                            foreach (var diaryEntry in calculationReport.EBloxRecordDiary.Values) {
                                ws.Cells[$"A{lineCounter}"].Value = diaryEntry.Group.ToString();
                                ws.Cells[$"B{lineCounter}"].Value = diaryEntry.OriginalDivisionId.ToString();
                                ws.Cells[$"C{lineCounter}"].Value = diaryEntry.Department.Id.ToString();
                                ws.Cells[$"D{lineCounter}"].Value = diaryEntry.Employee.Id.ToString();
                                ws.Cells[$"E{lineCounter}"].Value = diaryEntry.Employee.Name;
                                ws.Cells[$"F{lineCounter}"].Value = diaryEntry.StartDate.ToShortDateString();
                                ws.Cells[$"G{lineCounter}"].Value = diaryEntry.EndDate.ToShortDateString();
                                ws.Cells[$"H{lineCounter}"].Value = diaryEntry.InvoiceDate.ToShortDateString();
                                ws.Cells[$"I{lineCounter}"].Value = diaryEntry.Category.Code.ToString();
                                ws.Cells[$"J{lineCounter}"].Value = diaryEntry.Category.Description;
                                ws.Cells[$"K{lineCounter}"].Style.Numberformat.Format = "#,##0.00";
                                ws.Cells[$"K{lineCounter}"].Value = diaryEntry.Value;

                                _backgroundWorker.ReportProgress(Convert.ToInt32(percentage), $"Maken van uitsplitsingen voor '{division.Department.Name}' '{division.Name}' (lijn {lineCounter}/{numberOfLines + 2})...");

                                lineCounter++;
                            }
                        }

                        ws.Cells[$"J{lineCounter + 2}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[$"J{lineCounter + 2}"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        ws.Cells[$"J{lineCounter + 2}"].Value = $"{category} {division.Name} {division.Id}";
                        ws.Cells[$"K{lineCounter + 2}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[$"K{lineCounter + 2}"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        ws.Cells[$"K{lineCounter + 2}"].Style.Numberformat.Format = "#,##0.00";
                        ws.Cells[$"K{lineCounter + 2}"].Formula = $"=(SUM(K2:K{lineCounter - 1}) + (SUM(K2:K{lineCounter - 1}) * {categoryElement.TaxMultiplier.ToString("0.00").Replace(",", ".")}))";
                        ws.Cells[$"J{lineCounter + 2}:K{lineCounter + 2}"].Style.Font.Bold = true;

                        for (int i = 1; i < 12; i++) {
                            ws.Column(i).AutoFit();
                        }
                        _backgroundWorker.ReportProgress(Convert.ToInt32(95), $"Opslaan EXCEL bestand...");
                        xl.Save();

                        _backgroundWorker.ReportProgress(Convert.ToInt32(97), $"Kopiëren origineel EXCEL importbestand...");
                        try {
                            ImportResult.OriginalImportFile.CopyTo(Path.Combine(ExportDirectory.FullName,
                                ImportResult.OriginalImportFile.Name));
                        } catch(Exception ex) { }

                        _backgroundWorker.ReportProgress(Convert.ToInt32(100), $"Opslaan EXCEL bestand...");
                    }
                }
            }
        }

        private void RaiseProgressChanged(ProgressChangedEventArgs e) {
            if(ProgressChanged != null) {
                ProgressChanged(this, e);
            }
        }

        private void RaiseCompleted(RunWorkerCompletedEventArgs e) {
            if (ProgressChanged != null) {
                Completed(this, e);
            }
        }

        private string GetConnectionString(DirectoryInfo directory, string fileName) {
            Dictionary<string, string> props = new Dictionary<string, string>();

            // XLSX - Excel 2007, 2010, 2012, 2013
            props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
            props["Extended Properties"] = "Excel 12.0 XML";
            props["Data Source"] = Path.Combine(directory.FullName, $"{fileName}.xlsx");

            // XLS - Excel 2003 and Older
            //props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
            //props["Extended Properties"] = "Excel 8.0";
            //props["Data Source"] = "C:\\MyExcel.xls";

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props) {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }
    }
}
