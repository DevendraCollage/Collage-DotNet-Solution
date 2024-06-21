using System;
using Pro_3;

namespace Pro_3
{
    internal class Calculate : Sum
    {
        // Implement the first abstract method
        public override int SumOfTwo(int a, int b)  
        {
            return a + b;
        }

        // Implement the second abtstract method
        public override int SumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
