using NUnitTesting;

namespace NumberTest
{
    [TestFixture]
    public class Tests
    {
       
        [Test]
        public void IS_EVEN()
        {
            string expected = "Even";
            OddEven o = new OddEven(10);
            string actual = o.IsEven();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IS_ODD()
        {
            string expected = "Odd";
            OddEven o = new OddEven(9);
            string actual = o.IsEven();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IS_NOT_ODD()
        {
            string expected = "Odd";
            OddEven o = new OddEven(10);
            string actual = o.IsEven();
            Assert.IsTrue(actual !=  expected);
        }
    }
}