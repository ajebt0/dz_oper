
//1
//
// using System;
//
// class Program
// {
//     static void Main()
//     {
//         string[] arr = { "кот", "дом", "арбуз", "лес" };
//
//         Array.Sort(arr, (a, b) =>
//             a[a.Length - 1].CompareTo(b[b.Length - 1]));
//
//         foreach (string s in arr)
//         {
//             Console.WriteLine(s);
//         }
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
//         string[] arr = { "10", "кот", "5", "hello", "20" };
//
//         int sum = 0;
//
//         foreach (string s in arr)
//         {
//             int number;
//
//             if (int.TryParse(s, out number))
//             {
//                 sum += number;
//             }
//         }
//
//         Console.WriteLine(sum);
//     }
// }



//3

using System;

class Program
{
    static bool IsPowerOfTwo(int n)
    {
        while (n > 1)
        {
            if (n % 2 != 0)
            {
                return false;
            }

            n /= 2;
        }

        return n == 1;
    }

    static void Main()
    {
        int number = 16;

        if (IsPowerOfTwo(number))
        {
            Console.WriteLine("Степень двойки");
        }
        else
        {
            Console.WriteLine("Не степень двойки");
        }
    }
}
