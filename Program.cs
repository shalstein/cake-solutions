internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = [3, 7, 9];
        int[] b = [1, 10, 15];
        int[] myArray = [3, 4, 6, 10, 11, 15];
        int[] alicesArray = [1, 5, 8, 12, 14, 19];
        var c = MergeSortedArrays.Merge(myArray, alicesArray);
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