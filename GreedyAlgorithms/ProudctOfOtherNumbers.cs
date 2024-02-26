static class ProductOfOtherNumbers
{

    public static int[] Build(int[] arrayOfInts)
    {
        int[] results = new int[arrayOfInts.Length];
        results[0] = 1;
        for (int i = 1; i < arrayOfInts.Length; i++)
        {
            results[i] = results[i - 1] * arrayOfInts[i - 1];
        }
        int productSoFar = 1;
        for (int i = arrayOfInts.Length - 1; i >= 0; i--)
        {
            results[i] *= productSoFar;
            productSoFar *= arrayOfInts[i];
            Console.WriteLine(productSoFar);
        }
        return results;

    }

}