using System;

class Program
{
    static void Main()
    {
     
        Console.WriteLine("Таймер:");

        TimerHelper.DoAfter(() =>
        {
            Console.WriteLine("Прошло 3 секунды");
        }, 3);

        Console.WriteLine();

        Console.WriteLine("Будильник:");

        AlarmClock alarm = new AlarmClock();

        alarm.AlarmRang += () =>
        {
            Console.WriteLine("Будильник сработал!");
        };

        DateTime time = DateTime.Now.AddSeconds(5);

        Console.WriteLine(
            "Будильник установлен на: " +
            time.ToLongTimeString()
        );

        alarm.SetAlarm(time);

        alarm.Start();
    }
}
