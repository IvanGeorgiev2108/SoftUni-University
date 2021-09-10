using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] days = new string[7];

            //days[0] = "Monday";
            //days[1] = "Tuesday";
            //days[2] = "Wednesday";
            //days[3] = "Thursday";
            //days[4] = "Friday";
            //days[5] = "Saturday";
            //days[6] = "Sunday";
            //Console.WriteLine(days[6]);
            // по съкратен начин

            int days = int.Parse(Console.ReadLine());
            string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday"};
            if (days < 1 || days > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[days - 1]);
            }

            //Console.WriteLine(daysOfWeek.Length); ;
            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine(daysOfWeek[i]);
            //}


        }
    }
}
