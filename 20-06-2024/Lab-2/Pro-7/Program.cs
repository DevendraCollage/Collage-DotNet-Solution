using System;
using Pro_7;

/*
 * Author : Devendra Parmar
 * Question : Write a program to create interface named Shape. In this interface, we have three
 * methods Circle(), Triangle() and Square() which calculates area of Circle, Triangle and Square
 * respectively. Implement Shape interface.
 */

namespace Pro_7
{
    // Interface Shape
    interface Shape
    {
        // Circle method
        public double Circle(double r);

        // Triange method
        public double Triangle(double b, double len);

        // Square method
        public double Square(double side);
    }
    internal class Program : Shape
    {
        // Implement all the method of the interface here
        // 1. Circle
        public double Circle(double r)
        {
            double PI = 3.1416;
            return PI * r * r;
        }

        // 2. Triangle
        public double Triangle(double b, double len)
        {
            return (b * len) * 0.5;
        }

        // 3. Square
        public double Square(double side)
        {
            return side * side;
        }


        static void Main(string[] args)
        {
            // Instance of the class
            Program p = new Program();

            // 1. Circle method call and argument passing
            double circleArea = p.Circle(5);
            Console.WriteLine("The Area of Circle is : {0}", circleArea);

            // 2. Triangle method call and argument passing
            double triArea = p.Triangle(2, 5);
            Console.WriteLine("The Area of Triangle is : {0}", triArea);

            // 3. Square method call and argument passing
            double squareArea = p.Square(4);
            Console.WriteLine("The Area of Square is : {0}", squareArea);
        }
    }
}
