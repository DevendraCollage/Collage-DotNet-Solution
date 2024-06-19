using System;
using Pro_4;

/*
 * Author : Devendra Parmar
 * Question : Write a program with following specifications:
 * Class Name: Student
 * Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
 * Get Students Details using constructor and DisplayStudentDetails() using member function.
 */

namespace Pro_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the Student Details from the user
            Console.WriteLine("-- Enter your details here --");
            Console.Write("Enter Enrollment_No here : ");
            int eno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name here : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Semester here : ");
            int sem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your CPI : ");
            double cpi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your SPI : ");
            double spi = Convert.ToDouble(Console.ReadLine());

            // Create the instance of the Student class
            Student st = new Student(eno, name, sem, cpi, spi);

            // Call the DisplayStudentDetails() function
            st.DisplayStudentDetails();
        }
    }
}
