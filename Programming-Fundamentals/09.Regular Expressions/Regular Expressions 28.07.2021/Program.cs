using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_28._07._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex nameRegex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

            string input = Console.ReadLine();

            bool isName = nameRegex.IsMatch(input);

            Console.WriteLine($"{input} is name => {isName}");
        }
    }
}
