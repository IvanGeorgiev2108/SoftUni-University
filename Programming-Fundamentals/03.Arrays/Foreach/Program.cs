using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);     
            }
            // ЕДНО И СЪЩО НЕЩО!
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] input = Console.ReadLine().Split();
            foreach (var text in input)
            {
                Console.WriteLine(input);
            }

        }
    }
}
