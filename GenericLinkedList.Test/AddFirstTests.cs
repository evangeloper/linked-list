using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareDeveloperIO.Collections.Generic.Test
{
    [TestClass]
    public class AddFirstTests
    {
        [TestMethod]
        public void Should_ListBeNotEmpty_When_Adding1Node()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            Assert.IsFalse(list.IsEmpty);
        }

        [TestMethod]
        public void Should_ListCountEquals1_When_Adding1Node()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);

            Assert.IsTrue(list.Count == 1);

        }

        [TestMethod]
        public void Should_FirstValueEquals2_When_Adding2()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);

            Assert.IsTrue(list.First.Value == 2);

        }

        [TestMethod]
        public void Should_FirstNodeNextIsNull_When_Adding1Node()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);

            Assert.IsTrue(list.First.Next == null);

        }

        [TestMethod]
        public void Should_FirstNodePreviousIsNull_When_Adding1Node()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);

            Assert.IsTrue(list.First.Previous == null);

        }

        [TestMethod]
        public void Should_CountEquals2_When_Adding2Nodes()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);

            Assert.IsTrue(list.Count == 2);

        }

        [TestMethod]
        public void Should_FirstNodeValueIs3_When_Adding2NodesWithAddFirstAnd3IsAddedLast()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);

            Assert.IsTrue(list.First.Value == 3);

        }

        [TestMethod]
        public void Should_LastNodeValueIs2_When_Adding2NodesWithAddFirstAnd2IsAddedFirst()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);

            Assert.IsTrue(list.Last.Value == 2);

        }

        [TestMethod]
        public void Should_FirstNodePreviousIsNull_WhenAdding3Nodes()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);

            Assert.IsTrue(list.First.Previous == null);

        }

        [TestMethod]
        public void Should_FirstValueIs5_When_Adding3NodesWithAddFirstAndLastAddedNodeIs5()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);

            Assert.IsTrue(list.First.Value == 5);

        }

        [TestMethod]
        public void Should_FirstNodeNextValueIs3_When_Adding3NodesAndSecondNodeIs3()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);

            Assert.IsTrue(list.First.Next.Value == 3);

        }

        [TestMethod]
        public void Should_FirstNextNextNextValueIs2_When_Adding2First()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);

            Assert.IsTrue(list.First.Next.Next.Value == 2);

        }

        [TestMethod]
        public void Should_FirstNextNextNextIsNull_When_Adding3Nodes()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);

            Assert.IsTrue(list.First.Next.Next.Next == null);
        }

        [TestMethod]
        public void Should_FirstNextPreviousValueIs5_When_Adding3NodesUsingAddFirstAnd5AddedLast()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);

            Assert.IsTrue(list.First.Next.Previous.Value == 5);
        }

        [TestMethod]
        public void Should_FirstNextNextPreviousValueIs3_When_Adding3NodesWithAddFirstAnd3InTheMiddle()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);

            Assert.IsTrue(list.First.Next.Next.Previous.Value == 3);
        }

        [TestMethod]
        public void Should_FirstNextNextNextPreviousValueIs3_When3AddedSecond()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);

            Assert.IsTrue(list.First.Next.Next.Next.Previous.Value == 3);
        }

        [TestMethod]
        public void Should_LastValuesIs2_When_UsingAddFirstAnd2AddedFirst()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);

            Assert.IsTrue(list.Last.Value == 2);

        }

        [TestMethod]
        public void Should_LastPreviousValueIs3_When_3AddedSecond()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);

            Assert.IsTrue(list.Last.Previous.Value == 3);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding4NodesAndLasPreviosuPreviousValueIs5()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);

            Assert.IsTrue(list.Last.Previous.Previous.Value == 5);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding4NodesAndLastPreviousPreviousPreviousValueIs8()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);

            Assert.IsTrue(list.Last.Previous.Previous.Previous.Value == 8);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding4NodesAndLastPreviousPreviousPreviousIsNull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);

            Assert.IsTrue(list.Last.Previous.Previous.Previous.Previous == null);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding235LastPreviousPreviousPreviousIsNull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);

            Assert.IsTrue(list.Last.Previous.Previous.Previous == null);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_AddingSeveralNumbersTraversingListForwardWithForLoop()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);
            list.AddFirst(13);
            list.AddFirst(21);
            list.AddFirst(34);
            list.AddFirst(55);

            int[] expected = { 55, 34, 21, 13, 8, 5, 3, 2 };
            var node = list.First;
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], node.Value);
                node = node.Next;
            }

        }

        [TestMethod]
        public void Should_ReturnTrue_When_AddingSeveralNumbersTraversingListForwardWithWhileLoop()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);
            list.AddFirst(13);
            list.AddFirst(21);
            list.AddFirst(34);
            list.AddFirst(55);

            int[] expected = { 55, 34, 21, 13, 8, 5, 3, 2 };
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
        public void Should_ReturnTrue_When_AddingSeveralNumbersTraversingListBackwardsWithWhileLoop()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);
            list.AddFirst(13);
            list.AddFirst(21);
            list.AddFirst(34);
            list.AddFirst(55);

            int[] expected = { 55, 34, 21, 13, 8, 5, 3, 2 };
            int counter = 7;

            var node = list.Last;

            while (node != null)
            {
                Assert.AreEqual(expected[counter], node.Value);
                node = node.Previous;
                counter--;
            }
        }

        [TestMethod]
        public void Should_ReturnTrue_When_AddingSeveralNumbersTraversingListBackwardsWithForLoop()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(8);
            list.AddFirst(13);
            list.AddFirst(21);
            list.AddFirst(34);
            list.AddFirst(55);

            int[] expected = { 55, 34, 21, 13, 8, 5, 3, 2 };
            var node = list.Last;
            for (var i = 7; i >= 0; i--)
            {
                Assert.AreEqual(expected[i], node.Value);
                node = node.Previous;
            }
        }
    }
}
