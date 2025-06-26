using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начало диапазона (A):");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите конец диапазона (B):");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine("\nЧетные числа, кратные 5 (for):");
        for (int current = A; current <= B; current++)
        {
            if (current % 10 == 0)
            {
                Console.Write(current + " ");
            }
        }
    }
}