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
            int add = Util.IntegerOperations.Add();//return value is: 24
            int subtract = Util.IntegerOperations.Subtract();//return value is: 12
            int multiplication = Util.IntegerOperations.Multiplication();//return value is: 108
            int division = Util.IntegerOperations.Division();//return value is: 3
            int addFirst = Util.IntegerOperations.AddFirst();//return value is: 18
            int multiplyFirst = Util.IntegerOperations.MultiplyFirst();//return value is: 13
            int complexEquation = Util.IntegerOperations.ComplexEquation();//return value is: 25
            string modulo = Util.IntegerOperations.Modulo();
            string minMaxValues = Util.IntegerOperations.MinMaxIntValues();
            string overflow = Util.IntegerOperations.OverflowInt();
            double dub = Util.DoubleOperations.Add();
            double largeDub = Util.DoubleOperations.AddLargerDouble();
            string minMaxDoble = Util.DoubleOperations.MinMaxDouble();
            double roundingError = Util.DoubleOperations.DoubleRoundError();
            string minMaxDecimal = Util.DecimalOperations.MinMaxDecimal();
            string doubleVsDecimal = Util.DecimalOperations.DecimalVsDouble();
            string areaOFCircle = Util.DecimalOperations.CalculateCircle();
            Console.WriteLine(add);
            Console.WriteLine(subtract);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
            Console.WriteLine(addFirst);
            Console.WriteLine(multiplyFirst);
            Console.WriteLine(complexEquation);
            Console.WriteLine(modulo);
            Console.WriteLine(minMaxValues);
            Console.WriteLine(overflow);
            Console.WriteLine(dub);
            Console.WriteLine(largeDub);
            Console.WriteLine(minMaxDoble);
            Console.WriteLine(roundingError);
            Console.WriteLine(minMaxDecimal);
            Console.WriteLine(doubleVsDecimal);
            Console.WriteLine(areaOFCircle);
            Console.ReadLine();
        }
      

    }
}
