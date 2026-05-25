using System;

class Program
{
    // 1. Расстояние между точками
    static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // 2. Сумма цифр числа
    static int SumDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    // 3. Генератор массива случайных чисел
    static int[] GenerateArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(min, max + 1);
        }

        return arr;
    }

    static void Main()
    {
        // 1. Расстояние между точками
        Console.WriteLine("=== Расстояние между точками ===");

        Console.Write("Введите x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double result = Distance(x1, y1, x2, y2);

        Console.WriteLine($"Расстояние = {result}");

        // 2. Сумма цифр
        Console.WriteLine("\n=== Сумма цифр числа ===");

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сумма цифр = {SumDigits(number)}");

        // 3. Генератор массива
        Console.WriteLine("\n=== Генератор массива ===");

        Console.Write("Введите количество элементов: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите минимальное число: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите максимальное число: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[] array = GenerateArray(size, min, max);

        Console.WriteLine("Массив:");

        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}