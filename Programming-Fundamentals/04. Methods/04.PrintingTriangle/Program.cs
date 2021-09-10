using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintingTriangle(num);
        }

        static void PrintingTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintCol(row);
            }
            for (int row = n - 1; row >= 1; row--)
            {
                PrintCol(row);
            }
        }

        private static void PrintCol(int row)
        {
            for (int j = 1; j <= row; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
