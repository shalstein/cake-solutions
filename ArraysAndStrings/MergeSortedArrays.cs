static class MergeSortedArrays
{
    public static int[] Merge(int[] array1, int[] array2)
    {
        var merged = new int[array1.Length + array2.Length];
        var array1index = 0;
        var array2index = 0;
        var mergedIndex = 0;
        while (array1index < array1.Length || array2index < array2.Length)
        {
            if (array1index < array1.Length && (array2index >= array2.Length || array1[array1index] < array2[array2index]))
            {
                merged[mergedIndex] = array1[array1index];
                array1index++;
            }
            else
            {
                merged[mergedIndex] = array2[array2index];
                array2index++;
            }
            mergedIndex++;
        }
        return merged;
    }
}