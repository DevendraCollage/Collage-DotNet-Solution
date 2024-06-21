using System;
using Pro_6;

namespace Pro_6
{
    public class Account_Detail
    {
        // Data member of the class
        public double p;
        public double r;
        public int n;

        // Constructor to get the Account information from the user
        public Account_Detail(double p, double r, int n)
        {
            this.p = p;
            this.r = r;
            this.n = n;
        }
    }
}

