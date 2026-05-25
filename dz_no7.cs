using System;
using System.Linq;

class Program
{
    // 1. Сортировка по последней букве
    static void SortByLastLetter(string[] arr)
    {
        var sorted = arr.OrderBy(word => word[word.Length - 1]);

        Console.WriteLine("Сортировка по последней букве:");

        foreach (string word in sorted)
        {
            Console.WriteLine(word);
        }
    }

    // 2. Сумма чисел из string массива
    static int SumNumbers(string[] arr)
    {
        int sum = 0;

        foreach (string item in arr)
        {
            int number;

            if (int.TryParse(item, out number))
            {
                sum += number;
            }
        }

        return sum;
    }

    // 3. Проверка степени двойки
    static bool IsPowerOfTwo(int number)
    {
        if (number <= 0)
            return false;

        while (number % 2 == 0)
        {
            number /= 2;
        }

        return number == 1;
    }

    static void Main()
    {
        // 1. Сортировка массива строк
        string[] words = { "кот", "дом", "яблоко", "нос", "мир" };

        SortByLastLetter(words);

        // 2. Сумма чисел из string массива
        string[] mixed = { "10", "кот", "25", "дом", "5" };

        int sum = SumNumbers(mixed);

        Console.WriteLine("\nСумма чисел = " + sum);

        // 3. Проверка степени двойки
        Console.Write("\nВведите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPowerOfTwo(number))
            Console.WriteLine("Число является степенью двойки");
        else
            Console.WriteLine("Число не является степенью двойки");
    }
}