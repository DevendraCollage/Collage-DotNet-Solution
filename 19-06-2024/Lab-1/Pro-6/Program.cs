using System;
using Pro_6;

namespace Pro_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the Account Information from the user
            Console.WriteLine("-- Enter your account information --");
            Console.Write("Enter the principal amount : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rate of interest : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the period time : ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Instance of the Interest class and pass the arguments
            Interest interest = new Interest(p, r, n);

            // Calculate the interest and print the value
            double calculatedInterest = interest.CalculateInterest();
            Console.WriteLine($"The calculated interest is: {calculatedInterest}");
        }
    }
}
