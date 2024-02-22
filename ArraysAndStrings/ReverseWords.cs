static class ReverseWords
{
    public static char[] ReverseCharacters(char[] characters, int start, int end)
    {
        int leftIndex = start;
        int rightIndex = end;
        while (leftIndex < rightIndex)
        {
            (characters[leftIndex], characters[rightIndex]) = (characters[rightIndex], characters[leftIndex]);
            leftIndex++;
            rightIndex--;
        }
        return characters;
    }

    public static char[] Words(char[] characters)
    {
        ReverseCharacters(characters, 0, characters.Length - 1);

        int currentWordStart = 0;
        for (int i = 0; i <= characters.Length; i++)
        {
            if (i == characters.Length || characters[i] == ' ')
            {
                ReverseCharacters(characters, currentWordStart, i - 1);
                currentWordStart = i + 1;
            }
        }
        return characters;
    }
}