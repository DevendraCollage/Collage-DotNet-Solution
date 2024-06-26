using System;
using Pro_4;

namespace Pro_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the class 
            queueOperation qu = new queueOperation();
            
            int userNum; // Variable to store the users number

            while (true)
            {
                Console.Write("\n1. Enqueue\n2. Dequeue\n3. Peek\n4. Contains\n5. Clear\n6. Display\n7. Exit\n");
                Console.Write("\nEnter the choice from the above : ");
                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter the number to Enqueue : ");
                        userNum = int.Parse(Console.ReadLine()!);
                        qu.enqueElem(userNum);
                        break;
                    case 2:
                        qu.dequeueElem();
                        break;
                    case 3:
                        Console.WriteLine();
                        qu.peekElem();
                        break;
                    case 4:
                        Console.Write("\nEnter number to check contains or not : ");
                        userNum = int.Parse(Console.ReadLine()!);
                        Console.WriteLine();
                        qu.containsElem(userNum);
                        break;
                    case 5:
                        qu.clearElem();
                        break;
                    case 6:
                        Console.WriteLine();
                        qu.displayElem();
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}
