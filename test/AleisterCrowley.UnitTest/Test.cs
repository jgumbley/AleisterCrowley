using NUnit.Framework;

namespace AleisterCrowley.Test
{
    [TestFixture]
    public class ExcludedMiddleTests
    {
        [TestCase(true)]
        public void CanShowEquality(bool value)
        {
            Assert.That(value, Is.EqualTo(true));
        }
    }

    [TestFixture]
    public class WizardTests
    {
        [TestCase]
        public void CanCreateWizard()
        {
            WizardJourney wiz = new WizardJourney();
        }
    }
}