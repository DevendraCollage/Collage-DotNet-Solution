using System;
using Pro_1;

/*
 * Author : Devendra Parmar
 * Question : Write a program to create a class named Candidate with ID, Name, Age, Weight and Height
 * as data members & also create a member functions like GetCandidateDetails() and 
 * DisplayCandidateDetails().
 */

namespace Pro_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the Candidate class
            Candidate candidate = new Candidate();

            // Read all the data from the user
            Console.WriteLine("-- Enter your details here --");
            Console.Write("Enter your ID : ");
            candidate.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Name : ");
            candidate.Name = Console.ReadLine();
            Console.Write("Enter your Age : ");
            candidate.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Weight : ");
            candidate.Weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Height : ");
            candidate.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Call the first function and pass the arguments to the function
            candidate.GetCandidateDetails(candidate.ID,candidate.Name,candidate.Age,candidate.Weight,candidate.Height);

            // Call the second function and display the details
            Console.WriteLine("-- User Details --");
            candidate.DisplayCandidateDetails();
        }
    }
}
