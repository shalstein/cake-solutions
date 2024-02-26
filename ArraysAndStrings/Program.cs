﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] b = [10, 7, 11, 2, 3];
        int[] bb = [5, 3, 2, 1];
        int[] cc = [3, 1, 2, 5, 6, 4];
        var a = ProductOfOtherNumbers.Build(cc);
        Console.WriteLine(a);
    }

    public static List<int> CountingSort(List<int> arr)
    {
        int[] frequencyArray = new int[100];
        foreach (int integer in arr)
        {
            frequencyArray[integer]++;
        }
        return [.. frequencyArray];
    }

    private static int Lonelyinteger(List<int> a)
    {
        int result = -1;
        Dictionary<int, bool> foundInts = [];
        foreach (int integer in a)
        {
            if (!foundInts.TryAdd(integer, true))
            {
                foundInts[integer] = false;
            }
        }
        foreach (int key in foundInts.Keys)
        {
            if (foundInts[key])
            {
                result = key;
                break;
            }
        }
        return result;
    }
    public static int Xlonelyinteger(List<int> a)
    {
        a.Sort();
        for (int i = 1; i < a.Count - 1; i += 2)
        {
            if (a[i - 1] != a[i])
            {
                return a[i];
            }
        }
        return a.Last();
    }
}