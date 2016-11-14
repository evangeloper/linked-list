using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareDeveloperIO.Collections.Generic.Test
{
    [TestClass]
    public class ContainsTests
    {
        [TestMethod]
        public void Should_ReturnTrue_When_ValueIsPresent1()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);

            bool actual = list.Contains(5);

            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_ValueIsPresent2()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);

            bool actual = list.Contains(2);

            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_ValueIsPresent3()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);

            bool actual = list.Contains(8);

            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void Should_ReturnFalse_When_ValueIsNotPresent()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);

            bool actual = list.Contains(13);

            Assert.IsFalse(actual);

        }

    }
}
