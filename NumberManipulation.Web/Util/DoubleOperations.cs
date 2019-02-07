using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation.Web.Util
{
    public class DoubleOperations
    {
        public static void Add()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
        }

        public static void AddLargerDouble()
        {
            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);
        }

        public static void MinMaxDouble()
        {
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
        }
        public static void DoubleRoundError()
        {
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

    }
}
