using System;

namespace Pro_2
{
    internal class Staff
    {
        // Data members of the Staff class
        public string Name;
        public string Department;
        public string Designation;
        public int Experience;
        public double Salary;

        // Function to GetStaffDetails()
        public void GetStaffDetails(string name, string dept, string desg, int exp, double sal)
        {
            this.Name = name;
            this.Department = dept;
            this.Designation = desg;
            this.Experience = exp;
            this.Salary = sal;
        }
    }
}
