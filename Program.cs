using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
             int[,] myarray = new int[3, 3];
            int[,] myarray2 = new int[3, 3];

            for (int x = 0; x < myarray.GetLength(0); x++)
            {
                for (int y = 0; y < myarray.GetLength(1); y++)
                {
                    Console.WriteLine("Enter a Matrix:");
                    myarray[x, y] = Int32.Parse(Console.ReadLine());

                }
            }
            for (int x = 0; x < myarray2.GetLength(0); x++)
            {
                for (int y = 0; y < myarray2.GetLength(1); y++)
                {
                    Console.WriteLine("Enter a  second Matrix:");
                    myarray2[x, y] = Int32.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("A+B: ");
            int[,] array3 = Addition(myarray, myarray2);
            for (int x = 0; x < array3.GetLength(0); x++)
            {
                for (int y = 0; y < array3.GetLength(1); y++)
                {
                    Console.Write(array3[x, y]);

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static int[,] Addition(int[,] arr, int[,] arr2)
        {
            int[,] arr3 = new int[3, 3];

            for (int x = 0; x < arr3.GetLength(0); x++)
            {
                for (int y = 0; y < arr3.GetLength(1); y++)
                {

                    arr3[x, y] = arr[x, y] + arr2[x, y];
                }
            }
            return arr3;
        }
        }
    }
}
