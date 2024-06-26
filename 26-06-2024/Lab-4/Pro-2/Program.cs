using System;
using System.Collections; // This is required to import for using collection classes
using Pro_2;

/*
 * Author : Devendra Parmar
 * Question : Create a List for StudentName and perform following operations:
 * a. Add() - To Add new student in list
 * b. Remove() - To Remove Student with specified index
 * c. RemoveRange() - To Remove student with specified range.
 * d. Clear() - To clear all the student from the list
 */

namespace Pro_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the listOperation Class
            listOperation lio = new listOperation();

            int choice;
            string name;

            while (true)
            {
                Console.Write("\n1. Add\n2. Remove\n3. Remove an from Range\n4. Clear\n5. Display\n6. Exit\n");
                Console.Write("\nEnter the choice from the above : ");
                choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Enter the name you want to add : ");
                        name = Console.ReadLine()!;
                        lio.addElem(name);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Enter the index you want to remove : ");
                        int userChoice = int.Parse(Console.ReadLine()!);
                        lio.removeElme(userChoice);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Enter the start range : ");
                        int start = int.Parse(Console.ReadLine()!);
                        Console.Write("Enter the end range : ");
                        int end = int.Parse(Console.ReadLine()!);
                        lio.removeElemRange(start, end);
                        break;
                    case 4:
                        lio.clearList();
                        break;
                    case 5:
                        Console.WriteLine();
                        lio.diplsayElem();
                        Console.WriteLine();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}
