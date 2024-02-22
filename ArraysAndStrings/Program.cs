﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] takeOut = [1, 3, 5];
        int[] dineIn = [2, 4, 6];
        int[] served = [1, 2, 6, 5, 4, 3];
        var c = CafeOrderChecker.Check(takeOut, dineIn, served);
        Console.WriteLine(c);
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