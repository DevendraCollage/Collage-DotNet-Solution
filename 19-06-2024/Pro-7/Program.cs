using System;

/*
 * Author : Devendra Parmar
 * Question : Write a program to Define a class Salary which will contain member variable Basic, 
 * TA, DA, HRA. Write a program using Constructor with default values for DA and HRA and calculate
 * the salary of employee.
 */

namespace Pro_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the values from the user
            Console.Write("Enter the Basic Salary : ");
            double bsal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Travelling allowance : ");
            double da = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Dearness allowance : ");
            double ta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the House rent allowance : ");
            double hra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Instance of the Salary class and pass the arguments
            Salary s = new Salary(bsal,da,ta,hra);

            // Print the Basic Salary
            Console.WriteLine(s.BasicSal());
        }
    }
}
