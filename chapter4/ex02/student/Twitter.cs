
using System;
using static System.Console;
using System.Globalization;

class Twitter
{
    static void Main()
    {
        string message = ReadLine();

        if (message.Length > 140)
        {
            WriteLine("The message is too long");
        }
        else
        {
            WriteLine("The message is okay");
        }
    }
}
