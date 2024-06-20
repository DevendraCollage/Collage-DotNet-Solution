using System;

/*
 * Author : Devendra Parmar
 * Question : Write a program to change the case of entered character.
 */

namespace Pro_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the user
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine();

            // If String in the uppercase change to the lowercase
            if (char.IsUpper(str,0))
            {
                Console.WriteLine(str.ToLower());
            }
            else
            {
                Console.WriteLine(str.ToUpper());
            }
        }
    }
}
