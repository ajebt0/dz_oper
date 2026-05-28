using System;
using System.IO;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();

        string[] files =
        {
            "1.txt",
            "2.txt",
            "3.txt"
        };

        bool found = false;

        for (int i = 0; i < files.Length; i++)
        {
            if (File.Exists(files[i]))
            {
                string text = File.ReadAllText(files[i]);

                if (text.Contains(word))
                {
                    found = true;
                    break;
                }
            }
        }

        Console.WriteLine(found);
    }
}