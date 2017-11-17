using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public class ImportWizardStep02_SelectExcelFile : WizardStep
    {
        public ImportWizardStep02_SelectExcelFile(WizardController controller) : base(controller) {
            _view = new ImportWizardStep02_SelectExcelFile_View((ImportWizardController)controller);
            _view.IsValid += _view_IsValid;
            _view.IsInValid += _view_IsInValid;            
        }

        private void _view_IsInValid(object sender, EventArgs e) {
            _isValid = false;
            Controller.RaiseStatusChanged();
        }

        private void _view_IsValid(object sender, EventArgs e) {
            _isValid = true;
            Controller.RaiseStatusChanged();
        }

        public override void IsActivated() {            
        }

        public override bool CanGoToPreviousStep { get { return true; } }

        public override int Id { get { return 2; } }

        private bool _isValid = false;
        public override bool IsValid { get { return _isValid; } }

        public override string Title { get { return "Importeer EXCEL bestand en definieer bedrijven, projecten en start- en einddatum"; } }

        private ImportWizardStep02_SelectExcelFile_View _view = null;
        public override Control UserInterface { get { return _view; } }
    }
}
