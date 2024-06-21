using System;

/*
 * Author : Devendra Parmar
 * Question : Write a program to find the longest word in a string.
 */

namespace Pro_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the user
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine();

            string[] strArr = str.Split(" ");

            // Find longest word in string
            string max = "";
            foreach (string item in strArr)
            {
                if (item.Length > max.Length)
                {
                    max = item;
                }
            }

            // Print the longest word
            Console.WriteLine("The largest word in the given string is : {0}",max);
        }
    }
}
