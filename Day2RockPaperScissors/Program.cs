using System;
using System.IO;

namespace Day2RockPaperScissors
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetScoreFromInput());
        }

        static int GetScoreFromInput()
        {
            int totalScore = 0;
            StreamReader sr = new StreamReader("Input.txt");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (!string.IsNullOrWhiteSpace(line)) 
                    totalScore += GetSingleGameScore(line[0], line[2]);
            }
            return totalScore;
        }

        static int GetSingleGameScore(char elfPlay, char playerPlay)
        {
            Game game = new Game(elfPlay, playerPlay);
            return game.GetGameResult();
        }
    }
}
