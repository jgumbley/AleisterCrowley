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
    }
}