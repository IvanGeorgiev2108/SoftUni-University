using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int elements = int.Parse(commandArgs[1]);
                if (action == "Add")
                {
                    numbers.Add(elements);
                }
                else if (action == "Remove")
                {
                    numbers.Remove(elements);
                }
                else if (action=="RemoveAt")
                {
                    numbers.RemoveAt(elements);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, elements);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
