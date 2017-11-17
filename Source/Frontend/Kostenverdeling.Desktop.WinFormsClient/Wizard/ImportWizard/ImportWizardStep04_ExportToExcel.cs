using System;
using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public class ImportWizardStep04_ExportToExcel : WizardStep
    {
        public ImportWizardStep04_ExportToExcel(WizardController controller) : base(controller) {
            _view = new ImportWizardStep04_ExportToExcel_View(((ImportWizardController)controller));
            _view.IsValid += _view_IsValid;
            _view.IsInValid += _view_IsInValid;
        }

        private void _view_IsInValid(object sender, EventArgs e) {
            Controller.RaiseStatusChanged();
        }

        private void _view_IsValid(object sender, EventArgs e) {
            Controller.RaiseStatusChanged();
        }

        public override void IsActivated() {
            _view.Reset();
        }

        public override bool CanGoToPreviousStep { get { return true; } }

        public override int Id { get { return 4; } }
        
        public override bool IsValid { get { return false; } }

        public override string Title { get { return "Exporteer resultaten naar EXCEL bestand(en)"; } }

        private ImportWizardStep04_ExportToExcel_View _view = null;
        public override Control UserInterface { get { return _view; } }
    }
}
