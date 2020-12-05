using System;

namespace AoC3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = AoC_Utilities.AocInputReader.GetChallengeInput(3);
            //string[] input = { "....#...##.#.........#....#....", "#.......#...#...#.#............", "#..#..#.#.##....#.#........#...", "........##...................#." };

            int[] results = new int[5];

            results[0] = PassedTrees((string[])input.Clone(), 1, 1);
            results[1] = PassedTrees((string[])input.Clone(), 3, 1);
            results[2] = PassedTrees((string[])input.Clone(), 5, 1);
            results[3] = PassedTrees((string[])input.Clone(), 7, 1);
            results[4] = PassedTrees((string[])input.Clone(), 1, 2, true);

            long product = 1;

            for (int i = 0; i < results.Length; i++)
            {
                product *= results[i];
            }

            Console.WriteLine("\nProduct of trees passed on slopes: " + product);

            Console.ReadKey();
        }

        static void InsertCharInString(char toInsert, int index, string target)
        {
            char[] output = new char[target.Length];
        }

        static int PassedTrees(string[] input, int right, int down, bool display = false)
        {
            int width = input[0].Length;
            int x = 0;
            int trees = 0;

            Console.WriteLine(string.Format("\nChecking route for slope: {0} right, {1} down", right, down));

            if (display) Console.WriteLine(input[0]);

            for (int y = 1; y < input.Length; y++)
            {
                if (y % down != 0)
                {
                    if (display) Console.WriteLine(input[y]);
                    continue;
                }

                x = (x + right) % width;

                if (input[y][x] == '.')
                {
                    input[y] = input[y].Remove(x, 1);
                    input[y] = input[y].Insert(x, "O");
                }
                else
                {
                    input[y] = input[y].Remove(x, 1);
                    input[y] = input[y].Insert(x, "X");
                    trees++;
                }

                if (display) Console.WriteLine(input[y]);
            }

            Console.WriteLine("Trees passed: " + trees);

            return trees;
        }
    }
}
