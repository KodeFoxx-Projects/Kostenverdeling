using System;
using System.Collections.Generic;
using System.Linq;

namespace Kostenverdeling.Desktop.WinFormsClient.Wizard
{
    public class WizardController
    {
        private List<WizardStep> _wizardSteps;
        private WizardStep _current;    
        public WizardStep Current { get { return _current; } }
        public event EventHandler StatusChanged;

        internal void RaiseStatusChanged() {
            if(StatusChanged != null) {
                StatusChanged(this, EventArgs.Empty);
            }
        }

        public WizardController(List<WizardStep> wizardSteps = null) {            
            if(_wizardSteps == null) {
                _wizardSteps = new List<WizardStep>();
            } else {
                _wizardSteps = wizardSteps;
            }
            _current = Reset();
        }

        public void AddStep(WizardStep wizardStep) {
            _wizardSteps.Add(wizardStep);
            _current = Reset();
        }

        public WizardStep Reset() {
            return _wizardSteps.Where(s => s.Id == _wizardSteps.Min(ws => ws.Id)).SingleOrDefault();
        }        

        public WizardStep Next() {
            if(CanGoNext()) {
                _current = _wizardSteps.Where(s => s.Id == _current.Id + 1).SingleOrDefault();
                return _current;
            }
            return null;
        }
        public bool CanGoNext() {
            return _current.IsValid && (_wizardSteps.Where(s => s.Id == _current.Id + 1).SingleOrDefault() != null);
        }
        public WizardStep Previous() {
            if (CanGoPrevious()) {
                _current = _wizardSteps.Where(s => s.Id == _current.Id - 1).SingleOrDefault();
                return _current;
            }
            return null;
        }
        public bool CanGoPrevious() {
            return _current.CanGoToPreviousStep && (_wizardSteps.Where(s => s.Id == _current.Id - 1).SingleOrDefault() != null);
        }
    }
}
