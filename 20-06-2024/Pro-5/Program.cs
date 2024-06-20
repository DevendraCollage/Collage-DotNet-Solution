using System;

/*
 * Author : Devendra Parmar
 * Question : Write program showing use of common methods of String class.
 */

namespace Pro_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to showing use of common method of the String class
            string name = "Devendra";
            string uni = "Darshan University";
            string demo = "";

            // 1. Compare
            Console.WriteLine(String.Compare(name, uni) == 0);

            //2. Concat
            Console.WriteLine(String.Concat(name," ",uni));

            // 3. IsNullOrEmpty
            Console.WriteLine(String.IsNullOrEmpty(name));
            Console.WriteLine(String.IsNullOrEmpty(uni));
            Console.WriteLine(String.IsNullOrEmpty(demo));

            // 4. Join
            Console.WriteLine(String.Join(demo, uni));

            // 5. Format
            Console.WriteLine(String.Format(name));

            // 6. ToLower
            Console.WriteLine(name.ToLower());

            // 7. Replace
            Console.WriteLine(uni.Replace("Darshan","Marwadi"));

            // 8. StartsWith
            Console.WriteLine(name.StartsWith('D'));

            // 9. EndsWith
            Console.WriteLine(name.EndsWith('r'));

            // 10. SubString
            Console.WriteLine(name.Substring(1, 5));
        }
    }
}