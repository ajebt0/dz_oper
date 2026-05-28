using System;

class Bank
{
    public int Money;

    public Bank(int money)
    {
        Money = money;
    }
}

class User : Bank
{
    public User(int money) : base(money)
    {
    }

    public void Send(User user, int sum)
    {
        if (Money >= sum)
        {
            Money -= sum;
            user.Money += sum;
        }
    }
}

class Program
{
    static void Main()
    {
        User u1 = new User(1000);
        User u2 = new User(500);

        u1.Send(u2, 200);

        Console.WriteLine(u1.Money);
        Console.WriteLine(u2.Money);
    }
}