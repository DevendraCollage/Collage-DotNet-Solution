using System;

/*
 * Author: Devendra Parmar
 * Question: Write a program to print max number from an array.
 */

namespace FindMaxNumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initialize the array and set the size
            int[] arr = new int[size];

            // Read the elements from the user
            Console.WriteLine("Enter the elements of array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Find the max element
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }

            // Print the max element of the array
            Console.WriteLine(max);
        }
    }
}
