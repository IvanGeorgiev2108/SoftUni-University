using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOfString = Console.ReadLine();
            Stack<int> numbers = new Stack<int>();
            string[] numbersList = numberOfString.Split(' ');
            foreach (var number in numbersList)
            {
                numbers.Push(int.Parse(number));
            }
            while (true)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');
                string command = lineParts[0].ToLower();
                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    numbers.Push(int.Parse(lineParts[1]));
                    numbers.Push(int.Parse(lineParts[2]));
                }
                else if (command == "remove")
                {
                    var numbersOfElements =int.Parse (lineParts[1]);
                    if (numbersOfElements <= numbers.Count)
                    {
                        for (int i = 0; i < numbersOfElements; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }  
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
