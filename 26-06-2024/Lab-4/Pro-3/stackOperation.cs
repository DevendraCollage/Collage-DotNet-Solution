using System;
using System.Collections;

namespace Pro_3
{
    internal class stackOperation
    {
        Stack<int> stack = new Stack<int>();

        // Method to add the element to the stack
        public void addElem(int n)
        {
            stack.Push(n);
        }

        // Method to pop the element from the stack
        public int popElem()
        {
            return stack.Pop();
        }

        // Method to peep the element of the stack
        public int peepElem()
        {
            return stack.Peek();
        }

        // Method to check the element is contains or not
        public bool containElem(int n)
        {
            return stack.Contains(n);
        }

        // Method to clear the stack
        public void clearStack()
        {
            stack.Clear();
        }

        // Method to display the elements of the stack
        public void displayStack()
        {
            foreach (var item in stack)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}
