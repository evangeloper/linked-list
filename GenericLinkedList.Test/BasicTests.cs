using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareDeveloperIO.Collections.Generic.Test
{
    [TestClass]
    public class BasicTests
    {

        [TestMethod]
        public void Should_CountReturnZero_When_ListInitiallyCreated()
        {
            ILinkedList<int> list = new LinkedList<int>();
            Assert.IsTrue(list.Count == 0);
        }

        [TestMethod]
        public void Should_ListBeEmpty_When_ListInitiallyCreated()
        {
            ILinkedList<int> list = new LinkedList<int>();
            Assert.IsTrue(list.IsEmpty);
        }

        [TestMethod]
        public void Should_FirstReturnNull_When_ListInitiallyCreated()
        {
            ILinkedList<int> list = new LinkedList<int>();
            Assert.IsTrue(list.First == null);
        }

        [TestMethod]
        public void Should_LastReturnNull_When_ListInitiallyCreated()
        {
            ILinkedList<int> list = new LinkedList<int>();
            Assert.IsTrue(list.Last == null);
        }

    }
}
