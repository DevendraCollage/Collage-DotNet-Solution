using System;

/*
 * Author : Devendra Parmar
 * Question : Write a program to accept a number from the user and throw an exception if the
 * number is not an even number.
 */

namespace Pro_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number from the user
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // throw Exception if the given number is not even number
            try
            {
                if (num % 2 != 0)
                {
                    throw new Exception("Not an even number!");
                }
                else
                {
                    Console.WriteLine("It is an even number!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
