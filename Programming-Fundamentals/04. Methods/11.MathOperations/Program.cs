using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double n2 = double.Parse(Console.ReadLine());

            double result = MathOperations(n1, @operator, n2);
            Console.WriteLine(result);
        }
        static double MathOperations(double n1, string @operator, double n2) // / * + -
        {
            double result = 0;
            switch (@operator)
            {
                case "/":
                    result = n1 / n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
            }
            return result;
        }
    }
}
