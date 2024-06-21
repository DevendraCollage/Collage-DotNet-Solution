using System;
using Pro_4;

/*
 * Author : Devendra Parmar
 * Question : Write a program to create interface Calculate. In this interface we have two member
 * functions Addition() and Subtraction(). Implements this interface in another class named Result.
 */

namespace Pro_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the two numbers from the user
            Console.Write("Enter the number-1 : ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number-2 : ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            // Instance of the class Add
            Add a1 = new Add();

            // Call the method and pass the arguments
            Console.WriteLine(a1.Addition(n1, n2));
            Console.WriteLine(a1.Subtraction(n1, n2));
        }
    }
}
