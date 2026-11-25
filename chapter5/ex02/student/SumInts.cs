using System;
using static System.Console;
using System.Globalization;

class SumInts
{
    static void Main()
    {
        int sum = 0;
        int number;

        Write("Enter an integer or 999 to quit: ");
        number = Convert.ToInt32(ReadLine());

        while (number != 999)
        {
            sum += number;

            Write("Enter an integer or 999 to quit: ");
            number = Convert.ToInt32(ReadLine());
        }

        WriteLine("The sum is {0}", sum);
    }
}