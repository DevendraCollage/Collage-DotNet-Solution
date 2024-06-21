using System;
using Pro_8;

/*
 * Author : Devendra Parmar
 * Question : Write a program to Define a class Distance have data members dist1, dist2, dist3.
 * Initialize the two data members using constructor and store their addition in third data member 
 * using function and display addition.
 */

namespace Pro_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the two distance from the user
            Console.WriteLine("-- Enter the details below --");
            Console.Write("Enter the distance-1 here : ");
            double dist1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance-2 here : ");
            double dist2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Instance of the Distance class
            Distance d = new Distance(dist1,dist2);

            // Call the display method to print the result
            d.Disp();
        }
    }
}
