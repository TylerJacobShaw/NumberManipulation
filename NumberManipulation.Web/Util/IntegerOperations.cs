using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation.Web.Util
{
    public class IntegerOperations
    {
        public static void Add()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
        }
        public static void Subtract()
        {
            int a = 18;
            int b = 6;
            int c = a - b;
            Console.WriteLine(c);
        }
        public static void Multiplication()
        {
            int a = 18;
            int b = 6;
            int c = a * b;
            Console.WriteLine(c);
        }
        public static void Division()
        {
            int a = 18;
            int b = 6;
            int c = a / b;
            Console.WriteLine(c);
        }
        public static void AddFirst()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) * c;
            Console.WriteLine(d);
        }
        public static void MultiplyFirst()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);
        }
        public static void ComplexEquation()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            //C# coverts the equation below into this, 9 - 12 + 48 / 3 + 12
            //the first things to get equated are (12 * 4) then 6 * c
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
        }


        public static void Modulo()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d} remainder: {e}");

        }

        public static void MinMaxIntValues()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
        }

        public static void OverflowInt()
        {
            int max = int.MaxValue;
            int what = max + 5;
            Console.WriteLine($"An example of overflow: {what}");
        }

        

    }
}
