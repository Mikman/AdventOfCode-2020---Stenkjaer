using System;

namespace AoC2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = AoC_Utilities.AocInputReader.GetChallengeInput(2);
            //string[] input = { "8-9 x: xxxxxxxrk", "5-8 f: fxffmfff", "1-4 g: gggg", "4-5 w: wrwws" };

            int count1 = 0, count2 = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (PartOneValidPassword(input[i])) count1++;
                if (PartTwoValidPassword(input[i])) count2++;
            }

            Console.WriteLine("Part one valid passwords: " + count1);
            Console.WriteLine("Part two valid passwords: " + count2);

            Console.ReadKey();
        }

        static bool PartOneValidPassword(string password)
        {
            string[] parts = password.Split(' ');
            int min = int.Parse(parts[0].Split('-')[0]);
            int max = int.Parse(parts[0].Split('-')[1]);
            char designator = char.Parse(parts[1].Substring(0, 1));

            int count = 0;
            for (int i = 0; i < parts[2].Length; i++)
            {
                if (parts[2][i] == designator) count++;
            }

            if (count >= min && count <= max) return true;

            return false;
        }

        static bool PartTwoValidPassword(string password)
        {
            string[] parts = password.Split(' ');
            int min = int.Parse(parts[0].Split('-')[0]);
            int max = int.Parse(parts[0].Split('-')[1]);
            char designator = char.Parse(parts[1].Substring(0, 1));

            if ((parts[2][min-1] == designator) ^ (parts[2][max-1] == designator)) return true;

            return false;
        }
    }
}
