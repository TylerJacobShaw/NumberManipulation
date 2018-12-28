using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation.Web.Util
{
    public class DoubleOperations
    {
        public static double Add()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            return d;
        }

        public static double AddLargerDouble()
        {
            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            return d;
        }

        public static string MinMaxDouble()
        {
            double max = double.MaxValue;
            double min = double.MinValue;
            return $"The range of double is {min} to {max}";
        }
        public static double DoubleRoundError()
        {
            double third = 1.0 / 3.0;
            return third;
        }

    }
}
