using System;
using System.Collections; // This is required to import to use the collection class

namespace Pro_1
{
    internal class arrayListOperation
    {
        ArrayList l1 = new ArrayList();

        // Method to add the element to the arrayList
        public void addElem(string name)
        {
            l1.Add(name);
        }

        // Method to remove the element from the arrayList
        public void removeElem(int index)
        {
            l1.RemoveAt(index);
        }

        // Method to remove the range element from the arrayList
        public void removeRangeElem(int start, int end)
        {
            l1.RemoveRange(start, end);
        }

        // Method to clear the list
        public void clearElem()
        {
            l1.Clear();
        }

        // Method to display all the elements
        public void displaElem()
        {
            foreach (var item in l1)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}
