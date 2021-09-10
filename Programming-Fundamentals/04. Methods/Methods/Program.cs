using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            print(10, 50);
            print(10);
            print(b: 50);
            print();
            print(n: 10, b: 50);


        }
        static void print(int n = 10, int b = 50)
        {
            // 10 -- 50
            Console.WriteLine($"{n} -- {b}");
        }
       
    }
    


}






