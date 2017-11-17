using System.Collections.Generic;
using System.Windows.Forms;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard
{
    public abstract class WizardStep
    {
        public WizardStep(WizardController controller) {
            Controller = controller;
        }

        public abstract int Id { get; }
        public abstract string Title { get; }        
        public abstract Control UserInterface { get; }
        public WizardController Controller { get; }
        public abstract bool IsValid { get; }
        public abstract bool CanGoToPreviousStep { get; }
        public abstract void IsActivated();
    }
}
