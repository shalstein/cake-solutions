class TopScore
{
    static public int[] Sort(int[] scores, int topScore)
    {

        int[] scoreArray = new int[topScore];
        int[] sortedScores = new int[scores.Length];
        int sortedScoreIndex = 0;

        foreach (int score in scores)
        {
            scoreArray[score - 1]++;
        }
        for (int i = 0; i < topScore; i++)
        {
            int scoreTimes = scoreArray[i];
            for (int j = 0; j < scoreTimes; j++)
            {
                sortedScores[sortedScoreIndex++] = i + 1;
            }
        }
        return sortedScores;
    }
}