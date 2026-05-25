using System;

// Родительский класс
class Exchange
{
    // Метод информации о курсе
    public void ShowRate(string from, string to, double rate)
    {
        Console.WriteLine($"Курс {from} -> {to} = {rate}");
    }
}

// Дочерние классы валют
class USD : Exchange
{
    public void Info()
    {
        ShowRate("USD", "RUB", 89.5);
    }
}

class RUB : Exchange
{
    public void Info()
    {
        ShowRate("RUB", "EUR", 0.011);
    }
}

class EUR : Exchange
{
    public void Info()
    {
        ShowRate("EUR", "USD", 1.08);
    }
}

class UAN : Exchange
{
    public void Info()
    {
        ShowRate("UAN", "USD", 0.14);
    }
}

class Peso : Exchange
{
    public void Info()
    {
        ShowRate("Peso", "USD", 0.056);
    }
}

class Program
{
    static void Main()
    {
        USD usd = new USD();
        RUB rub = new RUB();
        EUR eur = new EUR();
        UAN uan = new UAN();
        Peso peso = new Peso();

        usd.Info();
        rub.Info();
        eur.Info();
        uan.Info();
        peso.Info();
    }
}