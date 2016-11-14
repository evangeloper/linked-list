using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
