using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareDeveloperIO.Collections.Generic.Test
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void Should_ReturnTrue_When_NodeRemoved1()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);

            bool actual = list.Remove(3);

            Assert.IsTrue(actual);
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void Should_ReturnFalse_When_NodeNotFoundNotRemoved1()
        {
            var list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);

            bool actual = list.Remove(13);

            Assert.IsFalse(actual);
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveMiddleNodesAndCheckSequence()
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

            list.Remove(13);
            list.Remove(3);

            int[] expected = { 2, 5, 8, 21, 34, 55 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveFirstNodeAndCheckSequence()
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

            list.Remove(2);

            int[] expected = { 3, 5, 8, 13, 21, 34, 55 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveFirst2NodesAndCheckSequence()
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

            list.Remove(2);
            list.Remove(3);

            int[] expected = { 5, 8, 13, 21, 34, 55 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveFirst3NodesAndCheckSequence()
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

            list.Remove(2);
            list.Remove(3);
            list.Remove(5);

            int[] expected = { 8, 13, 21, 34, 55 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveFirst3NodesAndAMiddleNodeAndCheckSequence()
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

            list.Remove(2);
            list.Remove(3);
            list.Remove(5);
            list.Remove(21);

            int[] expected = { 8, 13, 34, 55 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveLastNodeAndCheckSequence()
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

            list.Remove(55);

            int[] expected = { 2, 3, 5, 8, 13, 21, 34 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveLast2NodeAndCheckSequence()
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

            list.Remove(55);
            list.Remove(34);

            int[] expected = { 2, 3, 5, 8, 13, 21 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveLast3NodeAndCheckSequence()
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

            list.Remove(55);
            list.Remove(34);
            list.Remove(21);

            int[] expected = { 2, 3, 5, 8, 13 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveLast3NodeAndAMiddleNodeAndCheckSequence()
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

            list.Remove(55);
            list.Remove(34);
            list.Remove(21);
            list.Remove(5);

            int[] expected = { 2, 3, 8, 13 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveFurstMidleLastNodes()
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

            list.Remove(2);
            list.Remove(55);
            list.Remove(13);

            int[] expected = { 3, 5, 8, 21, 34 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveVariousNodes()
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

            list.Remove(2);
            list.Remove(3);
            list.Remove(55);
            list.Remove(34);
            list.Remove(13);
            list.Remove(8);

            int[] expected = { 5, 21 };
            int counter = 0;

            var node = list.First;
            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Next;
                counter++;
            }


        }

        [TestMethod]
        public void Should_ReturnTrue_When_RemoveAllNodes()
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

            list.Remove(2);
            list.Remove(3);
            list.Remove(55);
            list.Remove(34);
            list.Remove(13);
            list.Remove(8);
            list.Remove(5);
            list.Remove(21);

            int count = list.Count;

            Assert.AreEqual(0, count);


        }

    }
}
