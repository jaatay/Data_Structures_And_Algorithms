using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestString("Test this");
        }

        public static void TestString(string input)
        {
            var SplitString = input.Split(" ");
            string[] HoldArray = new string[SplitString.Length];

            foreach(var item in SplitString)
            {
                Regex findMe = new Regex(item);
                var match = findMe.Match(input);
                Console.WriteLine(match);
            }
           

            for(var i = 0; i < SplitString.Length; i++)
            {
                HoldArray[i] = SplitString[i];
            }

            foreach (var item in HoldArray)
            {

               
                //HoldArray.Add(item);
                //Console.WriteLine(item);
            }

        }
    }
}
