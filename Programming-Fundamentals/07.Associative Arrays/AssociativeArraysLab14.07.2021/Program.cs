using System;
using System.Collections.Generic;

namespace AssociativeArraysLab14._07._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char , List<string>> namesDict = new Dictionary<char, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char startChar = name[0];

                if (!namesDict.ContainsKey(startChar))
                    namesDict.Add(startChar, new List<string>());

                namesDict[startChar].Add(name);
            }
            foreach (var item in namesDict)
            {
                Console.WriteLine($"{item.Key} ->");
                Console.WriteLine(string.Join (" " , item.Value));
            }
        }
    }
}
