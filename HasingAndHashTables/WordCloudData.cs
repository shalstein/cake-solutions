public class WordCloudData
{
    public Dictionary<string, int> WordsToCounts { get; }

    public WordCloudData(string inputString)
    {
        WordsToCounts = [];
        PopulateWordsToCounts(inputString);
    }

    private void PopulateWordsToCounts(string inputString)
    {
        int currentWordStartIndex = 0;
        int currentWordLength = 0;

        for (int index = 0; index < inputString.Length; index++)
        {
            char character = inputString[index];

            if (index == inputString.Length - 1)
            {
                if (Letter(character))
                {
                    currentWordLength++;
                }

                if (currentWordLength > 0)
                {
                    string currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                    AddWordToDictionary(currentWord);
                }
            }
            else if (character == ' ' || character == '\u2014')
            {
                if (currentWordLength > 0)
                {
                    string currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                    AddWordToDictionary(currentWord);
                    currentWordLength = 0;
                }
            }
            else if (character == '.')
            {
                if (index < inputString.Length - 1 && inputString[index + 1] == '.')
                {
                    if (currentWordLength > 0)
                    {
                        string currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                        AddWordToDictionary(currentWord);
                        currentWordLength = 0;
                    }
                }
            }
            else if (Letter(character) || character == '\'')
            {
                if (currentWordLength == 0)
                {
                    currentWordStartIndex = index;
                }
                currentWordLength++;
            }
            else if (character == '-')
            {
                if (index > 0 && Letter(inputString[index - 1]) && Letter(inputString[index + 1]))
                {
                    if (currentWordLength == 0)
                    {
                        currentWordStartIndex = index;
                    }
                    currentWordLength++;
                }
                else
                {
                    if (currentWordLength > 0)
                    {
                        string currentWord = inputString.Substring(currentWordStartIndex, currentWordLength);
                        AddWordToDictionary(currentWord);
                        currentWordLength = 0;
                    }
                }
            }
        }
    }

    private void AddWordToDictionary(string word)
    {
        word = word.ToLower();

        if (WordsToCounts.ContainsKey(word))
        {
            WordsToCounts[word]++;
        }
        else if (WordsToCounts.ContainsKey(word.ToLower()))
        {
            WordsToCounts[word.ToLower()]++;
        }
        else if (WordsToCounts.ContainsKey(word.ToUpper()))
        {
            WordsToCounts[word] = 1;
            WordsToCounts[word] += WordsToCounts[word.ToUpper()];
            WordsToCounts.Remove(word.ToUpper());
        }
        else
        {
            WordsToCounts[word] = 1;
        }
    }

    private bool Letter(char character)
    {
        return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(character);
    }
}
