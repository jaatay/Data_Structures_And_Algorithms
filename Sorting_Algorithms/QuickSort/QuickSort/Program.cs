using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Unsorted Array: ");
            PrintThis(testArray);
            Console.WriteLine("");
            var sorted = Quicksort(testArray, 0, testArray.Length - 1);
            Console.WriteLine("");
            Console.WriteLine("Sorted Array: ");
            PrintThis(sorted);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        /// <summary>
        /// test array
        /// </summary>
       public static int[] testArray = { 1, -10, 3, 100, 4, 50, -2 };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="printArray"></param>
        public static void PrintThis(int[] printArray)
        {
            for(var i = 0; i < printArray.Length; i++)
            {
                Console.Write($"{printArray[i]}, ");
            }
        }

        /// <summary>
        /// method to quicksort
        /// </summary>
        /// <param name="inputArray">input integer array</param>
        /// <param name="left">left value, basically will always be 0 since we are using arrays</param>
        /// <param name="right">right value, array length - 1 so we get the last value</param>
        /// <returns>sorted array</returns>
        public static int[] Quicksort(int[] inputArray, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = inputArray[(left + right) / 2];

            while(i <= j)
            {
                while(inputArray[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while(inputArray[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if(i <= j)
                {
                    var temp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = temp;

                    i++;
                    j--;
                }
            }

            if(left < j)
            {
                Quicksort(inputArray, left, j);
            }
            if(i < right)
            {
                Quicksort(inputArray, i, right);
            }

            return inputArray;
        }
    }
}
