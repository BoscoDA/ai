

namespace Week6PermutationsAndCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Utilities.GetPermComInput();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Now determining all permutations of [{input}]...");

            Utilities.Print("5P1", Permutation.CalcNPR(5, 1), Permutation.stringPerm(input, 1), ConsoleColor.Yellow);
            Utilities.Print("5P2", Permutation.CalcNPR(5, 2), Permutation.stringPerm(input, 2), ConsoleColor.Red);
            Utilities.Print("5P3", Permutation.CalcNPR(5, 3), Permutation.stringPerm(input, 3), ConsoleColor.Blue);
            Utilities.Print("5P4", Permutation.CalcNPR(5, 4), Permutation.stringPerm(input, 4), ConsoleColor.Magenta);
            Utilities.Print("5P5", Permutation.CalcNPR(5, 5), Permutation.stringPerm(input, 5), ConsoleColor.Green);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPress any key to generate combinations...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Now determining all combinations of [{input}]...");
            Utilities.Print("5C1", Permutation.Combinations(5, 1), Permutation.StringCombination(input, 1), ConsoleColor.Yellow);
            Utilities.Print("5C2", Permutation.Combinations(5, 2), Permutation.StringCombination(input, 2), ConsoleColor.Red);
            Utilities.Print("5C3", Permutation.Combinations(5, 3), Permutation.StringCombination(input, 3), ConsoleColor.Blue);
            Utilities.Print("5C4", Permutation.Combinations(5, 4), Permutation.StringCombination(input, 4), ConsoleColor.Magenta);
            Utilities.Print("5C5", Permutation.Combinations(5, 5), Permutation.StringCombination(input, 5), ConsoleColor.Green);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPress any key to continue to ordered partitions...");
            Console.ReadKey();
            Console.Clear();

            input = Utilities.GetParInput();
            Console.Clear();

            Console.WriteLine($"Now determining all ordered partitions of [{input}]...");
            Utilities.Print("Ordered Partition", Permutation.OrderedPartitions(5, input), Permutation.stringPartition(input), ConsoleColor.White);

            Console.ReadKey();
        }

    }
}