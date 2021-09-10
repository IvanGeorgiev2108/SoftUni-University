using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCollections = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondCollections = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int maxCount = Math.Max(firstCollections.Count, secondCollections.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (i < firstCollections.Count)
                {
                    result.Add(firstCollections[i]);
                }
                if (i < secondCollections.Count)
                {
                    result.Add(secondCollections[i]);
                }
            }
            Console.WriteLine(string.Join (" ",result));
        }
    }
}
