static class InflightEnertainment
{
    public static bool IsTwoMoviesFillFlight(int flightTime, int[] movieLengths)
    {
        var lengthsHash = new HashSet<int>();
        foreach (int movieLength in movieLengths)
        {
            int remainingTime = flightTime - movieLength;
            if (lengthsHash.TryGetValue(remainingTime, out int _))
            {
                return true;
            }
            else
            {
                lengthsHash.Add(movieLength);
            }
        }
        return false;

    }
}