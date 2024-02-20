using System.IO.Compression;

class ReverseStringInPlace
{
    public static void Reverse(char[] stringToReverse)
    {
        for (int i = 0; i < stringToReverse.Length / 2; i++)
        {
            (stringToReverse[^(1 + i)], stringToReverse[i]) = (stringToReverse[i], stringToReverse[^(i + 1)]);
        }
    }
}