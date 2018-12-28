using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation.Web.Util
{
    public class IntegerOperations
    {
        public static int Add()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            return c;
        }
        public static int Subtract()
        {
            int a = 18;
            int b = 6;
            int c = a - b; return c;
        }
        public static int Multiplication()
        {
            int a = 18;
            int b = 6;
            int c = a * b;
            return c;
        }
        public static int Division()
        {
            int a = 18;
            int b = 6;
            int c = a / b;
            return c;
        }
        public static int AddFirst()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) * c;
            return d;
        }
        public static int MultiplyFirst()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            return d;
        }
        public static int ComplexEquation()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            //C# coverts the equation below into this, 9 - 12 + 48 / 3 + 12
            //the first things to get equated are (12 * 4) then 6 * c
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            return d;
        }


        public static string Modulo()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            return $"quotient: {d} remainder: {e}";

        }

        public static string MinMaxIntValues()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            return $"The range of integers is {min} to {max}";
        }

        public static string OverflowInt()
        {
            int max = int.MaxValue;
            int what = max + 5;
            return $"An example of overflow: {what}";
        }

        

    }
}
