using System;
using System.Collections.Generic;
using System.Linq;

namespace GaustTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int leftNumbers = numbers[i];
                int rightNumbers = numbers[numbers.Count - 1 - i];
                int sum = leftNumbers + rightNumbers;
                result.Add(sum);
            }
            if (numbers.Count % 2 == 1)
            {
                int element = numbers[numbers.Count / 2];
                result.Add(element);
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
