using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int currenNumber = num[i];
                if (currenNumber % 2 == 0)
                {
                    sum += currenNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
