using System;

namespace Pro_4
{
    internal class Student
    {
        // Data Member of the class
        public int Enrollment_No;
        public string Student_Name;
        public int Semester;
        public double CPI;
        public double SPI;

        // Constructor to get the details of the user
        public Student(int eno, string sname, int sem, double cpi, double spi)
        {
            this.Enrollment_No = eno;
            this.Student_Name = sname;
            this.Semester = sem;
            this.CPI = cpi;
            this.SPI = spi;
        }

        // Display the student details using the DisplayStudentDetails() function
        public void DisplayStudentDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Your Enrollment_No Is : {0}", Enrollment_No);
            Console.WriteLine("Your Name Is : {0}", Student_Name);
            Console.WriteLine("Your Semester Is : {0}", Semester);
            Console.WriteLine("Your CPI Is : {0}", CPI);
            Console.WriteLine("Your SPI Is : {0}", SPI);
        }
    }
}
