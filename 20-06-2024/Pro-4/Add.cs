using System;

namespace Pro_4
{
    interface Calculate
    {
        // First method of the interface without body
        public double Addition(double a, double b);

        // Second method of the interface without body
        public double Subtraction(double a, double b);
    }
    internal class Add : Calculate
    {
        // Implement the first method
        public double Addition(double a, double b)
        {
            return a + b;
        }

        // Implement the second method
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
    }
}
