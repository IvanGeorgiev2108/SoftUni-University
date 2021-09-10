using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            var numbersAssArr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbersAssArr.Length; i++)
            {
                if (!numbers.ContainsKey(numbersAssArr[i]))
                {
                    numbers.Add(numbersAssArr[i] , 0);
                }

                numbers[numbersAssArr[i]]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
