using System;
using System.Collections.Generic;
using System.IO;

namespace Day1CalorieCounting
{
    static class Program
    {
        static List<int> _highestElves = new List<int>(4) {0, 0, 0};
        
        public static void Main(string[] args)
        {
            PopulateElves();
        }
        
        static void PopulateElves()
        {
            StreamReader sr = new StreamReader("Input.txt");

            while (!sr.EndOfStream)
            {
                int totalCalories = 0;
                string line = sr.ReadLine();
                while (!string.IsNullOrWhiteSpace(line))
                {
                    totalCalories += int.Parse(line);
                    line = sr.ReadLine();
                }
                for (int i = 0; i < _highestElves.Count; i++)
                {
                    if (totalCalories > _highestElves[i])
                    {
                        _highestElves.Insert(i, totalCalories);
                        _highestElves.RemoveAt(3);
                        break;
                    }
                }
            }
            int combinedCalories = 0;
            _highestElves.ForEach(e => combinedCalories += e);
            Console.WriteLine(combinedCalories);
        }
    }
}
