// CustomList.cs
using System;

public class CustomList<T>
{
    private T[] items;
    private int count;

    public CustomList() : this(10) { }

    public CustomList(int initialSize)
    {
        items = new T[initialSize];
    }

    public void Add(T item)
    {
        CheckIntegrity();
        items[count++] = item;
    }

    public void AddAtIndex(T item, int index)
    {
        CheckIntegrity();
        if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index));
        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
        items[index] = item;
        count++;
    }

    public bool Remove(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Equals(item))
            {
                for (int j = i; j < count - 1; j++)
                {
                    items[j] = items[j + 1];
                }
                count--;
                return true;
            }
        }
        return false;
    }

    private void CheckIntegrity()
    {
        if (count >= 0.8 * items.Length)
        {
            T[] largerArray = new T[items.Length * 2];
            Array.Copy(items, largerArray, count);
            items = largerArray;
        }
    }

    public T GetItem(int index)
    {
        if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));
        return items[index];
    }

    public int Count => count;
}
