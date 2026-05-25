using System;
using System.Threading;

public class AlarmClock
{
    public event Action AlarmRang;

    private DateTime alarmTime;

    public void SetAlarm(DateTime time)
    {
        alarmTime = time;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine(
                "Текущее время: " +
                DateTime.Now.ToLongTimeString()
            );

            if (DateTime.Now >= alarmTime)
            {
                AlarmRang?.Invoke();
                break;
            }

            Thread.Sleep(1000);
        }
    }
}