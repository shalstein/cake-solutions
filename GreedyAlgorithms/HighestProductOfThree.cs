static class HightProductOfThree
{
    public static int Find(int[] array_of_ints)
    {

        int lowest = Math.Min(array_of_ints[0], array_of_ints[1]);
        int highest = Math.Max(array_of_ints[0], array_of_ints[1]);

        int highestProductOfTwo = array_of_ints[0] * array_of_ints[1];
        int lowestProductOfTwo = array_of_ints[0] * array_of_ints[1];

        int highestProductOfThree = array_of_ints[0] * array_of_ints[1] * array_of_ints[2];

        for (int i = 2; i < array_of_ints.Length; i++)
        {

            highestProductOfThree = Math.Max(highestProductOfThree, Math.Max(highestProductOfTwo * array_of_ints[i], lowestProductOfTwo * array_of_ints[i]));
            highestProductOfTwo = Math.Max(highest * array_of_ints[i], Math.Max(highestProductOfTwo, array_of_ints[i] * lowest));
            highest = Math.Max(highest, array_of_ints[i]);
            lowest = Math.Min(lowest, array_of_ints[i]);
        }
        return highestProductOfThree;
    }
}