using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cout = int.Parse(Console.ReadLine());

            Myltiply(input, cout);
        }
        static void Myltiply(string input, int cout)
        {
            double total = 0;
            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;
            if (input == "coffee")
            {
                total = cout * coffeePrice;
            }
            else if (input == "water")
            {
                total = cout * waterPrice;
            }
            else if (input == "coke")
            {
                total = cout * cokePrice;
            }
            else if (input == "snacks")
            {
                total = cout * snacksPrice;
            }            
            Console.WriteLine($"{total:f2}");
        }
    }
}
