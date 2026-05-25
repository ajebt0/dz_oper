using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Массив из 50 слов
        string[] words =
        {
            "кот", "ток", "нос", "сон", "дом", "мир", "ром",
            "лист", "стол", "сорт", "торс", "парк", "карп",
            "лама", "мама", "рама", "гора", "рога", "банан",
            "арбуз", "машина", "книга", "ручка", "окно", "дверь",
            "река", "озеро", "море", "город", "дерево", "трава",
            "цветок", "яблоко", "груша", "слива", "вишня", "персик",
            "школа", "универ", "студент", "учитель", "тетрадь",
            "карандаш", "телефон", "компьютер", "мышка", "клавиатура",
            "монитор", "программа", "интернет"
        };

        // 1. Проверка слова
        Console.Write("Введите слово: ");
        string input = Console.ReadLine();

        if (words.Contains(input))
            Console.WriteLine("Слово есть в массиве");
        else
            Console.WriteLine("Слова нет в массиве");

        // 2. Поиск анаграмм
        Console.WriteLine("\nАнаграммы:");

        string sortedInput = String.Concat(input.OrderBy(c => c));

        foreach (string word in words)
        {
            string sortedWord = String.Concat(word.OrderBy(c => c));

            if (sortedInput == sortedWord && input != word)
            {
                Console.WriteLine(word);
            }
        }

        // 3. Сортировка по последней букве
        Console.WriteLine("\nСортировка по последней букве:");

        var sortedWords = words.OrderBy(w => w[w.Length - 1]);

        foreach (string word in sortedWords)
        {
            Console.WriteLine(word);
        }
    }
}