using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int type represents an integer, a positive or negative whole number.
            Util.IntegerOperations.Add();
            Util.IntegerOperations.Subtract();
            Util.IntegerOperations.Multiplication();
            Util.IntegerOperations.Division();
            Util.IntegerOperations.AddFirst();
            Util.IntegerOperations.MultiplyFirst();
            Util.IntegerOperations.ComplexEquation();
            Util.IntegerOperations.Modulo();
            Util.IntegerOperations.MinMaxIntValues();
            Util.IntegerOperations.OverflowInt();
            Util.DoubleOperations.Add();
            Util.DoubleOperations.AddLargerDouble();
            Util.DoubleOperations.MinMaxDouble();
            Util.DoubleOperations.DoubleRoundError();
            Util.DecimalOperations.MinMaxDecimal();
            Util.DecimalOperations.DecimalVsDouble();
            Util.DecimalOperations.CalculateCircle();
            Console.ReadLine();
        }
    }
}
