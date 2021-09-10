using System;

namespace PrintFirstNNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                //  array[i] = i + 1; без това връща десет 0!
                array[i] = i + 1;
                Console.WriteLine(array[i]);
            }
        }
    }
}
