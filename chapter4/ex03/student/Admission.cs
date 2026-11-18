
using System;
using static System.Console;
using System.Globalization;

class Admission
{
    static void Main()
    {
        double gpa;
        int testScore;

        Write("Enter grade point average: ");
        gpa = Convert.ToDouble(ReadLine());

        Write("Enter admission test score: ");
        testScore = Convert.ToInt32(ReadLine());

        if ((gpa >= 3.0 && testScore >= 60) ||
            (gpa < 3.0 && testScore >= 80))
        {
            WriteLine("Accept");
        }
        else
        {
            WriteLine("Reject");
        }
    }
}
