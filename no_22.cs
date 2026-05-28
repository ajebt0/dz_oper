using System;
using System.Linq;

public class HistogramArray
{
    private int[] _values;
    private int _intervals;
    private int _min;
    private int _max;
    private double _step;

    public HistogramArray(int[] values, int intervals)
    {
        _values = values.OrderBy(x => x).ToArray();
        _intervals = intervals;

        _min = _values.Min();
        _max = _values.Max();

        _step = (double)(_max - _min) / intervals;
    }

    public int Get(int value)
    {
        if (value <= _min)
            return 0;

        if (value >= _max)
            return _intervals - 1;

        int index = (int)((value - _min) / _step);

        return index;
    }

    public double Get(double percentile)
    {
        if (percentile < 0 || percentile > 100)
            throw new ArgumentException("Percentile должен быть от 0 до 100");

        double position = (_values.Length - 1) * percentile / 100.0;

        int left = (int)position;
        int right = left + 1;

        if (right >= _values.Length)
            return _values[left];

        double fraction = position - left;

        return _values[left] +
               (_values[right] - _values[left]) * fraction;
    }
}