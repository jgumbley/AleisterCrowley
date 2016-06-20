using System;

namespace AleisterCrowley
{
    public class WizardJourney {

        public void doSomething() {
              Console.WriteLine("yo bizzle!");          
        }

        public void nextStepInJourney() {
            throw new EndOfWizardException();

        }



    }

    public class EndOfWizardException : System.Exception {}
}