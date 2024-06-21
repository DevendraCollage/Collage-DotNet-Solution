using System;

namespace Pro_1
{
    internal class Candidate
    {
        // Data Members to store the values
        public int ID;
        public string Name;
        public int Age;
        public double Weight;
        public double Height;

        // Member function to get the details
        public void GetCandidateDetails(int id, string name, int age, double weight, double height)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }

        // Member function to display the details
        public void DisplayCandidateDetails()
        {
            Console.WriteLine("Your ID is : {0}",ID);
            Console.WriteLine("Your Name is : {0}",Name);
            Console.WriteLine("Your Age is : {0}",Age);
            Console.WriteLine("Your Weight is : {0}", Weight);
            Console.WriteLine("Your Height is : {0}", Height);
        }
    }
}
