using System;
using Pro_6;

namespace Pro_6
{
    public class Interest : Account_Detail
    {
        // Constructor to get account information
        public Interest(double p, double r, int n) : base(p,r,n) { }

        // Calculate the interest and return value
        public double CalculateInterest()
        {
            return (p * r * n) /100;
        }
    }
}
