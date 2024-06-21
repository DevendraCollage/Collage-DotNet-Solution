using System;

/*
 * Author: Devendra Parmar
 * Question: Write a program to swap to numbers.
 */

namespace SwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the two numbers from the user
            Console.Write("Enter the number 1 here : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number 2 here : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Swap numbers without using third variable
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            // Print the numbers after swapping
            Console.Write("The number after swapping n1 : {0}", n1);
            Console.WriteLine();
            Console.Write("The number after swapping n2 : {0}", n2);
        }
    }
}
