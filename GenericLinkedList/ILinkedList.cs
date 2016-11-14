namespace SoftwareDeveloperIO.Collections.Generic
{
    public interface ILinkedList<T>
    {
        int Count { get; }
        LinkedListNode<T> First { get; }
        bool IsEmpty { get; }
        LinkedListNode<T> Last { get; }

        void AddFirst(T value);
        void AddLast(T value);
        void Clear();
        bool Contains(T value);
        LinkedListNode<T> Find(T value);
        bool Remove(T value);
        
    }
}
