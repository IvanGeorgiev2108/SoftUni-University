using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Append("some cool text here. Very cool text.");
            text.Insert(0, "This is ");
            text.Replace("cool", "ugly");
            Console.WriteLine(text);
            Console.WriteLine(text.Length);
        }
    }
}
