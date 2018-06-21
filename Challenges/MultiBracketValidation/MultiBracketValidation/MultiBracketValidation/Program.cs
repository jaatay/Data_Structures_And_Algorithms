using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Console.WriteLine(ValidateBrackets("()"));
            Console.WriteLine(ValidateBrackets("["));
            Console.WriteLine(ValidateBrackets("{}(())[]"));
            Console.WriteLine(ValidateBrackets(""));

        } 

       public static bool ValidateBrackets(string input)
        {
            int LCurl = 0;
            int RCurl = 0;
            int LSqr = 0;
            int RSqr = 0;
            int LPar = 0;
            int RPar = 0;

            if(input == "")
            {
                return false;
            }

            foreach(var c in input)
            {
                switch (c.ToString())
                {
                    case "{":
                        LCurl++;
                        break;
                    case "}":
                        RCurl++;
                        break;
                    case "[":
                        LSqr++;
                        break;
                    case "]":
                        RSqr++;
                        break;
                    case "(":
                        LPar++;
                        break;
                    case ")":
                        RPar++;
                        break;
                    default: break;
                }
            }

            return LCurl == RCurl && LSqr == RSqr && LPar == RPar;
        }
    }
}
