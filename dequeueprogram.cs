//using StackAndQueue.QueueUsingLinkedList;
using StackAndQueue.StackUsingLinkedList;
using System;
using System.Collections;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region QueueUsingLinkedList

            Queue linkedListQueue = new Queue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            //linkedListQueue.Display();
            Console.WriteLine("Number of elements in the Queue: {0}", linkedListQueue.Count);
            Console.WriteLine("Top element of queue is:");
            Console.WriteLine(linkedListQueue.Dequeue());

            Console.WriteLine("Number of elements in the Queue: {0}", linkedListQueue.Count);
            #endregion

        }
    }
}
