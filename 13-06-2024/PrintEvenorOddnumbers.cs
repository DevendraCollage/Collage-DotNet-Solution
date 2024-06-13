using System;

/* 
 * Author: Devendra Parmar
 * Question: Write a program to print odd or even numbers from the array
 */

namespace PrintEvenOrOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initialize the array with size
            int[] arr = new int[size];

            // Read the elements of the array from the user
            Console.WriteLine("Enter the array elements here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            // Find the even or odd numbers
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    Console.WriteLine("The {0} is Even number!", arr[i]);
                }
                else
                {
                    Console.WriteLine("The {0} is Odd number!", arr[i]);
                }
            }
        }
    }
}
