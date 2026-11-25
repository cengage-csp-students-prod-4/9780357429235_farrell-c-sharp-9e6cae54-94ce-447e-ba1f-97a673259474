using System;
using static System.Console;
using System.Globalization;

class SumFiveInts
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 5; i++)
        {
            Write("Enter integer {0}: ", i);
            int number = Convert.ToInt32(ReadLine());
            sum += number;
        }

        WriteLine("The sum is {0}", sum);
    }
}