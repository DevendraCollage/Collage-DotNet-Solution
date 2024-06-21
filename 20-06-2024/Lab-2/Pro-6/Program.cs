using System;

/*
 * Author : Devendra Parmar
 * Questions : Write a program to Replace lower case characters to upper case and Vice-versa.
 */

namespace Pro_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "devendra";
            string Name = "DEVENDRA";

            // Replace lowercase characters with uppercase characters
            Console.WriteLine(name.Replace("devendra", "DEVENDRA"));

            // Replace uppercase characters with lowercase characters
            Console.WriteLine(Name.Replace("DEVENDRA", "devendra"));
        }
    }
}
