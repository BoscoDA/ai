using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Week6PermutationsAndCounting
{
    public class Utilities
    {
        public static void Print(string title, BigInteger count, List<string> output, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            Console.WriteLine($"\n{title} = {count}");

            for (int i = 0; i < output.Count; i++)
            {
                if (i == output.Count - 1)
                {
                    Console.Write("[" + output[i] + "]\n");
                }
                else
                {
                    Console.Write("[" + output[i] + "] ");
                }

            }
        }

        public static string GetPermComInput()
        {
            bool validInput = false;
            string input = "";

            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Please enter 5 unique characters, numbers or symbols: ");
                input = Console.ReadLine()!.Trim();

                validInput = ValidatePermComInput(input);

                if (!validInput)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid input.");
                }
            }

            return input;
        }

        public static bool ValidatePermComInput(string input)
        {
            var temp = input.Distinct().ToList();

            if (temp.Count == 5)
            {
                return true;
            }
            
            return false;
        }

        public static string GetParInput()
        {
            bool validInput = false;
            string input = "";

            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Please enter 5 characters, numbers or symbols: ");
                input = Console.ReadLine()!.Trim();

                validInput = ValidateParInput(input);

                if (!validInput)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid input.");
                }
            }

            return input;
        }

        public static bool ValidateParInput(string input)
        {

            if (input.Length == 5)
            {
                return true;
            }

            return false;
        }
    }
}
