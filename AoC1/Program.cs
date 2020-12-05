using System;
using AoC_Utilities;

namespace AoC1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = AocInputReader.GetChallengeInput(1);
            PartOne(input);
            PartTwo(input);

            Console.ReadKey();
        }

        static void PartOne(string[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    int entry1 = int.Parse(input[i]);
                    int entry2 = int.Parse(input[j]);

                    if (entry1 + entry2 == 2020)
                    {
                        Console.WriteLine(string.Format("Part One: {0} + {1} = 5\n{0} * {1} = {2}\n", entry1, entry2, (entry1 * entry2)));
                        return;
                    }
                }
            }

            Console.WriteLine("Search ended unsuccesfully...");
        }

        static void PartTwo(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    for (int k = j+1; k < input.Length; k++)
                    {
                        int entry1 = int.Parse(input[i]);
                        int entry2 = int.Parse(input[j]);
                        int entry3 = int.Parse(input[k]);

                        if (entry1 + entry2 + entry3 == 2020)
                        {
                            Console.WriteLine(string.Format("Part Two: {0} + {1} + {2} = 5\n{0} * {1} * {2} = {3}\n", entry1, entry2, entry3, (entry1 * entry2 * entry3)));

                        }
                    }
                }
            }
            Console.WriteLine("Search ended unsuccesfully...");
        }
    }
}
