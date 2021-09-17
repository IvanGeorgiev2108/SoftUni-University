using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            int counter = nums.Length;
            for (int i = 0; i < counter; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    numbers.Enqueue(nums[i]);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
