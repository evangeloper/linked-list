namespace SoftwareDeveloperIO.Collections.Generic
{
    public interface ILinkedListNode<T>
    {
        LinkedList<T> List { get; }
        LinkedListNode<T> Next { get; }
        LinkedListNode<T> Previous { get; }
        T Value { get; set; }
    }
}
