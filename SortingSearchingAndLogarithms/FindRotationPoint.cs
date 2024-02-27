static class FindRotationPoint
{
    public static int Find(string[] intsToFindRotation)
    {
        int leftIndex = 0;
        int rightIndex = intsToFindRotation.Length - 1;
        string firstWord = intsToFindRotation[0];
        while (leftIndex + 1 < rightIndex)
        {
            int midpoint = (leftIndex + rightIndex) / 2;
            if (string.Compare(intsToFindRotation[midpoint], firstWord, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                leftIndex = midpoint;
            }
            else
            {
                rightIndex = midpoint;
            }
            if (leftIndex + 1 == rightIndex)
            {

                break;
            }
        }
        return rightIndex;
    }
}