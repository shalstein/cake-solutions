class InPlaceShuffle
{
    static public int[] Shuffle(int[] intsToShuffle)
    {
        var randomGenerator = new Random();
        for (int i = 0; i < intsToShuffle.Length - 1; i++)
        {
            int indexToShuffle = randomGenerator.Next(i, intsToShuffle.Length - 1);
            (intsToShuffle[i], intsToShuffle[indexToShuffle]) = (intsToShuffle[indexToShuffle], intsToShuffle[i]);
        }
        return intsToShuffle;

    }
}