using System;

class TrianglePrinter
{
    static void Main()
    {
        Console.Write("Введите высоту треугольника: ");
        if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
        {
            for (int i = 1; i <= height; i++)
            {
                // Печать пробелов
                Console.Write(new string(' ', height - i));
                // Печать чисел
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }
    }
}
