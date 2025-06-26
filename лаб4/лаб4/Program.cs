using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество моделей велосипедов:");
        int count = int.Parse(Console.ReadLine());

        List<decimal> prices = new List<decimal>();
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите цену велосипеда #{i + 1}:");
            prices.Add(decimal.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Введите ваш бюджет:");
        decimal budget = decimal.Parse(Console.ReadLine());

        var affordable = prices.Where(p => p <= budget).OrderBy(p => p).ToList();

        if (affordable.Any())
        {
            Console.WriteLine($"\nДоступно {affordable.Count} вариантов:");
            foreach (var price in affordable)
            {
                Console.WriteLine($"- {price} руб.");
            }
            Console.WriteLine($"\nРекомендуем: {affordable.Max()} руб.");
        }
        else
        {
            Console.WriteLine("Нет доступных вариантов.");
            Console.WriteLine($"Минимальная цена в магазине: {prices.Min()} руб.");
        }
    }
}