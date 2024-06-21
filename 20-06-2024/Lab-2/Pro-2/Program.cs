using System;

/*
 * Author : Devendra Parmar
 * Question : Write a program that reads 5 numbers from user. Demonstrate concept of IndexOutOfRange Exception.
 */

namespace Pro_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 5 numbers from the user and demonstrate the indexOutOfRange exception
            Console.WriteLine("-- Enter the numbers below --");
            int[] arr = new int[5];

            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.Write("Enter number {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                } 
            }
            catch (IndexOutOfRangeException ir)
            {
                Console.WriteLine(ir.Message);
            }
        }
    }
}
