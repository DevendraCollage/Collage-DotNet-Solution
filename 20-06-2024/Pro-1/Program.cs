using System;

/*
 * Author : Devendra Parmar
 * Question : Write a program to Create a divide by zero exception and handle it.
 */

namespace Pro_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number from the user
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisible number : ");
            int div = Convert.ToInt32(Console.ReadLine());

            // If divisor number is zero then raise zero exception and handle it
            try
            {
                // Divide the number
                int sum = num / div;
                Console.Write(sum);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
        }
    }
}
