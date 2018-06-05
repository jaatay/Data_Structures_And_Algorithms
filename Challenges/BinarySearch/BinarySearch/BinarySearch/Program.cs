using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //test array and key, adjust as necessary
            int[] TestArray = { 4, 8, 15, 16, 23, 42 };
            int TestKey = 23;

            //binary search method executed on test array and key
            BinarySearch(TestArray, TestKey);

            Console.WriteLine("Press any key to exit program.");
            Console.ReadLine();
        }


        //method to search an array with a given key. Result printed to console as either array index if found, or -1 if not found
        static int BinarySearch(int[] InputArray, int Key)
        {
            for (int i = 0; i < InputArray.Length; i++)
            {
                if (InputArray[i] == Key)
                {
                    int FoundIt = i;
                    Console.WriteLine(FoundIt);
                    return FoundIt;
                }
            }
            Console.WriteLine(-1);
            return -1; 
        }
    }
}
