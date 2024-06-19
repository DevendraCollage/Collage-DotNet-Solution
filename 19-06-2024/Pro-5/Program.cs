using System;
using Pro_5;

/*
 * Author : Devendra Parmar
 * Question : Write a program to calculate area of a Rectangle using constructor.
 */

namespace Pro_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the height and width from the user
            Console.Write("Enter the length : ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width : ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Create the instance of the Rectangle class
            AreaofRectangle ar = new AreaofRectangle(length, width);

            // Call the method and print the result
            ar.AreaOfRectangle();
        }
    }
}
