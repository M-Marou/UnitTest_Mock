using Mocking;
using Moq;
using NUnit.Framework;

namespace MockUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ImplementedMethod_Test()
        {
            var mock = new Mock<Repository>();

            Business business = new Business(mock.Object);

            Assert.AreEqual(4, business.Addition(2, 2));
        }

        [Test]
        public void NotImplementedMethod_Test()
        {
            var mock = new Mock<Repository>();

            mock.Setup(s => s.Sub(3, 2)).Returns(1);

            Business business = new Business(mock.Object);

            Assert.AreEqual(1, business.Subtraction(3, 2));
        }
    }
}