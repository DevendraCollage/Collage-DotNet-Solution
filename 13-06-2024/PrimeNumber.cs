using System;

/*
 * Author: Devendra Parmar
 * Question: Write a program to print the number is prime or not.
 */

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number from the user
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // This is a temporary flag variable
            bool flag = true;

            // Find the prime number
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }

            // Print the number is prime or not
            if (flag)
            {
                Console.WriteLine("The number is prime!");
            }
            else
            {
                Console.WriteLine("The number is not prime!");
            }
        }
    }
}
