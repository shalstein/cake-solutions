class FindDuplicate
{
    static public int Find(int[] intsToFind)
    {
        int floor = 1;
        int ceiling = intsToFind.Length - 1;

        while (floor < ceiling)
        {

            int midpoint = (floor + ceiling) / 2;
            int lowerRangeFloor = floor;
            int lowerRangeCeiling = midpoint;
            int higherRangeFloor = midpoint + 1;
            int higherRangeCeiling = ceiling;

            int intsInLowerRange = intsToFind.Count(possibleMatch => possibleMatch >= lowerRangeFloor && possibleMatch <= lowerRangeCeiling);
            int possibleUniqueIntsInLowerRange = lowerRangeCeiling - lowerRangeFloor + 1;

            if (intsInLowerRange <= possibleUniqueIntsInLowerRange)
            {
                floor = higherRangeFloor;
                ceiling = higherRangeCeiling;
            }
            else
            {
                floor = lowerRangeFloor;
                ceiling = lowerRangeCeiling;
            }
        }


        return floor;
    }
}