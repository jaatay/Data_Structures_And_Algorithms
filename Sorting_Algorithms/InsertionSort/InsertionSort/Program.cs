using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertionSort(testArray);
        }


        public int[] testArray = { 1, -1, 2, 100, -3, 5 };
        public void InsertionSort(int[] inputArray)
        {

            //print unsorted
            Console.WriteLine("Unsorted Array: ");
            for(int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]}, ");
            }

            int temp;
            int j;

            for(int i = 1; i < inputArray.Length; i++)
            {
                temp = inputArray[i];
                j = i - 1;

                while(j >= 0 && inputArray[j] > temp)
                {
                    inputArray[j + 1] = inputArray[j];
                    j--;
                }

                inputArray[j + 1] = temp;
            }

            //print sorted
            Console.WriteLine("");
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]}, ");
            }
        }
    }
}
