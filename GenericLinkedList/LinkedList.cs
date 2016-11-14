using System;

namespace SoftwareDeveloperIO.Collections.Generic
{
    public class LinkedList<T>: ILinkedList<T>
    {

        private LinkedListNode<T> first;
        private LinkedListNode<T> last;
        private int size;

        public LinkedList()
        {
            first = null;
            last = null;
            size = 0;
        }

        public int Count
        {
            get { return size; }
        }

        public LinkedListNode<T> First
        {
            get { return first; }
        }

        public bool IsEmpty
        {
            get { return first == null ? true : false; }
        }

        public LinkedListNode<T> Last
        {
            get { return last; }
        }

        public void AddFirst(T value)
        {
            // Create new node
            var node = new LinkedListNode<T>() { Value = value };

            if (IsEmpty)
            {
                // If list is empty
                last = node;
            }
            else
            {
                first.Previous = node;
                node.Next = first;
            }

            first = node;

            size++;
        }

        public void AddLast(T value)
        {
            var node = new LinkedListNode<T>() { Value = value };

            if (IsEmpty)
            {
                first = node;
            }
            else
            {
                node.Previous = last;
                last.Next = node;
            }

            last = node;
            size++;
        }

        public void Clear()
        {
            // Refator: Don't be lazy and leave this to the GC
            // Release reference to node elements
            first = null;
            last = null;
            size = 0;
        }

        public bool Contains(T value)
        {
            var node = first;
            while (node != null)
            {
                if (node.Value.Equals(value)) { return true; }
                node = node.Next;
            }
            return false;
        }

        public LinkedListNode<T> Find(T value)
        {
            var node = first;
            while (node != null)
            {
                if (node.Value.Equals(value)) { return node; }
                node = node.Next;
            }
            return null;
        }

        public bool Remove(T value)
        {
            var previousNode = new LinkedListNode<T>();
            var currentNode = first;

            while (currentNode != null)
            {
                // Current node matches value
                if (currentNode.Value.Equals(value))
                {
                    // First node
                    if (currentNode.Previous == null)
                    {
                        // If there are more than 1 nodes
                        if (currentNode.Next != null)
                        {
                            currentNode.Next.Previous = null;
                            first = currentNode.Next;
                        }
                        
                    }
                    // Last node
                    else if (currentNode.Next == null)
                    {
                        currentNode.Previous.Next = null;
                        last = currentNode.Previous;
                    }
                    // Middle nodes
                    else
                    {
                        previousNode.Next = currentNode.Next;
                        currentNode.Next.Previous = previousNode;
                    }
                    size--;
                    return true;
                }
                else
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }
            return false;
        }

    }
}
