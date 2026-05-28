
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] arr =
        {
            "кот", "дом", "арбуз", "лес", "окно"
        };

        var sorted = arr.OrderBy(x => x);

        foreach (var s in sorted)
        {
            Console.WriteLine(s);
        }
    }
}