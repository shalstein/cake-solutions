static class WordCloud
{
    static bool IsCharacter(char charToCheck)
    {
        char[] validChars = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
        return Array.IndexOf(validChars, charToCheck) > -1;
    }
    public static Dictionary<string, int> Count(string inputString)
    {
        Dictionary<string, int> wordCount = [];
        int wordStart = -1;
        int characterCount = 0;
        for (int i = 0; i < inputString.Length; i++)
        {
            if (IsCharacter(inputString[i]))
            {
                characterCount++;
                if (characterCount == 0)
                {
                    wordStart = i;
                }
                if (i == inputString.Length - 1)
                {
                    string word = inputString.Substring(wordStart, characterCount);
                    wordCount.TryGetValue(word, out int wordCountValue);
                    wordCount[word] = wordCountValue++;
                }
            }
            else
            {
                string word = inputString.Substring(wordStart, characterCount);
                wordCount.TryGetValue(word, out int wordCountValue);
                wordCount[word] = wordCountValue++;
                characterCount = 0;
                wordStart = i + 1;
            }
        }
        return wordCount;
    }

    static private void AddToDictionary(string stringToLookIn)
    {

    }

}