using System;

class Exchange
{
    public void Info(string from, string to, double rate)
    {
        Console.WriteLine(from + " -> " + to + " = " + rate);
    }
}

class USD : Exchange
{
    public void Show()
    {
        Info("USD", "RUB", 90);
    }
}

class RUB : Exchange
{
    public void Show()
    {
        Info("RUB", "USD", 0.011);
    }
}

class EUR : Exchange
{
    public void Show()
    {
        Info("EUR", "RUB", 100);
    }
}

class UAH : Exchange
{
    public void Show()
    {
        Info("UAH", "RUB", 2.3);
    }
}

class Peso : Exchange
{
    public void Show()
    {
        Info("Peso", "USD", 0.06);
    }
}

class Program
{
    static void Main()
    {
        USD u = new USD();
        RUB r = new RUB();
        EUR e = new EUR();
        UAH ua = new UAH();
        Peso p = new Peso();

        u.Show();
        r.Show();
        e.Show();
        ua.Show();
        p.Show();
    }
}