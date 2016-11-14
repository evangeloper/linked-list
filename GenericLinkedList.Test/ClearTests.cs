using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareDeveloperIO.Collections.Generic.Test
{
    [TestClass]
    public class ClearTests
    {
        [TestMethod]
        public void Should_ReturnTrue_When_AllNodesCleared()
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

            list.Clear();

            int count = list.Count;

            Assert.AreEqual(0, count);
            Assert.AreEqual(null, list.First);
            Assert.AreEqual(null, list.Last);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_AllNodesClearedAnd1Added()
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

            list.Clear();

            list.AddLast(2);

            int count = list.Count;

            Assert.AreEqual(1, count);
        }
    }
}
