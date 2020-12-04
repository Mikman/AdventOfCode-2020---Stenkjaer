using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AoC_Utilities
{
    public static class AocInputReader
    {
        public const string CHALLENGE_FOLDER_PATH = @"C:\Users\Mikkel\source\repos\AoC2020\AoC Input\";

        public static string GetChallengeInputName(int challengeNumber)
        {
            return CHALLENGE_FOLDER_PATH + challengeNumber.ToString() + ".txt";
        }

        public static string[] GetChallengeInput(int challengeNumber, bool lines = true)
        {
            string challengePath = GetChallengeInputName(challengeNumber);

            if (File.Exists(challengePath))
            {
                StreamReader sr = File.OpenText(challengePath);

                if (lines)
                {
                    List<string> input = new List<string>();
                    string nextInput;

                    while ((nextInput = sr.ReadLine()) != null)
                    {
                        input.Add(nextInput);
                    }

                    return input.ToArray();

                } else
                {
                    return new string[] { sr.ReadToEnd() };
                }

                sr.Dispose();

            } else Console.WriteLine("Challenge input does not exist!");

            return new string[] { };
        }
    }
}
