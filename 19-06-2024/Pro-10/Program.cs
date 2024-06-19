using System;

/*
 * Author : Devendra Parmar
 * Question : Program to implement the following multiple inheritance using interface.
 * Interface : Gross -- Method : Gross_sal()
 * Class : Salary -- Data Members : HRA,TA,DA -- Methods - Disp_sal() -- Class : Employee
 * Data Members : Name -- Methods : basic_sal()
 */

namespace Pro_10
{
    // Interface Gross
    interface Gross
    {
        // Method of this Salary
        public void Gross_Sal();
    }

    // Class Salary
    public class Salary
    {
        // Data members of this class
        public double HRA; // House rent allowance
        public double TA; // Travel allowance
        public double DA; // Dearness allowance

        // Display this data
        public void Disp_sal()
        {
            Console.WriteLine();
            Console.WriteLine("HRA : {0}", HRA);
            Console.WriteLine("TA : {0}", TA);
            Console.WriteLine("DA : {0}", DA);
            Console.WriteLine();
        }
    }

    // Class Employee
    public class Employee : Salary, Gross
    {
        // Data members of this class
        public string Name;

        // Methods of this class
        public double basic_sal()
        {
            double basicSal;
            Console.Write("Enter basic salary : ");
            basicSal = Convert.ToDouble(Console.ReadLine());
            return basicSal;
        }

        public void Gross_Sal()
        {
            double basicSalary = basic_sal();
            double grossSalary = basicSalary - (HRA + TA + DA);
            Console.WriteLine("Gross Salary is : {0}", grossSalary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the Employee class
            Employee emp = new Employee();

            // Read the data from the user
            Console.Write("Enter your name : ");
            emp.Name = Console.ReadLine()!;

            Console.Write("Enter HRA : ");
            emp.HRA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter TA : ");
            emp.TA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter DA : ");
            emp.DA = Convert.ToDouble(Console.ReadLine());

            emp.Disp_sal();
            emp.Gross_Sal();
        }
    }
}
