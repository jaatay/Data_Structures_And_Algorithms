using System;

namespace BinarySearch
{
   public class Program
    {
       public static void Main(string[] args)
        {
            //test array and key, adjust as necessary
            int[] TestArray = { 4, 8, 15, 16, 23, 30, 42 };
            int TestKey = 15;

            //binary search method executed on test array and key
            BinarySearch(TestArray, TestKey);

            Console.WriteLine("Press enter to exit program.");
            while(Console.ReadKey().Key != ConsoleKey.Enter);
        }

        //method to search an array with a given key. Result printed to console as either array index if found, or -1 if not found
       public static int BinarySearch(int[] InputArray, int Key)
        {
			int left = 0;
			int right = InputArray.Length - 1;

            while (left < right)
            {
				int middle = (left + right) / 2;

                if(InputArray[middle] == Key)
                {
                    int FoundIt = middle;
                    Console.WriteLine($"Found Key at index {FoundIt}");
                    return FoundIt;
                }
				if(InputArray[middle] < Key)
				{
					left++;
				}
				if(InputArray[middle] > Key)
				{
					right--;
				}
            }
            Console.WriteLine(-1);
            return -1; 
        }
    }
}
