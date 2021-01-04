using System;
using System.IO;
using System.Linq;

namespace AdventOfCoding
{
    public class Day2Part1
    {
        public static void Start()
        {
            var input = "";
            var GoodPasswords = 0;
            using var sr = new StreamReader("Input/Day2Input.txt");

            input = sr.ReadToEnd().Replace("\r", "");
            sr.Close();
            var inputArray = input.Split("\n").Select(s => s.Split(" ")).ToArray();
            //This is an Ambiguous method or Anonymous method or In-line method 
            GoodPasswords = inputArray.Count(line =>
            {
                var limiter = line[0].Split("-").Select(int.Parse).ToArray();
                var countedLetters = line[2].Count/* This looking for the match letter */(s => s == line[1][0] /* line[1][0] is specifically looking at the letter from the input */);
                //This will return true if it passes these conditions 
                return countedLetters >= limiter[0] && countedLetters <= limiter[1];
            });


            // foreach (string[] line in inputArray)
            // {
            //     var letter = line[1][0];
            //     var limiter = line[0].Split("-").Select(int.Parse).ToArray();
            //     var UpperLimit = limiter[1];
            //     var LowerLimit = limiter[0];
            //     var passwordGiven = line[2];
            //     var countedLetters = passwordGiven.Count(s => s == letter);
            //     if (countedLetters >= LowerLimit && countedLetters <= UpperLimit)
            //     {
            //         GoodPasswords++;
            //     }
            // }

            Console.WriteLine($"The correct number of passwords is {GoodPasswords}");
        }
    }


    public class Day2Part2
    {
        public static void Start()
        {
            var input = "";
            var GoodPasswords = 0;
            using var sr = new StreamReader("Input/Day2Input.txt");

            input = sr.ReadToEnd().Replace("\r", "");
            sr.Close();
            var inputArray = input.Split("\n").Select(s => s.Split(" ")).ToArray();
            //This is an Ambiguous method or Anonymous method or In-line method 
            GoodPasswords = inputArray.Count(line =>
            {
                var positions = line[0].Split("-").Select(int.Parse).ToArray();
                var letter = line[1][0];
                var Position1 = positions[0]-1;
                var Position2 = positions[1]-1;
                
                //This will return true if it passes these conditions 
                return line[2][Position1] == letter ^ line[2][Position2] == letter ;
            });

            Console.WriteLine($"The correct number of passwords is {GoodPasswords}");
        }
    }
}