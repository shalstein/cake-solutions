﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<List<int>> meetingTimes = [[1, 5], [2, 4]];
        int[,] xmeetingTimesArray = { { 1, 5 }, { 2, 4 } };
        int[,] meetingTimesArray = {
            { 0, 1 },
            { 3, 5 },
            { 4, 8 },
            { 10, 12 },
            { 9, 10 }
        };
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