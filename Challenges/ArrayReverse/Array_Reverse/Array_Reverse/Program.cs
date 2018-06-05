using System;

namespace Array_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //test array
            Console.WriteLine("Test Array Values");
            int[] TestArray = { 1, 2, 3, 4, 5, 6, 77, -88, 9, 10000 };

            //printing the values of the test array for comparison
            PrintArray(TestArray);
            Console.WriteLine("");

            //performing reverse array method
            int[] result = ReverseArray(TestArray);

            //printing values of reversed array for comparison
            Console.WriteLine("Reversed Array Values");
            PrintArray(result);

            //read line to pause before exit
            Console.ReadLine();
        }

        //method to reverse array
        static int[] ReverseArray(int[] InputArray)
        {
            int[] newArray = new int[InputArray.Length];
            int HoldValue = 0;

            for (int i = InputArray.Length - 1; i >= 0; i--)
            {
                newArray[HoldValue] = InputArray[i];
                HoldValue++;
            }

            return newArray;
        }

        //method to print array to console
        static void PrintArray(int[] ArrayToPrint)
        {
            foreach (var item in ArrayToPrint)
            {
                item.ToString();
            }
            Console.Write(string.Join(",", ArrayToPrint));
        }
    }
    
}
