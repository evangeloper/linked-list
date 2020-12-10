using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareDeveloperIO.Collections.Generic;

namespace GenericLinkedList.Test
{
    [TestClass]
    public class AddLastTests
    {
        [TestMethod]
        public void Should_ReturnTrue_When_Adding2FirstValueEquals2()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);

            Assert.IsTrue(list.First.Value == 2);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2LastValueEquals2()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);

            Assert.IsTrue(list.Last.Value == 2);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2FirstPreviosuValueIsnull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);

            Assert.IsTrue(list.First.Previous == null);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2LastNextIsNull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);

            Assert.IsTrue(list.Last.Next == null);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2FirstPreviousIsNull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);

            Assert.IsTrue(list.First.Previous == null);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2And3FirstValueEquals2()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.First.Value == 2);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2And3LastValueEquals3()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.Last.Value == 3);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2And3FirstValuePreviousIsNull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.First.Previous == null);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2And3LastValueNextIsNull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.Last.Next == null);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2And3LastValuePreviousValueIs2()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.Last.Previous.Value == 2);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2And3LastNextIsNull()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.Last.Next == null);

        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding2And3NextValueIs3()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.First.Next.Value == 3);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding235FirstValueIs2()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(3);

            Assert.IsTrue(list.First.Value == 2);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding235SecondValueIs3()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(3);

            Assert.IsTrue(list.First.Next.Value == 3);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding235ThirdValueIs5()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);

            Assert.IsTrue(list.First.Next.Next.Value == 5);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding235LastValueIs5()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);

            Assert.IsTrue(list.Last.Value == 5);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding235LastPreviousValueIs3()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);

            Assert.IsTrue(list.Last.Previous.Value == 3);
        }

        [TestMethod]
        public void Should_ReturnTrue_When_Adding235LastPreviousPreviousValueIs2()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);

            Assert.IsTrue(list.Last.Previous.Previous.Value == 2);
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
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);
            list.AddLast(13);
            list.AddLast(21);
            list.AddLast(34);
            list.AddLast(55);

            int[] expected = { 2, 3, 5, 8, 13, 21, 34, 55 };
            var node = list.First;
            for(int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(expected[i], node.Value);
                node = node.Next;
            }

        }

        [TestMethod]
        public void Should_ReturnTrue_When_AddingSeveralNumbersTraversingListForwardWithWhileLoop()
        {
            ILinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);
            list.AddLast(13);
            list.AddLast(21);
            list.AddLast(34);
            list.AddLast(55);

            int[] expected = { 2, 3, 5, 8, 13, 21, 34, 55 };
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
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);
            list.AddLast(13);
            list.AddLast(21);
            list.AddLast(34);
            list.AddLast(55);

            int[] expected = { 2, 3, 5, 8, 13, 21, 34, 55 };
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
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(8);
            list.AddLast(13);
            list.AddLast(21);
            list.AddLast(34);
            list.AddLast(55);

            int[] expected = { 2, 3, 5, 8, 13, 21, 34, 55 };
            var node = list.First;
            for (int i = 7; i <= 0; i--)
            {
                Assert.AreEqual(expected[i], node.Value);
                node = node.Next;
            }

        }

    }
}
