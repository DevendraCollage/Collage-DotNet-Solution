using System.Collections; // This required for using collection classes
using Pro_1;

/*
 * Author : Devendra Parmar
 * Question : Create an ArrayList for StudentName and perform following operations:
 * a. Add() - To Add new student in list
 * b. Remove() - To Remove Student with specified index
 * c. RemoveRange() - To Remove student with specified range.
 * d. Clear() - To clear all the student from the list
 */

namespace Pro_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the arrayListOperation class
            arrayListOperation a1 = new arrayListOperation();

            string userName;
            int choice;

            while (true)
            {
                Console.Write("\n1. Add\n2. Remove\n3. Remove from the Range\n4. Clear\n5. Display\n6. Exit\n");
                Console.Write("\nEnter the choice from the above : ");
                choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Enter the name you want to add : ");
                        userName = Console.ReadLine()!;
                        a1.addElem(userName);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Enter the index you want to remove name : ");
                        int userChoice = int.Parse(Console.ReadLine()!);
                        a1.removeElem(userChoice);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Enter the start range : ");
                        int start = int.Parse(Console.ReadLine()!);
                        Console.Write("Enter the end range : ");
                        int end = int.Parse(Console.ReadLine()!);
                        a1.removeRangeElem(start, end);
                        break;
                    case 4:
                        a1.clearElem();
                        break;
                    case 5:
                        Console.WriteLine();
                        a1.displaElem();
                        Console.WriteLine();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}
