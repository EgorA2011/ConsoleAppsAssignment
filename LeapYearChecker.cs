using System;

class LeapYearChecker
{
    static void Main(string[] args)
    {
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} - високосный год.");
        }
        else
        {
            Console.WriteLine($"{year} - не високосный год.");
        }
    }
}
