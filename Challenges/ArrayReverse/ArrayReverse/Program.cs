using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            //test array
            int[] TestArray = { 1, 2, 3, 4, 5, 6 };
            PrintArray(TestArray);

    
            int[] result = ReverseArray(TestArray);
            Console.WriteLine("Result of reverse Method");
            PrintArray(result);

        }

        //method to reverse array
        static int[] ReverseArray(int[] InputArray)
        {
            int[] newArray = new int[InputArray.Length];

            for (int i = InputArray.Length-1; i >= 0; i--)
            {
                int newArrayCounter = 0;
                Console.Write(InputArray[i]);
                newArray[newArrayCounter] = InputArray[i];
                newArrayCounter++;
              
                
            }
          
            return newArray;
        }

        //method to print array to console
        static void PrintArray(int[] ArrayToPrint)
        {
            foreach(var item in ArrayToPrint)
            {
                Console.Write(item.ToString());
            }
        }

        
    }
}
