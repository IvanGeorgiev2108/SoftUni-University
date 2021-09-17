using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stackIndexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stackIndexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int index = stackIndexes.Pop();
                    string result = input.Substring(index, i - index + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
