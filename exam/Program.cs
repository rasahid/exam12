using System;
using System.Collections.Generic;
using System.Linq;

public class ValueContainer<T> where T : struct
{
    private List<T> values = new List<T>();

    public void AddItem(T item)
    {
        values.Add(item);
    }

    public T GetItem(int index)
    {
        if (index >= 0 && index < values.Count)
        {
            return values[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
    }

    public List<T> GetSortedDescending()
    {
        return values.OrderByDescending(x => x).ToList();
    }
}

class Program
{
    static void Main()
    {
        ValueContainer<int> intContainer = new ValueContainer<int>();

        intContainer.AddItem(10);
        intContainer.AddItem(1);
        intContainer.AddItem(75);

        Console.WriteLine("Original Collection:");
        foreach (var item in intContainer.GetSortedDescending())
        {
            Console.WriteLine(item);
        }
    }
}
