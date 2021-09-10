using System;
using System.Linq;

namespace ReadNumberFromSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"[{i}] = {numbers[i]}");
            }
        }
    }
}
