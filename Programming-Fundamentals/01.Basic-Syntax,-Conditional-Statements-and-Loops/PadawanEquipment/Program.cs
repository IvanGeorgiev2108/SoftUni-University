﻿using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfLightSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalSum = priceOfLightSabers * Math.Ceiling(studentsCount * 1.1) + priceOfRobes * studentsCount + priceOfBelts *( studentsCount - (studentsCount / 6));

            if (amountOfMoney >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - amountOfMoney:F2}lv more.");
            }        
        }
    }
}
