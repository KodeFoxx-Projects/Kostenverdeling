using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Kostenverdeling.Model.DataExport;
using System.Diagnostics;
using Kostenverdeling.Desktop.WinFormsClient.Common;
using Kostenverdeling.Model.Settings;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public partial class ImportWizardStep04_ExportToExcel_View : UserControl
    {

        public event EventHandler IsValid;
        public event EventHandler IsInValid;

        private void RaiseIsValid() {
            if (IsValid != null) {
                IsValid(this, EventArgs.Empty);
            }
        }

        public void Reset() {
            StartExportProcedure(false);
        }

        private void RaiseIsInValid() {
            if (IsInValid != null) {
                IsInValid(this, EventArgs.Empty);
            }
        }

        private readonly ImportWizardController _controller;
        public ImportWizardStep04_ExportToExcel_View(ImportWizardController controller) {
            InitializeComponent();
            _controller = controller;
            if (_controller.ExportDirectory == null || !_controller.ExportDirectory.Exists) {
                uxExcelFile.Text = "(geen locatie (map) geselecteerd)";
                RaiseIsInValid();
            } else {
                uxExcelFile.Text = _controller.ExportDirectory.FullName;
                RaiseIsValid();
            }
        }

        private void uxBrowseExcelFile_Click(object sender, EventArgs e) {
            StartExportProcedure();
        }
        private void StartExportProcedure(bool showDialogBrowser = true) {
            uxOkPanel.Visible = false;
            uxBusyPanel.Visible = false;
            uxExcelFile.Text = "(geen locatie (map) geselecteerd)";
            if (showDialogBrowser) {
                using (var folderBrowserDialog = new FolderBrowserDialog()) {
                    folderBrowserDialog.Description = "Selecteer een locatie (map) waarin de EXCEL bestanden zullen geëxporteerd worden...";
                    folderBrowserDialog.ShowNewFolderButton = true;
                    folderBrowserDialog.SelectedPath = 
                        Directory.Exists(ApplicationSettings.Current.DefaultExportLocation)
                         ? ApplicationSettings.Current.DefaultExportLocation
                         : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var result = folderBrowserDialog.ShowDialog();
                    var user = "";
                    try {
                        user = Environment.UserName;
                    }
                    catch { }
                    var path = Path.Combine(
                                folderBrowserDialog.SelectedPath,
                                "exports",
                                $"export_{DateTime.UtcNow.ToString("yyyyMMdd_HHmmss")}{(String.IsNullOrWhiteSpace(user) ? "" : $"_{user.ToLower()}")}");
                    if (!Directory.Exists(path)) {
                        Directory.CreateDirectory(path);
                    }
                    if (result == DialogResult.OK && Directory.Exists(path)) {
                        uxExcelFile.Text = path;
                        _controller.ExportDirectory = new DirectoryInfo(path);
                        RaiseIsValid();
                        RunExport();
                    }
                    else {
                        _controller.ExportDirectory = null;
                        uxExcelFile.Text = "(geen locatie (map) geselecteerd)";
                        RaiseIsInValid();
                    }
                }
            }
        }

        private DirectoryInfo ExportFolder { get; set; }

        private void RunExport() {
            uxOkPanel.Visible = false;
            uxBusyPanel.Visible = true;
            uxProgressBar.Value = 0;
            uxProgressInfo.Text = "Bezig met exporteren...";
            var exporter = new DataExporter(_controller.ExportDirectory, _controller.ImportResult, _controller.CalculationReports);
            exporter.ProgressChanged += (s, e) => {
                uxProgressBar.Value = e.ProgressPercentage;                
                uxProgressInfo.Text = $"{e.ProgressPercentage}% - {e.UserState.ToString()}";
            };
            exporter.Completed += (s, e) => {
                if (e.Error == null) {
                    uxProgressInfo.Text = "Het exporteren is voltooid.";
                    ExportFolder = exporter.ExportDirectory;
                    uxOkInfoText.Text = $"Het exporteren naar de EXCEL bestanden is succesvol afgerond. Je kan de bestanden vinden op de locatie (map) '{exporter.ExportDirectory.FullName}'. Druk op de knop 'Export map openen...' om de map automatisch te openen in de Windows Verkenner. Je kan de applicatie nu afsluiten.";
                    uxOpenExportFolder.Top = uxOkInfoText.Top + uxOkInfoText.Height + 8;
                    uxExportAgain.Top = uxOpenExportFolder.Top;
                    uxOkPanel.Visible = true;

                    ShowInfoScreen();

                } else {
                    uxProgressInfo.Text = "Er is een fout opgetreden tijdens het exporteren.";

                    using (var dialog = new MasterDialogForm(this.ParentForm) {
                        HeaderColor = MasterDialogForm.Error,
                        HeaderTitleColor = MasterDialogForm.ErrorWhiteOnDarkRed,
                        HeaderTitle = $"Fout '{e.Error.GetType().Name}' tijdens exporteren"
                    }) {
                        dialog.AppendText($"Er is een onverwachte fout opgetreden tijdens het exporteren naar de EXCEL bestanden. Onderaan staat informatie die nuttig is voor de applicatieontwikkelaars, gelieve van deze informatie een screenshot te maken en hen deze te bezorgen alvorens u op de knop ok drukt. Na het drukken op de knop ok zal u opnieuw de kans krijgen om opnieuw to proberen exporteren.");
                        dialog.AppendText(Environment.NewLine);
                        dialog.AppendText(Environment.NewLine);
                        dialog.AppendText($"- OMSCHRIJVING: {e.Error.Message}");
                        dialog.AppendText(Environment.NewLine);
                        dialog.AppendText($"- STACKTRACE: {e.Error.StackTrace}");
                        dialog.ShowDialog(this.ParentForm);
                        StartExportProcedure(false);
                    }
                }
            };
            exporter.StartExportAsync();
        }

        private void ShowInfoScreen() {
            using (var dialog = new MasterDialogForm(this.ParentForm) {
                HeaderColor = MasterDialogForm.Info,
                HeaderTitleColor = MasterDialogForm.InfoWhiteOnDarkBlue,
                HeaderTitle = $"Exporteren voltooid"
            }) {
                dialog.AppendText($"Het exporteren naar de EXCEL bestanden is succesvol afgerond. Je kan de bestanden vinden op de locatie (map) '{ExportFolder.FullName}'.");
                dialog.AppendText(Environment.NewLine);
                dialog.AppendText(Environment.NewLine);
                dialog.AppendText(Environment.NewLine);
                dialog.AppendText("Let op! Er zijn nog enkele zaken die je manueel moet controleren in de EXCEL bestanden: ");
                dialog.AppendText(Environment.NewLine);
                dialog.AppendText(Environment.NewLine);
                var counter = 1;
                foreach (var calculationReport in _controller.CalculationReports) {                    
                    dialog.AppendText($" {counter.ToString()}) {calculationReport.Department.Name.ToUpper()}");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"   a) Controleer de resultaten van de export.");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"   b) 'Beheer speciale werken' moet nog manueel aangepast worden in de output.");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"   c) 'RSZ provisie' moet nog manueel aangepast worden in de output.");                    
                    if (calculationReport.IgnoreInvoiceNumber) {
                        dialog.AppendText(Environment.NewLine);
                        dialog.AppendText($"   d) Factuurnummer moet nog manueel worden invgevuld.");
                    }
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText(Environment.NewLine);
                    counter++;
                }
                dialog.ShowDialog(this.ParentForm);                
            }
        }

        private void uxOpenExportFolder_Click(object sender, EventArgs e) {
            if (ExportFolder != null) {
                Process.Start(ExportFolder.FullName);
            }
        }

        private void uxExportAgain_Click(object sender, EventArgs e) {
            StartExportProcedure();
        }
    }
}
