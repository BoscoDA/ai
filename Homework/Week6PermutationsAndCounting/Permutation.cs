using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Week6PermutationsAndCounting
{
    internal class Permutation
    {
        public static BigInteger Factorial(BigInteger n)
        {
            //factorial of 1 and 0 are both 1
            if (n <= 1)
            {
                return 1;
            }

            // recursively multiply input by each number after it until 1
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static BigInteger CalcNPR(BigInteger n, BigInteger r)
        {
            BigInteger nFac = Factorial(n);
            BigInteger denomFac = Factorial(n - r);

            return nFac / denomFac;
        }

        public static BigInteger Combinations(BigInteger n, BigInteger r)
        {
            BigInteger nFac = Factorial(n);
            BigInteger denomFac = Factorial(n - r);
            BigInteger rFac = Factorial(r);

            return nFac / (denomFac * rFac);
        }

        public static BigInteger OrderedPartitions(BigInteger n, string input)
        {
            // use a dictionary to keep track of each character used and store it with the number 
            // of times used
            Dictionary<char, BigInteger> dict = new Dictionary<char, BigInteger>();
            foreach (char c in input)
            {
                // if the character is not in the dictionary add it
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                //otherwise increment the value at the given key
                else
                {
                    dict[c]++;
                }
            }

            BigInteger numerator = Factorial(n);
            BigInteger denominator = 1;

            //loop through each entry in the dictionary and calculate the denominator by
            // finding the product of the factorial of each key's value
            foreach (KeyValuePair<char, BigInteger> c2 in dict)
            {
                if(c2.Value > 1)
                {
                    denominator *= Factorial(c2.Value);
                }
            }

            return numerator / denominator;
        }

        public static List<string> stringPerm(string input, int r)
        {
            List<char> myString = input.ToList();
            List<char> list = new List<char>();
            List<string> ans = new List<string>();

            return RecurPermutation(myString, list, ans, r, 0);
        }

        /// <summary>
        /// Funcation that recursively builds all permutations of a size r from a given input string.
        /// </summary>
        /// <param name="input">Char list of the string you want the permutations of.</param>
        /// <param name="output">used to hold the current path down the perm tree.</param>
        /// <param name="ans">Holds the list of all the permutations</param>
        /// <param name="r">The number of characters you want each permutation to be.</param>
        /// <param name="depth">Used to track how far down the perm tree you are.</param>
        /// <returns></returns>
        public static List<string> RecurPermutation(List<char> input, List<char> output, List<string> ans, int r, int depth)
        {

            // depth keeps track of the depth of the combination tree
            // depth = to the length of the combinations you are making
            depth++;

            // when depth becomes greater than r you are at the layer 1 past the desired depth
            if (depth > r)
            {
                ans.Add(string.Concat(output));
                return ans;
            }

            foreach (char c in input)
            {
                // add input to a temp list which can be manipulated for passing
                // the elements that are usable at the next layer of the tree
                List<char> temp = input.ToList();
                output.Add(c);

                // this type should not have any dups so we can use the remove funt
                temp.Remove(c);
                ans = RecurPermutation(temp, output, ans, r, depth);

                // when you return from recursion remove the last element to backtrack
                output.Remove(c);
            }

            return ans;
        }

        public static List<string> StringCombination(string input, int r)
        {
            List<char> myString = input.ToList();
            List<char> list = new List<char>();
            List<string> ans = new List<string>();

            return RecurCombination(myString, list, ans, r, 0);
        }

        /// <summary>
        /// Funcation that recursively builds all combinations of a size r from a given input string.
        /// </summary>
        /// <param name="input">Char list of the string you want the permutations of.</param>
        /// <param name="output">used to hold the current path down the perm tree.</param>
        /// <param name="ans">Holds the list of all the permutations</param>
        /// <param name="r">The number of characters you want each permutation to be.</param>
        /// <param name="depth">Used to track how far down the perm tree you are.</param>
        /// <returns></returns>
        public static List<string> RecurCombination(List<char> input, List<char> output, List<string> ans, int r, int depth)
        {
            // depth keeps track of the depth of the combination tree
            // depth = to the length of the combinations you are making
            depth++;

            // when depth becomes greater than r you are at the layer 1 past the desired depth
            if (depth > r)
            {
                // turn the ouput into a string and sort it
                string temp = string.Concat(output.OrderBy(a => a));

                // since the string is sorted, when we check to see if it is in the list
                // we will only add any combination of those characters once
                if(!ans.Contains(temp))
                {
                    ans.Add(temp);
                }
                return ans;
            }

            foreach (char c in input)
            {
                // add input to a temp list which can be manipulated for passing
                // the elements that are usable at the next layer of the tree
                List<char> temp = input.ToList();
                output.Add(c);

                // this type should not have any dups so we can use the remove funt
                temp.Remove(c);
                ans = RecurCombination(temp, output, ans, r, depth);

                // when you return from recursion remove the last element to backtrack
                output.Remove(c);
            }

            return ans;
        }

        public static List<string> stringPartition(string input)
        {
            List<char> myString = input.ToList();
            List<char> list = new List<char>();
            List<string> ans = new List<string>();

            return RecurPartition(myString, list, ans);
        }

        public static List<string> RecurPartition(List<char> input, List<char> output, List<string> ans)
        {
            if (input.Count == 0)
            {
                // if the element is already in ans then it is a dup and should not be added
                if (!ans.Contains(string.Concat(output)))
                {
                    ans.Add(string.Concat(output));
                }
                return ans;
            }

            // Loop through each element of the input
            for (int i = 0; i < input.Count; i++)
            {
                // add input to a temp list which can be manipulated for passing
                // the elements that are usable at the next layer of the tree
                List<char> temp = input.ToList();
                output.Add(input[i]);

                //have to use RemoveAt because with dups the Remove funt grabs find the first
                //match while RemoveAt will accurately get the index I want
                temp.RemoveAt(i);
                ans = RecurPartition(temp, output, ans);

                // when you return from recursion remove the last element to backtrack
                output.RemoveAt((output.Count-1));
            }

            return ans;
        }
    }
}
