using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kostenverdeling.Model.DataImport;
using System.IO;
using Kostenverdeling.Model.Common;
using Kostenverdeling.Model.Settings;
using Kostenverdeling.Model.InvoiceSimulation;
using Kostenverdeling.Desktop.WinFormsClient.Common;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public partial class ImportWizardStep02_SelectExcelFile_View : UserControl
    {

        private BackgroundWorker _bgWorker;
        private EBloxImportResult _result;
        private ImportWizardController _controller;

        public event EventHandler IsValid;
        public event EventHandler IsInValid;

        private void RaiseIsValid() {
            if(IsValid != null) {
                IsValid(this, EventArgs.Empty);
            }
        }

        private void RaiseIsInValid() {
            if (IsInValid != null) {
                IsInValid(this, EventArgs.Empty);
            }
        }

        public ImportWizardStep02_SelectExcelFile_View(ImportWizardController controller) {
            _controller = controller;
            InitializeComponent();
            this.Width = 750;
            this.Height = 400;
            uxDataPanel.Visible = false;
            uxBusyPanel.Visible = false;
            RaiseIsInValid();
        }

        private void uxBrowseExcelFile_Click(object sender, EventArgs e) {
            using (var openFileDialog = new OpenFileDialog()) {
                openFileDialog.Multiselect = false;
                openFileDialog.CheckFileExists = true;
                openFileDialog.DefaultExt = ".xlsx";
                openFileDialog.Filter = "E-Blox Export EXCEL Bestand (*.xlsx)|*.xlsx";
                var result = openFileDialog.ShowDialog();
                if(result == DialogResult.OK) {
                    uxExcelFile.Text = openFileDialog.FileName;
                    ParseExcelFile(uxExcelFile.Text);
                } else {                    
                    uxExcelFile.Text = "(geen bestand geselecteerd)";
                }
            }
        }

        private void ParseExcelFile(string fileName) {
            try {
                RaiseIsInValid();
                uxBusyPanel.Visible = true;
                uxProgressBar.Value = 0;
                uxProgressInfo.Text = "Bezig met verwerken E-Blox EXCEL bestand...";
                uxBrowseExcelFile.Enabled = false;                

                if(_bgWorker != null) {
                    _bgWorker.Dispose();
                    _bgWorker = null;
                }

                _bgWorker = new BackgroundWorker();
                _bgWorker.WorkerReportsProgress = true;
                _bgWorker.DoWork += _bgWorker_DoWork;
                _bgWorker.ProgressChanged += _bgWorker_ProgressChanged;
                _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;
                _bgWorker.RunWorkerAsync(fileName);

                RaiseIsValid();
            }
            catch(Exception ex) {

                uxDataPanel.Visible = false;
                RaiseIsInValid();                
                uxBusyPanel.Visible = false;
                uxBrowseExcelFile.Enabled = true;
                uxExcelFile.Text = "(geen bestand geselecteerd)";                

                using (var dialog = new MasterDialogForm(this.ParentForm) {
                    HeaderColor = MasterDialogForm.Error,
                    HeaderTitleColor = MasterDialogForm.ErrorWhiteOnDarkRed,
                    HeaderTitle = $"Algemene fout '{ex.GetType().Name}'"
                }) {
                    dialog.AppendText($"Er is een onverwachte fout opgetreden tijdens het inlezen van het EXCEL bestand. Onderaan staat informatie die nuttig is voor de applicatieontwikkelaars, gelieve van deze informatie een screenshot te maken en hen deze te bezorgen alvorens u op de knop ok drukt. Na het drukken op de knop ok zal u opnieuw de kans krijgen om een EXCEL bestand te selecteren.");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"- OMSCHRIJVING: {ex.Message}");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"- STACKTRACE: {ex.StackTrace}");
                    dialog.ShowDialog(this.ParentForm);                    
                }                
            }

        }

        private void ShowImportResult(EBloxImportResult importResult, Exception exception = null) {

            if (exception != null) {
                uxDataPanel.Visible = false;
                MessageBox.Show(exception.ToString());
                RaiseIsInValid();                
            }
            else {

                try {
                    uxDataPanel.Show();
                    _result = importResult;
                    _controller.ImportResult = _result;
                    foreach (var unknownDepartment in _result.UnknownDepartments) {
                        unknownDepartment.CanIgnore = true;
                        foreach (var unknownDivision in unknownDepartment.Divisions) {
                            unknownDivision.CanIgnore = true;
                        }
                    }
                    uxNumberOfRecords.Text = importResult.Records.Count.ToString();
                    uxNumberOfEmployees.Text = importResult.Records.Select(r => r.Employee.Id).Distinct().Count().ToString();
                    uxStartDateInvoice.Value = importResult.StartDate;
                    uxEndDateInvoice.Value = importResult.EndDate;
                    uxInvoiceDates.Items.Clear();
                    foreach(var invoiceDate in importResult.InvoiceDates) {
                        uxInvoiceDates.Items.Add(invoiceDate);
                    }
                    uxInvoiceDates.SelectedItem = importResult.MostFrequentInvoiceDate;
                    uxFilterType.Text = String.Join(", ", importResult.ImportOptions.TypesToInclude.ToArray());
                    RefreshDepartmentsAndDivisions();
                    RaiseIsValid();
                }
                catch (Exception ex) {
                    uxDataPanel.Visible = false;
                    uxExcelFile.Text = "(geen bestand geselecteerd)";
                    RaiseIsInValid();

                    using (var dialog = new MasterDialogForm(this.ParentForm) {
                        HeaderColor = MasterDialogForm.Error,
                        HeaderTitleColor = MasterDialogForm.ErrorWhiteOnDarkRed,
                        HeaderTitle = $"Algemene fout '{ex.GetType().Name}'"
                    }) {
                        dialog.AppendText($"Er is een onverwachte fout opgetreden tijdens het inlezen van het EXCEL bestand. Onderaan staat informatie die nuttig is voor de applicatieontwikkelaars, gelieve van deze informatie een screenshot te maken en hen deze te bezorgen alvorens u op de knop ok drukt. Na het drukken op de knop ok zal u opnieuw de kans krijgen om een EXCEL bestand te selecteren.");
                        dialog.AppendText(Environment.NewLine);
                        dialog.AppendText(Environment.NewLine);
                        dialog.AppendText($"- OMSCHRIJVING: {ex.Message}");
                        dialog.AppendText(Environment.NewLine);
                        dialog.AppendText($"- STACKTRACE: {ex.StackTrace}");
                        dialog.ShowDialog(this.ParentForm);
                    }
               }
            }
        }

        private void RefreshDepartmentsAndDivisions() {
            uxDepartmentsAndDivisions.Nodes.Clear();
            foreach (var department in _result.Records.Select(d => d.Department).Distinct()) {
                var departmentNode = uxDepartmentsAndDivisions.Nodes.Add(department.Name);
                departmentNode.Tag = department.Id.ToString();
                if (department.IsUnknown) {
                    departmentNode.ForeColor = Color.DarkCyan;
                }
                if (department.CanIgnore) {
                    //departmentNode.ForeColor = Color.Gray;
                    departmentNode.NodeFont = new Font(this.Font, FontStyle.Strikeout);
                }
                foreach (var division in department.Divisions) {
                    var divisionNode = departmentNode.Nodes.Add(division.Name);
                    divisionNode.Tag = division.Id.ToString();
                    if (division.IsUnknown) {
                        divisionNode.ForeColor = Color.DarkCyan;
                    }
                    if (division.CanIgnore) {
                        //divisionNode.ForeColor = Color.Gray;
                        divisionNode.NodeFont = new Font(this.Font, FontStyle.Strikeout);
                    }
                }
            }
        }

        private void _bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Result is Exception) {

                var ex = e.Result as Exception;
                uxBusyPanel.Visible = false;
                uxBrowseExcelFile.Enabled = true;
                uxDataPanel.Visible = false;
                RaiseIsInValid();
                uxBusyPanel.Visible = false;
                uxBrowseExcelFile.Enabled = true;
                uxExcelFile.Text = "(geen bestand geselecteerd)";

                using (var dialog = new MasterDialogForm(this.ParentForm) {
                    HeaderColor = MasterDialogForm.Error,
                    HeaderTitleColor = MasterDialogForm.ErrorWhiteOnDarkRed,
                    HeaderTitle = $"Algemene fout '{ex.GetType().Name}'"
                }) {
                    dialog.AppendText($"Er is een onverwachte fout opgetreden tijdens het inlezen van het EXCEL bestand. Onderaan staat informatie die nuttig is voor de applicatieontwikkelaars, gelieve van deze informatie een screenshot te maken en hen deze te bezorgen alvorens u op de knop ok drukt. Na het drukken op de knop ok zal u opnieuw de kans krijgen om een EXCEL bestand te selecteren.");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"- OMSCHRIJVING: {ex.Message}");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"- STACKTRACE: {ex.StackTrace}");
                    dialog.ShowDialog(this.ParentForm);
                }
            }
            else {
                uxBusyPanel.Visible = false;
                uxBrowseExcelFile.Enabled = true;
                ShowImportResult(e.Result as EBloxImportResult, e.Error);
            }
        }

        private void _bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage < 0) {
                uxProgressBar.Style = ProgressBarStyle.Marquee;
                uxProgressInfo.Text = $"{e.UserState.ToString()} ({(e.ProgressPercentage*-1).ToString()}%)";
            }
            else {
                uxProgressBar.Style = ProgressBarStyle.Continuous;
                uxProgressBar.Value = e.ProgressPercentage;
                uxProgressInfo.Text = $"{e.UserState.ToString()} ({e.ProgressPercentage.ToString()}%)";
            }
        }

        private void _bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {
                _bgWorker.ReportProgress(0, "Inladen import opties...");
                var eBloxImportOptionsLoader = new EBloxImportOptionsJsonLoader(new FileInfo("Settings/EBloxImportOptions.json"));
                var calculationSettingsLoader = new CalculationSettingsJsonLoader(new FileInfo("Settings/CalculationSettings.json"));
                var invoiceSimulationSettingsLoader = new InvoiceSimulationSettingsJsonLoader(new FileInfo("Settings/InvoiceSimulationSettings.json"));
                _bgWorker.ReportProgress(9, "Import opties ingeladen.");
                _bgWorker.ReportProgress(10, "Inladen departementen en projecten...");
                var businessDepartmentRepository = new DepartmentRepository(eBloxImportOptionsLoader.Load().Departments);
                _bgWorker.ReportProgress(15, "Departementen en projecten ingeladen.");
                _bgWorker.ReportProgress(25, "Initialisatereb werknemers- en kostencategoriën...");
                var employeeRepository = new EmployeeRepository();
                var costCategoryRepository = new CostCategoryRepository();
                _bgWorker.ReportProgress(30, "Initialisatie werknemers- en kostencategoriën voltooid.");

                _bgWorker.ReportProgress(35, "Initialisatie EXCEL importer...");
                var ebloxExcelImporter = new EBloxOleDbExcelImporter(businessDepartmentRepository, employeeRepository, costCategoryRepository, eBloxImportOptionsLoader, calculationSettingsLoader, invoiceSimulationSettingsLoader);
                _bgWorker.ReportProgress(40, "EXCEL importer geïnitialiseerd.");

                _bgWorker.ReportProgress(-45, "Inlezen excel bestand...");
                var result = ebloxExcelImporter.Import(new FileInfo(e.Argument.ToString()));
                e.Result = result;                
            } catch(Exception ex) {
                e.Result = ex;
            }
        }

        private void uxToggleIgnoreIncludeDepartmentsAndDivisions_Click(object sender, EventArgs e) {
            var selectedNode = uxDepartmentsAndDivisions.SelectedNode;
            if(selectedNode != null) {
                if(selectedNode.Level == 0) {
                    // Dept
                    var department = _result.DepartmentRepository.GetDepartment(Int32.Parse(selectedNode.Tag.ToString()));
                    department.CanIgnore = !department.CanIgnore;
                    foreach(var division in department.Divisions) {
                        division.CanIgnore = !division.CanIgnore;
                    }
                }
                if(selectedNode.Level == 1) {
                    // Div
                    var department = _result.DepartmentRepository.GetDepartment(Int32.Parse(selectedNode.Parent.Tag.ToString()));
                    var division = _result.DepartmentRepository.GetDivision(Int32.Parse(selectedNode.Tag.ToString()), department);
                    division.CanIgnore = !division.CanIgnore;
                }
            }

            RefreshDepartmentsAndDivisions();
        }

        private void uxStartDateInvoice_ValueChanged(object sender, EventArgs e) {
            _result.StartDateCorrection = uxStartDateInvoice.Value;
        }

        private void uxEndDateInvoice_ValueChanged(object sender, EventArgs e) {
            _result.EndDateCorrection = uxEndDateInvoice.Value;
        }

        private void uxInvoiceDates_SelectedIndexChanged(object sender, EventArgs e) {
            _result.SelectedInvoiceDate = (DateTime)uxInvoiceDates.SelectedItem;
        }
    }
}
