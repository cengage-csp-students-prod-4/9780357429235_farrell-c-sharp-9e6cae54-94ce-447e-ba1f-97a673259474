
using System;
using static System.Console;
using System.Globalization;

class CheckCredit
{
    static void Main()
    {
        WriteLine("Enter the purchase price:");
        double price = Convert.ToDouble(ReadLine());

        if (price > 8000)
        {
            WriteLine("You have exceeded the credit limit");
        }
        else
        {
            WriteLine("Approved");
        }
    }
}
