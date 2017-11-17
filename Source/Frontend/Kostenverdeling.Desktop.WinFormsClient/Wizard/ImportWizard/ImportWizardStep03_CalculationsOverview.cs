using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public class ImportWizardStep03_CalculationsOverview : WizardStep
    {
        public ImportWizardStep03_CalculationsOverview(WizardController controller) : base(controller) {
            _view = new ImportWizardStep03_CalculationsOverview_View(((ImportWizardController)controller));
            _view.IsValid += _view_IsValid;
            _view.IsInValid += _view_IsInValid;
        }

        private void _view_IsInValid(object sender, System.EventArgs e) {
            _isValid = false;
            Controller.RaiseStatusChanged();
        }

        private void _view_IsValid(object sender, System.EventArgs e) {
            _isValid = true;
            Controller.RaiseStatusChanged();
        }

        public override bool CanGoToPreviousStep { get { return true; } }

        public override int Id { get { return 3; } }

        private bool _isValid = false;
        public override bool IsValid { get { return _isValid; } }

        public override string Title { get { return "Overzicht berekeningen"; } }

        private ImportWizardStep03_CalculationsOverview_View _view = null;
        public override Control UserInterface { get { return _view; } }

        public override void IsActivated() {
            _view.RefreshCalculations();
        }
    }
}
