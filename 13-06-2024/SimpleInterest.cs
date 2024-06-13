using System;

/* 
 * Author: Devendra Parmar
 * Question: Write a program to print simple interest
 */

namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the Principal Amount, Rate of interest, and number of years
            Console.Write("Enter the principal amount here : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of interest here : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Number of years : ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Calculate Simple Interest
            double SI = (p * r * n) / 100;

            // Print the Simple Interest
            Console.Write("The Simple Interest Is : {0}",SI);
        }
    }
}
