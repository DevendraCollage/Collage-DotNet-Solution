using System;
using System.Collections; // This is required to import for using collection classes

namespace Pro_2
{
    internal class listOperation
    {
        List<string> l1 = new List<string>();

        // Method to add the name to the list
        public void addElem(string name)
        {
            l1.Add(name);
        }

        // Method to remove the element from the list
        public void removeElme(int index)
        {
            l1.RemoveAt(index);
        }

        // Method to remove element in a range
        public void removeElemRange(int start, int end)
        {
            l1.RemoveRange(start, end);
        }

        // Method to clear the list
        public void clearList()
        {
            l1.Clear();
        }

        // Method to display the element of the list
        public void diplsayElem()
        {
            foreach (var item in l1)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}
