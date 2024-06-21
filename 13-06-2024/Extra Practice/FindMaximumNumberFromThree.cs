using System;

/*
 * Author: Devendra Parmar
 * Question: Write a program to print maximum number from the three given numbers.
 */

namespace FindMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the three numbers from the user
            Console.Write("Enter the number-1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number-2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number-3 : ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            // Find maximum numbers
            if (n1>n2 && n1>n3)
            {
                Console.WriteLine("The Max is : {0}", n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("The Max is : {0}", n2);
            }
            else
            {
                Console.WriteLine("The Max is : {0}", n3);
            }
        }
    }
}
