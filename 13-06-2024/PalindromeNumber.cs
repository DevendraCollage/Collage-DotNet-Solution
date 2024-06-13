using System;

/*
 * Author: Devendra Parmar
 * Question: Write a program to check the number is palindrome or not.
 */

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number from the user
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Reverse the number
            int reverse = 0;
            int temp = num;
            while (num != 0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }

            // Check the number is palindrome or not
            Console.WriteLine(reverse);
            if(temp == reverse)
            {
                Console.WriteLine("The number is palindrome!");
            }
            else
            {
                Console.WriteLine("The number is not palindrome!");
            }
        }
    }
}
