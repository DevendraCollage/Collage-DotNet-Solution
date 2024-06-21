using System;

namespace Pro_5
{
    public class AreaofRectangle
    {
        // Data members of the class
        public double Length;
        public double Width;
        public double Area;

        // Getter method to get the height and width from the user
        public AreaofRectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
            this.Area = Length * width;
        }

        // Calculate the area of Rectngle
        public void AreaOfRectangle()
        {
            Console.Write("The Area of {0} and {1} Is : {2}", this.Length, this.Width, this.Area);
        }
    }
}
