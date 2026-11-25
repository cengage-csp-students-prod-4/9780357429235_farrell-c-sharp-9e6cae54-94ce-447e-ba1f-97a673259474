using System;
using static System.Console;
using System.Globalization;

class TestScoreList
{
    static void Main()
    {
        int[] scores = new int[8];
        int sum = 0;
        double average;

        for (int i = 0; i < scores.Length; i++)
        {
            Write("Enter test score {0}: ", i);
            scores[i] = Convert.ToInt32(ReadLine());
            sum += scores[i];
        }

        average = (double)sum / scores.Length;

        for (int i = 0; i < scores.Length; i++)
        {
            WriteLine("Test # {0}: {1,5} From average: {2,5}",
                i, scores[i], scores[i] - average);
        }
    }
}