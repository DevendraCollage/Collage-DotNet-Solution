using System;
using System.Collections; // This is required to import for using collection classes

namespace Pro_4
{
    internal class queueOperation
    {
        Queue q1 = new Queue();

        // Method to enqueue element
        public void enqueElem(int n)
        {
            q1.Enqueue(n);
        }

        // Method to dequeue element
        public void dequeueElem()
        {
            Console.WriteLine("Dequeued Element is : {0}",q1.Dequeue());
        }

        // Method to peek the element
        public void peekElem()
        {
            Console.WriteLine("Peek : {0}", q1.Peek());
        }

        // Method to check the given element is Contains or not
        public void containsElem(int n)
        {
            Console.WriteLine(q1.Contains(n));
        }

        // Method clear all the element from the Queue
        public void clearElem()
        {
            q1.Clear();
        }

        // Method to display all the elements
        public void displayElem()
        {
            foreach (var item in q1)
            {
                Console.WriteLine("{0}, ", item);
            }
        }
    }
}