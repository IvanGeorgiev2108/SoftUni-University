using System;
using System.Collections.Generic;
namespace Lists._16._06._2021
{
    class Program
    {
        static void Main(string[] args)
        {


            //   string[] names = new string[n]; // масиви
            //     names[i] = name;   // масиви
            List<string> names = new List<string>();  // листове!
            names.Add("Ivan");
            names.Add("Ivo");
            names.Add("Mitko");

            names.Insert(2, "test");
            Console.WriteLine(names.Contains("test")); // true , дали садържа !

            Console.WriteLine(string.Join(" ", names));

            List<string> name = new List<string>();  // листове!
            names.Add("CCC");
            names.Add("BBB");
            names.Add("AAA");

            names.Sort(); // сортиране по азбучен ред!

            Console.WriteLine(string.Join(" ", name));


        }
    }
}
