using System;

namespace Array_Adjacent_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wolrd!");
            AdjacentProduct(TestArray);
        }

        static int[,] TestArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        //1 9 1 i down j right
        //50 1 6
        //7 8 9

        //main method
       static int AdjacentProduct(int[,] InputArray)
        {
            int FinalScore = 0;
            int TempScore = 0;

            for (int i = 0; i < InputArray.GetLength(0); i++)
            {
                for(int j = 0; j < InputArray.GetLength(1); j++)
                {
                    
                    int CurrentIndex = InputArray[i, j];

                    int ProductRight = 0;
                    int ProductLeft = 0;
                    int ProductUp = 0;
                    int ProductDown = 0;

                    int ProductUpRight = 0;
                    int ProductDownRight = 0;
                    int ProductUpLeft = 0;
                    int ProductDownLeft = 0;

                    try
                    {
                        ProductRight = CurrentIndex * InputArray[i, j + 1];
                        if (ProductRight > TempScore)
                        {
                            TempScore = ProductRight;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductRight = 0;
                    }

                    try
                    {
                        ProductLeft = CurrentIndex * InputArray[i, j - 1];
                        if (ProductLeft > TempScore)
                        {
                            TempScore = ProductLeft;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductLeft = 0;
                    }

                    try
                    {
                        ProductUp = CurrentIndex * InputArray[i - 1, j];
                        if (ProductUp > TempScore)
                        {
                            TempScore = ProductUp;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductUp = 0;
                    }

                    try
                    {
                        ProductDown = CurrentIndex * InputArray[i + 1, j];
                        if (ProductDown > TempScore)
                        {
                            TempScore = ProductDown;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductDown = 0;
                    }

                    try
                    {
                        ProductUpRight = CurrentIndex * InputArray[i - 1, j + 1];
                        if (ProductUpRight > TempScore)
                        {
                            TempScore = ProductUpRight;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductUpRight = 0;
                    }

                    try
                    {
                        ProductDownRight = CurrentIndex * InputArray[i + 1, j + 1];
                        if (ProductDownRight > TempScore)
                        {
                            TempScore = ProductDownRight;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductDownRight = 0;
                    }

                    try
                    {
                        ProductUpLeft = CurrentIndex * InputArray[i - 1, j - 1];
                        if (ProductUpLeft > TempScore)
                        {
                            TempScore = ProductUpLeft;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductUpLeft = 0;
                    }

                    try
                    {
                        ProductDownLeft = CurrentIndex * InputArray[i + 1, j - 1];
                        if (ProductDownLeft > TempScore)
                        {
                            TempScore = ProductDownLeft;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ProductDownLeft = 0;
                    }

                    Console.WriteLine(TempScore);
                    
                }
                FinalScore = TempScore;
            }

            Console.WriteLine($"The highest product is: {FinalScore}");
           
            return FinalScore;
        }
    }
}
