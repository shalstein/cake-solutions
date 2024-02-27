internal class Program
{
    private static void Main(string[] args)
    {
        int[] b = [10, 7, 11, 2, 3];
        int[] bb = [5, 3, 2, 1];
        int[] cc = [1, 7, 2, 3, 4, 5, 6, 7, 8, 9];
        var c = FindDuplicate.Find(cc);
        Console.WriteLine(c);
    }

}
