using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger biggestValue = 0;

            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;


            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quanlity = int.Parse(Console.ReadLine());

                BigInteger currentValue =BigInteger.Pow(snow / time, quanlity);

                if (currentValue > biggestValue)
                {
                    biggestValue = currentValue;
                    biggestSnow = snow;
                    biggestTime = time;
                    biggestQuality = quanlity;
                }
            }
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
        }   
    }
}
