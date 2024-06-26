using System.Collections; // This is required to import to use collection classes
using Pro_3;

/*
 * Author : Devendra Parmar
 * Question : Create a Stack which takes integer values and perform following operations:
 * a. Push() - To Add new item in stack
 * b. Pop() - To Remove item from the stack
 * c. Peek() – To Return the top item from the stack.
 * d. Contains() - To Checks whether an item exists in the stack or not.
 * e. Clear() - To clear items from stack
 */

namespace Pro_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the stackOperation class
            stackOperation s1 = new stackOperation();

            int userValue;

            while (true)
            {
                // Read choice from the user            
                Console.WriteLine("\n1. Push\n2. Pop\n3. Peep\n4. Contains\n5. Clear\n6. Display\n7. Exit\n");
                Console.Write("Enter your choice from the above : ");
                int choice = int.Parse(Console.ReadLine()!);

                switch(choice)
                {
                    case 1:
                        Console.Write("\nEnter the number you want to PUSH : ");
                        userValue = int.Parse(Console.ReadLine()!);
                        s1.addElem(userValue);
                        break;
                    case 2:
                        s1.popElem();
                        break;
                    case 3:
                        s1.peepElem();
                        break;
                    case 4:
                        Console.Write("Enter the element to search : ");
                        userValue = int.Parse(Console.ReadLine()!);
                        s1.containElem(userValue);
                        break;
                    case 5:
                        s1.clearStack();
                        break;
                    case 6:
                        Console.WriteLine();
                        s1.displayStack();
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}
