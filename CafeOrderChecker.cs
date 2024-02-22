static class CafeOrderChecker
{
    static public bool Check(int[] takeOutOrder, int[] dineInOrder, int[] served)
    {
        int takOutIndex = 0;
        int dineInIndex = 0;
        int servedIndex = 0;

        if (takeOutOrder.Length + dineInOrder.Length != served.Length)
        {
            return false;
        }
        while (takOutIndex < takeOutOrder.Length || dineInIndex < dineInOrder.Length)
        {
            if (takOutIndex < takeOutOrder.Length && takeOutOrder[takOutIndex] == served[servedIndex])
            {
                takOutIndex++;

            }
            else if (dineInIndex < dineInOrder.Length && dineInOrder[dineInIndex] == served[servedIndex])
            {
                dineInIndex++;
            }
            else
            {
                return false;
            }
            servedIndex++;
        }
        return true;

    }
}