using NUnit.Framework;

namespace AleisterCrowley.Test
{
    [TestFixture]
    public class WizardTests
    {
        [TestCase]
        public void EmptyWizard_EndOfWizardException()
        {
            // Given
            WizardJourney wiz = new WizardJourney();
            // When Then
            Assert.Throws<EndOfWizardException>(delegate { 
                wiz.nextStepInJourney(); 
                });
        }

        [TestCase]
        public void OneStepWizard_GetNext()
        {
            // Given
            WizardJourney wiz = new WizardJourney();
            // When 
            WizardStep step = new WizardStep();
            wiz.addStep(step);
            
            // Then
            Assert.That(wiz.nextStepInJourney(), Is.EqualTo(step)); 
        }
    }
}