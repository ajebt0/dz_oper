using System;
using System.Linq;

class HistogramArray
{
    private double[] data;
    private int intervals;
    private double min;
    private double max;
    private double intervalSize;

    public HistogramArray(double[] array, int intervalCount)
    {
        data = array.OrderBy(x => x).ToArray();

        intervals = intervalCount;

        min = data.Min();
        max = data.Max();

        intervalSize = (max - min) / intervals;
    }

    // Возвращает индекс интервала для значения
    public int GetInterval(double value)
    {
        if (value < min || value > max)
            return -1;

        int index = (int)((value - min) / intervalSize);

        // Для максимального значения
        if (index == intervals)
            index--;

        return index;
    }

    // Возвращает значение по процентилю
    public double GetPercentile(double percentile)
    {
        if (percentile < 0 || percentile > 100)
            throw new ArgumentException("Процентиль должен быть от 0 до 100");

        double position = (percentile / 100.0) * (data.Length - 1);

        int left = (int)Math.Floor(position);
        int right = (int)Math.Ceiling(position);

        if (left == right)
            return data[left];

        double fraction = position - left;

        return data[left] + (data[right] - data[left]) * fraction;
    }
}

class Program
{
    static void Main()
    {
        double[] numbers =
        {
            10, 15, 22, 30, 35,
            40, 45, 50, 60, 70
        };

        HistogramArray histogram = new HistogramArray(numbers, 5);

        double value = 34;

        Console.WriteLine(
            $"Число {value} находится в интервале: " +
            histogram.GetInterval(value)
        );

        Console.WriteLine(
            $"50 процентиль: {histogram.GetPercentile(50)}"
        );

        Console.WriteLine(
            $"90 процентиль: {histogram.GetPercentile(90)}"
        );
    }
}