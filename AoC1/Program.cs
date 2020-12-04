using System;
using AoC_Utilities;

namespace AoC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 1; i <= 5; i++)
            {
                string[] input = AocInputReader.GetChallengeInput(i, true);

                Console.WriteLine("From Challenge " + i + ":");
                for (int j = 0; j < input.Length; j++)
                {
                    Console.WriteLine(string.Format("{0}: {1}", j, input[j]));
                }
            }
            
            Console.ReadKey();
        }
    }
}
