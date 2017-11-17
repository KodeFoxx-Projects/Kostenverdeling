using Kostenverdeling.Desktop.WinFormsClient.Common;
using Kostenverdeling.Desktop.WinFormsClient.Config;
using Kostenverdeling.Desktop.WinFormsClient.Wizard;
using Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard;
using Kostenverdeling.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient
{
    public partial class Main : MasterForm
    {
        private ImportWizardController _wizardController = new ImportWizardController();

        public Main() {
            InitializeComponent();
            VisualizeWizard();

            this.Text = this.Text.Replace("%version%", $"{Utils.RenderVersion(Assembly.GetEntryAssembly())}");
            _wizardController.StatusChanged += _wizardController_StatusChanged;            
        }

        private void _wizardController_StatusChanged(object sender, EventArgs e) {
            uxWizardPrevious.Enabled = _wizardController.CanGoPrevious();
            uxWizardNext.Enabled = _wizardController.CanGoNext();
        }

        public void VisualizeWizard() {
            try {
                uxWizardStepTitle.Text = $"Stap {_wizardController.Current.Id.ToString()}: {_wizardController.Current.Title}";
                uxWizardStepViewHost.Controls.Clear();
                uxWizardStepViewHost.Controls.Add(_wizardController.Current.UserInterface);
                uxWizardStepViewHost.Controls[0].Dock = DockStyle.Fill;
                _wizardController.Current.IsActivated();
                uxWizardPrevious.Enabled = _wizardController.CanGoPrevious();
                uxWizardNext.Enabled = _wizardController.CanGoNext();
            } catch(Exception ex) {
                using (var dialog = new MasterDialogForm(this) {
                    HeaderColor = MasterDialogForm.Error,
                    HeaderTitleColor = MasterDialogForm.ErrorWhiteOnDarkRed,
                    HeaderTitle = $"Algemene fout '{ex.GetType().Name}'"
                }) {
                    dialog.AppendText($"Er is een onverwachte fout opgetreden tijdens het uitvoeren van een actie. Onderaan staat informatie die nuttig is voor de applicatieontwikkelaars, gelieve van deze informatie een screenshot te maken en hen deze te bezorgen alvorens u op de knop ok drukt. Na het drukken op de knop ok zal de applicatie zal zichzelf proberen herstellen zodat u opnieuw kan proberen.");
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"- OMSCHRIJVING: {ex.Message}");                    
                    dialog.AppendText(Environment.NewLine);
                    dialog.AppendText($"- STACKTRACE: {ex.StackTrace}");
                    dialog.ShowDialog(this);
                    if (dialog.Result == DialogResult.OK) {
                        Reset();
                    }
                }
            }
        }

        private void uxWizardNext_Click(object sender, EventArgs e) {
            _wizardController.Next();
            VisualizeWizard();
        }

        private void uxWizardPrevious_Click(object sender, EventArgs e) {
            _wizardController.Previous();
            VisualizeWizard();
        }

        private void uxCancel_Click(object sender, EventArgs e) {
            /*var wz = (_wizardController as ImportWizardController);            
            if (wz.ExportDone) {
                this.Close();
            }
            if(wz.ExportDirectory != null && wz.ExportDirectory.Exists) {
                wz.ExportDirectory.Delete();
            }*/
            this.Close();
        }

        private void uxReset_Click(object sender, EventArgs e) {
            using (var dialog = new MasterDialogForm(this, true) {
                HeaderColor = MasterDialogForm.Question,
                HeaderTitleColor = MasterDialogForm.QuestionWhiteOnDarkYellow,
                HeaderTitle = "Wilt u opnieuw beginnen?"
            }) {
                dialog.AppendText("Wanneer u opnieuw begint zal het programma alle reeds geconfigureerde informatie wissen zodat u volledig opnieuw kan starten.");
                dialog.AppendText(Environment.NewLine);
                dialog.AppendText($"Als u zeker bent dat u opnieuw wilt beginnen en daarbij alle gemaakte instellingen wilt wissen, druk dan op ok. {Environment.NewLine}Als u echter niet zeker bent dan drukt u op de knop annuleren om verder te gaan met de applicatie.");                
                dialog.ShowDialog(this);
                if(dialog.Result == DialogResult.OK) {
                    Reset();
                }
            }            
        }

        private void Reset() {
            _wizardController = new ImportWizardController();
            _wizardController.StatusChanged += _wizardController_StatusChanged;
            VisualizeWizard();
        }

        private void uxConfig_Click(object sender, EventArgs e) {
            var configurationScreen = new Configuration();
            configurationScreen.ShowDialog();
        }
    }
}
