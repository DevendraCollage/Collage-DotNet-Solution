using System;
using Pro_2;

/*
 * Author : Devendra Parmar
 * Question : Write a program to create a class Staff having data members as Name, Department,
 * Designation, Experience & Salary. Accept this data for 5 different staffs and display only
 * names & salary of those staff who are HOD.
 */

namespace Pro_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the array of objects
            Staff[] st = new Staff[5];

            // Call the function to get the 5 different staff details
            Console.WriteLine("-- Enter the Details of the Staff Members --");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the detail of the user : {0}", i);
                Console.Write("Enter your name : ");
                string name = Console.ReadLine();
                Console.Write("Enter your department : ");
                string dept = Console.ReadLine();
                Console.Write("Enter your designation : ");
                string desg = Console.ReadLine();
                Console.Write("Enter your experience : ");
                int exp = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());

                // Create the instance of the Staff class
                Staff stf = new Staff();

                // Call the method getter and pass the arguments
                stf.GetStaffDetails(name,dept,desg,exp,sal);

                // Add the instance to the array
                st[i-1] = stf;
            }

            // Print the name & salary of the Staff who is HOD
            foreach(Staff s in st)
            {
                if(s.Designation.ToLower() == "hod")
                {
                    Console.WriteLine("Name: {0}, Salary: {1}", s.Name, s.Salary);
                }
            }
        }
    }
}
