
using System;
using static System.Console;
using System.Globalization;

class DoubleDecimalTest
{
    static void Main()
    {
        double doubleNumber = 1E+50;
        decimal decimalNumber = 1E+50M;

        WriteLine("Double value: " + doubleNumber);
        WriteLine("Decimal value: " + decimalNumber);
    }
}
