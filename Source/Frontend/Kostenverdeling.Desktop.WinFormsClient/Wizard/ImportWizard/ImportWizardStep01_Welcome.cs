using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard.ImportWizard
{
    public class ImportWizardStep01_Welcome : WizardStep
    {
        public ImportWizardStep01_Welcome(WizardController controller) : base(controller) { }

        public override bool CanGoToPreviousStep { get { return false; } }

        public override int Id { get { return 1; } }

        public override bool IsValid { get { return true; } }

        public override string Title { get { return "Welkom"; } }

        private ImportWizardStep01_Welcome_View _view = new ImportWizardStep01_Welcome_View();
        public override Control UserInterface { get { return _view; } }

        public override void IsActivated() {            
        }
    }
}
