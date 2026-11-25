using System;
using static System.Console;
using System.Globalization;

class ArrayDemo
{
    enum Menu
    {
        IN_ORIGINAL_ORDER = 1, REVERSE_ORDER, SPECIFIC_POSITION, QUIT
    }

    static void Main()
    {
        int[] nums = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1};
        int choice;

        do
        {
            WriteLine("1. View list from first to last");
            WriteLine("2. View list from last to first");
            WriteLine("3. View number at specific position");
            WriteLine("4. Quit");
            Write("Enter your choice: ");

            choice = Convert.ToInt32(ReadLine());

            switch ((Menu)choice)
            {
                case Menu.IN_ORIGINAL_ORDER:
                    for (int i = 0; i < nums.Length; i++)
                    {
                        Write(nums[i] + " ");
                    }
                    WriteLine();
                    break;

                case Menu.REVERSE_ORDER:
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        Write(nums[i] + " ");
                    }
                    WriteLine();
                    break;

                case Menu.SPECIFIC_POSITION:
                    Write("Enter a position (0-9): ");
                    int position = Convert.ToInt32(ReadLine());

                    if (position >= 0 && position < nums.Length)
                    {
                        WriteLine("The number at position {0} is {1}",
                            position, nums[position]);
                    }
                    else
                    {
                        WriteLine("Invalid position.");
                    }
                    break;

                case Menu.QUIT:
                    WriteLine("Goodbye!");
                    break;

                default:
                    WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != (int)Menu.QUIT);
    }
}