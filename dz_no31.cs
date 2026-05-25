using System;
using System.Collections.Generic;

public class Validator<T>
{
    private readonly List<Predicate<T>> _rules = new();

    public void AddRule(Predicate<T> rule)
    {
        _rules.Add(rule);
    }

    public bool Validate(T item)
    {
        foreach (var rule in _rules)
        {
            if (!rule(item))
                return false;
        }
        return true;
    }
}