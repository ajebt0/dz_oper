// //1
//
// using System;
//
// class Program
// {
//     static double Distance(double x1, double y1, double x2, double y2)
//     {
//         return Math.Sqrt((x2 - x1) * (x2 - x1) +
//                          (y2 - y1) * (y2 - y1));
//     }
//
//     static void Main()
//     {
//         Console.Write("x1: ");
//         double x1 = Convert.ToDouble(Console.ReadLine());
//
//         Console.Write("y1: ");
//         double y1 = Convert.ToDouble(Console.ReadLine());
//
//         Console.Write("x2: ");
//         double x2 = Convert.ToDouble(Console.ReadLine());
//
//         Console.Write("y2: ");
//         double y2 = Convert.ToDouble(Console.ReadLine());
//
//         Console.WriteLine(Distance(x1, y1, x2, y2));
//     }
// }
//


// //2
//
// using System;
//
// class Program
// {
//     static int Sum(int n)
//     {
//         int sum = 0;
//
//         while (n > 0)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//
//         return sum;
//     }
//
//     static void Main()
//     {
//         int n = Convert.ToInt32(Console.ReadLine());
//
//         Console.WriteLine(Sum(n));
//     }
// }
//


//3
using System;

class Program
{
    static void CreateArray(int size, int min, int max)
    {
        Random r = new Random();

        for (int i = 0; i < size; i++)
        {
            Console.Write(r.Next(min, max + 1) + " ");
        }
    }

    static void Main()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());

        CreateArray(size, min, max);
    }
}
