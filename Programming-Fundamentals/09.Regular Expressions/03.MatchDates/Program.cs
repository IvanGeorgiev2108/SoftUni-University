using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, @"(?<day>[0-9]{2})(?<separetor>.)(?<month>[A-Z][a-z]{2})\k<separetor>(?<year>[0-9]{4})");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
