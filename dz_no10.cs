using System;

// Родительский класс
class BankAccount
{
    public string Owner { get; set; }
    public double Balance { get; set; }

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    // Метод перевода денег
    public void Transfer(BankAccount target, double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Некорректная сумма");
            return;
        }

        if (Balance >= amount)
        {
            Balance -= amount;
            target.Balance += amount;

            Console.WriteLine($"Перевод {amount} выполнен");
        }
        else
        {
            Console.WriteLine("Недостаточно средств");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Owner}: {Balance}");
    }
}

// Дочерний класс
class UserAccount : BankAccount
{
    public string CardNumber { get; set; }

    public UserAccount(string owner, double balance, string cardNumber)
        : base(owner, balance)
    {
        CardNumber = cardNumber;
    }
}

class Program
{
    static void Main()
    {
        // Создаем счета
        UserAccount user1 = new UserAccount("Иван", 1000, "1111");
        UserAccount user2 = new UserAccount("Анна", 500, "2222");

        Console.WriteLine("До перевода:");
        user1.ShowInfo();
        user2.ShowInfo();

        Console.Write("\nВведите сумму перевода: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        // Перевод
        user1.Transfer(user2, amount);

        Console.WriteLine("\nПосле перевода:");
        user1.ShowInfo();
        user2.ShowInfo();
    }
}