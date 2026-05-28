//1

// using System;
//
// class Program
// {
//     static void Main()
//     {
//         string[] arr =
//         {
//             "кот","дом","лес","окно","арбуз",
//             "река","море","гора","поле","луна",
//             "свет","ночь","день","лист","трава",
//             "снег","дождь","ветер","камень","песок",
//             "город","улица","машина","дорога","мост",
//             "школа","книга","ручка","тетрадь","стол",
//             "стул","окно","дверь","комната","кухня",
//             "яблоко","груша","слива","банан","виноград",
//             "часы","телефон","компьютер","мышь","экран",
//             "код","язык","метод","класс","объект"
//         };
//
//         string word = Console.ReadLine();
//
//         bool found = false;
//
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] == word)
//             {
//                 found = true;
//                 break;
//             }
//         }
//
//         Console.WriteLine(found);
//     }
// }

// //2 
//
// using System;
//
// class Program
// {
//     static void Main()
//     {
//         string[] arr =
//         {
//             "кот","ток","кто","дом","мод","мед","дем"
//         };
//
//         string word = Console.ReadLine();
//
//         char[] a = word.ToCharArray();
//         Array.Sort(a);
//         string sorted = new string(a);
//
//         for (int i = 0; i < arr.Length; i++)
//         {
//             char[] b = arr[i].ToCharArray();
//             Array.Sort(b);
//
//             if (sorted == new string(b))
//             {
//                 Console.WriteLine(arr[i]);
//             }
//         }
//     }
// }


//3

using System;

class Program
{
    static void Main()
    {
        string[] arr =
        {
            "кот","дом","лес","арбуз","река","море","гора"
        };

        Array.Sort(arr, (a, b) =>
            a[a.Length - 1].CompareTo(b[b.Length - 1]));

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}