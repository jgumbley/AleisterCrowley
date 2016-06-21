using System;

namespace AleisterCrowley
{
    public class WizardJourney {

        private WizardStep _step = null;

        public WizardStep nextStepInJourney() {
            if (_step == null) {
                throw new EndOfWizardException();
            }
            return _step;
        }

        public void addStep(WizardStep step) {
            _step = step;
        }
    }

    public class WizardStep {

    }

    public class EndOfWizardException : System.Exception {}
}