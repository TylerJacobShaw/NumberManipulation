using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation.Web.Util
{
   public class DecimalOperations
    {
        public static void MinMaxDecimal()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
        }
        public static void DecimalVsDouble()
        {
            double a = 1.0;
            double b = 3.0;

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine($"Double:  { a / b} Decimal: {c / d}");
        }

        public static void CalculateCircle()
        {
            double radius = 2.50;
            double area = Math.PI * (radius * radius);
            Console.WriteLine($"{area} cm");
        }

    }
}
