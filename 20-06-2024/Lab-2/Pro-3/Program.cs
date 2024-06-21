using System;
using Pro_3;

/*
 * Author : Devendra Parmar
 * Question : Write a program to create an abstract class Sum having abstract methods 
 * SumOfTwo(int a, int b) and SumOfThree(int a, int b,int c). Create another class Calculate
 * which extends the abstract class and implements the abstract methods.
 */

namespace Pro_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the three number from the user
            Console.WriteLine("-- Enter number here --");
            Console.Write("Enter the number-1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number-2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number-3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            

            // Instance of the child class Calculate
            Calculate c = new Calculate();

            // Pass the value to the function
            Console.WriteLine(c.SumOfTwo(num1, num2));
            Console.WriteLine(c.SumOfThree(num1, num2, num3));
        }
    }
}
