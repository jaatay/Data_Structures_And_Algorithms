using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort");
            InsertionSort(testArray);
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        public static int[] testArray = { 1, 10, 3, 5 };

        public static void InsertionSort(int[] numArray)
        {
            Console.Write("Original Array:");
            //print original
            for (var o = 0; o < numArray.Length; o++)
            {

                Console.Write($"{numArray[o]}, ");
            }
           
            for(var i = 1; i < numArray.Length; i++)
            {
                var temp = numArray[i];
                var X = i - 1;

                while (X >= 0 && numArray[X] > temp)
                {
                    numArray[X + 1] = numArray[X];
                    X--;
                }

                numArray[X + 1] = temp;
            }

            Console.WriteLine("");
            Console.Write("Sorted Array:");
            //print it
            for(var k = 0; k < numArray.Length; k++)
            {
                Console.Write($"{numArray[k]}, ");
            }
           
        }
    }
   
}
