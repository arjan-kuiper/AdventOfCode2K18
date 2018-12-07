// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="arjan-kuiper">
//   Arjan
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode
{
    using System;
    using System.Numerics;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            Begin:
            Console.WriteLine("   ___       _                      _    _____   __  _____             _            _____  _____  __   _____ \r\n / _ \\     | |                    | |  |  _  | / _|/  __ \\           | |          / __  \\|  _  |/  | |  _  |\r\n/ /_\\ \\  __| |__   __  ___  _ __  | |_ | | | || |_ | /  \\/  ___    __| |  ___     `\' / /\'| |/\' |`| |  \\ V / \r\n|  _  | / _` |\\ \\ / / / _ \\| \'_ \\ | __|| | | ||  _|| |     / _ \\  / _` | / _ \\      / /  |  /| | | |  / _ \\ \r\n| | | || (_| | \\ V / |  __/| | | || |_ \\ \\_/ /| |  | \\__/\\| (_) || (_| ||  __/    ./ /___\\ |_/ /_| |_| |_| |\r\n\\_| |_/ \\__,_|  \\_/   \\___||_| |_| \\__| \\___/ |_|   \\____/ \\___/  \\__,_| \\___|    \\_____/ \\___/ \\___/\\_____/\r\n                                                                                                            \r\n                                                                                                            ");
            Console.WriteLine("==================================================");

            Start:
            Console.WriteLine("> Please enter the number of the day you want to solve. (1-2)");
            if (int.TryParse(Console.ReadLine(), out var i))
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine($"> The solution to Day 1 (1/2) is '{DayOne.SolvePartOne()}'");
                        Console.WriteLine($"> The solution to Day 1 (2/2) is '{DayOne.SolvePartTwo()}'");
                        break;
                    case 2:
                        Console.WriteLine($"> The solution to Day 2 (1/2) is '{DayTwo.SolvePartOne()}'");
                        Console.WriteLine($"> The solution to Day 2 (2/2) is '{DayTwo.SolvePartTwo()}'");
                        break;
                    default:
                        Console.WriteLine("> Invalid day entered.");
                        goto Start;
                }
            }
            else
            {
                Console.WriteLine("> Invalid day entered.");
                goto Start;
            }


            Console.WriteLine("\n> Press any key to view other solutions.");
            Console.ReadKey();
            Console.Clear();
            goto Begin;
        }
    }
}
