namespace SoftwareDeveloperIO.Collections.Generic
{
    public class LinkedListNode<T> : ILinkedListNode<T>
    {
        public LinkedList<T> List { get; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public T Value { get; set; }
    }
}
