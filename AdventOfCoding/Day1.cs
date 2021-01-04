using System;
using System.IO;
using System.Linq;

namespace AdventOfCoding
{
    public class Day1Part1
    {
        public static void Start()
        {
            var input = "";
            //using is used for disposable classes | StreamReader is basically Scanner in Java, 
            using var sr = new StreamReader("Input/Day1Input.txt");

            //The \r is a carriage return which will cause issues when parsing through the input,
            // we user the replace function to remove them and replace them with nothing! 
            input = sr.ReadToEnd().Replace("\r", "");
            //This is to have the Reader to stop reading file, we pulled the data we need
            // so we no longer need it reading
            sr.Close();
            //This will parse the string input into a int and we use .toArray to change it back into an Array
            //Changes from Enumerable to Array
            //Think of Enumerable as a beta / lower form of Array
            var inputArray = input.Split("\n").Select(int.Parse).ToArray();

            //foreach is going through each input and assigning it to the variable Sum1, which I am then using for stuff
            foreach (var Sum1 in inputArray)
            {
                foreach (var Sum2 in inputArray)
                {
                    if (Sum1 + Sum2 != 2020) continue;
                    //We do not use sout anymore, we now use cw
                    Console.ForegroundColor = ConsoleColor.Red;
                    //This is called interpolation which Java does not have
                    Console.WriteLine(
                        $"{Sum1} + {Sum2} are the values that equal 2020. {Sum1 * Sum2} is the multiplication of both sums");
                    return;
                }
            }
        }
    }

    public class Day1Part2
    {
        public static void Start()
        {
            var input = "";
            using var sr = new StreamReader("Input/Day1Input.txt");

            input = sr.ReadToEnd().Replace("\r", "");
            sr.Close();
            var inputArray = input.Split("\n").Select(int.Parse).ToArray();

            foreach (var Sum1 in inputArray)
            {
                foreach (var Sum2 in inputArray)
                {
                    foreach (var Sum3 in inputArray)
                    {
                        if (Sum1 + Sum2 + Sum3 != 2020) continue;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(
                            $"{Sum1} + {Sum2} + {Sum3} are the values that equal 2020. {Sum1 * Sum2 * Sum3} is the multiplication of the three sums");
                        return;
                    }
                    
                }
                
            }
        }
    }
}