using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int even = 0;
            int odd = 0;
            for (int i = 0; i <numbers.Length; i++)
            {
                int num = numbers[i];
                if (num % 2 == 0)
                {
                    even += num;
                }
                else if (num != 0)
                {
                    odd += num;
                }    
            }
            int result = even - odd;
            Console.WriteLine(result);
        }
    }
}
