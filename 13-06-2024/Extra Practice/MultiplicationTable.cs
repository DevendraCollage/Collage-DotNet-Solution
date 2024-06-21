using System;

/*
 * Author: Devendra Parmar
 * Questions: Write a program to print the multiplication table given by the user.
 */

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number from the user
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Print the multiplication table
            Console.WriteLine("Multiplication table of : {0}", num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, (num * i));
            }
        }
    }
}
