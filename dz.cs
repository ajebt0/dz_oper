//using System;
//
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string text = Console.ReadLine();
//        
//        if (text.Contains("a"))
//        {
//            Console.WriteLine("В строке есть буква 'a'");
//        }
//        else
//        {
//            Console.WriteLine("В строке нет буквы 'a'");
//        }
//    }
//}

// ЗАДАНИЕ 2
//using System;
//
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите первую строку: ");
//        string str1 = Console.ReadLine();
//        
//        Console.Write("Введите вторую строку: ");
//        string str2 = Console.ReadLine();
//        
//        // Приводим обе строки к нижнему регистру и сравниваем
//        if (str1.ToLower() == str2.ToLower())
//        {
//            Console.WriteLine("Строки одинаковые");
//        }
//        else
//        {
//            Console.WriteLine("Строки разные");
//        }
//    }
//}


// ЗАДАНИЕ 3

// using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string text = Console.ReadLine();
//        
//        for (int i = 0; i < text.Length; i++)
//        {
//            Console.WriteLine(text[i]);
//        }
//    }
//}



//ЗАДАНИЕ 4



using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string text = Console.ReadLine();
//        
//        // Чётные символы это: 2-й, 4-й, 6-й и т.д.
//        // В программировании отсчёт с 0, поэтому:
//        // 1-й символ - индекс 0 (нечётный)
//        // 2-й символ - индекс 1 (чётный)
//        // 3-й символ - индекс 2 (нечётный)
//        // 4-й символ - индекс 3 (чётный)
//        
//        Console.WriteLine("Чётные символы:");
//        for (int i = 1; i < text.Length; i += 2)
//        {
//            Console.Write(text[i] + " ");
//        }
//    }
//}



