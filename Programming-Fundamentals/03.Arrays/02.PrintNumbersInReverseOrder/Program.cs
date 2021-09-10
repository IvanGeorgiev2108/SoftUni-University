using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[numbers.Length - 1 - i] + " ");
            }









            // FIRST WAY!
            //int[] reversNumbers = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    reversNumbers[i] = numbers[numbers.Length - 1 - i];
            //}
            //for (int i = 0; i < reversNumbers.Length; i++)
            //{
            //    Console.Write(reversNumbers[i] + " ");
            //}
        }
    }
}
