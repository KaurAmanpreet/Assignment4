using System;
using System.Collections.Generic;

public class GenericValueType<T> where T : struct
{
    private List<T> items;

    public GenericValueType()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public T GetItem(int i)
    {
        if (i >= 0 && i < items.Count)
        {
            return items[i];
        }
        throw new Exception($"Item {i} is not found.");
    }

    public IEnumerable<T> GetSortedDescending()
    {
        return items.OrderByDescending(x => x);
    }
}