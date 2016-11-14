using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareDeveloperIO.Collections.Generic.Test
{
    [TestClass]
    public class FindTests
    {
        [TestMethod]
        public void Should_ReturnTrue_When_NodeExists()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);
            list.AddLast(13);
            list.AddLast(21);
            list.AddLast(34);
            list.AddLast(55);

            var node = list.Find(8);

            Assert.AreEqual(8, node.Value);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_NodeDontExists()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);
            list.AddLast(13);
            list.AddLast(21);
            list.AddLast(34);
            list.AddLast(55);

            var node = list.Find(100);

            Assert.AreEqual(null, node);

        }
    }
}
