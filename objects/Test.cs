using NUnit.Framework;

namespace ConsoleApplication.Test
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
}