using System;

/*
 * Author : Devendra Parmar
 * Question : Create a class Furniture with material ,price as data members. Create another class 
 * Table with Height , surface_area as data members. Write a program to implement single inheritance.
 */

namespace Pro_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the class
            Table t = new Table();
            Furniture f = new Furniture();

            // Read the data from the user
            Console.WriteLine("-- Enter the Furniture Details --");
            Console.Write("Enter the material : ");
            t.Material = Console.ReadLine();
            Console.Write("Enter the price : ");
            t.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height : ");
            t.Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Surface Area : ");
            t.Surface_area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Call the method and pass the arguments
            f.Set(t.Material, t.Price);
            f.Get();
            t.Set(t.Height, t.Surface_area);
            t.Get();
        }
    }
}
