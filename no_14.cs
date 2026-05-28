using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string password;

        while (true)
        {
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            int numbers = 0;
            int special = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    numbers++;

                else if (!char.IsLetter(c))
                    special++;
            }

            if (password.Length == 5 &&
                numbers >= 3 &&
                special >= 1)
            {
                Console.WriteLine("Пароль подходит");
                break;
            }
            else
            {
                Console.WriteLine("Неверный пароль, попробуйте еще раз");
            }
        }
    }
}