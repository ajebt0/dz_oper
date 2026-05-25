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

            // Проверка длины
            bool lengthCheck = password.Length == 5;

            // Проверка количества цифр
            int digitCount = password.Count(char.IsDigit);
            bool digitCheck = digitCount == 3;

            // Проверка спецсимволов
            int specialCount = password.Count(c => !char.IsLetterOrDigit(c));
            bool specialCheck = specialCount == 1;

            if (lengthCheck && digitCheck && specialCheck)
            {
                Console.WriteLine("Пароль подходит!");
                break;
            }
            else
            {
                Console.WriteLine("Неверный пароль.");
                Console.WriteLine("Условия:");
                Console.WriteLine("- 5 символов");
                Console.WriteLine("- 3 цифры");
                Console.WriteLine("- 1 спецсимвол");
                Console.WriteLine("Попробуйте снова.\n");
            }
        }
    }
}