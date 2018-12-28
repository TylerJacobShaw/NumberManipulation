using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation.Web.Util
{
   public class DecimalOperations
    {
        public static string MinMaxDecimal()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            return $"The range of the decimal type is {min} to {max}";
        }
        public static string DecimalVsDouble()
        {
            double a = 1.0;
            double b = 3.0;

            decimal c = 1.0M;
            decimal d = 3.0M;
            return  $"Double:  { a / b} Decimal: {c / d}";
        }

        public static string CalculateCircle()
        {
            double radius = 2.50;
            double area = Math.PI * (radius * radius);
            return $"{area} cm";
        }

    }
}
