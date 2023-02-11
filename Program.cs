﻿namespace ActualDate
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowActualDate();
        }

        public static void ShowActualDate()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"Hour: {date.ToString("hh:mm tt")}");
            Console.WriteLine($"Year: {date.Year}");
            Console.WriteLine($"Month:{date.Month}");
            Console.WriteLine($"Day: {date.Day}");

            Console.ReadLine();
        }
    }
}
