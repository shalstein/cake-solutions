static class PermutationHasPalindrome
{
    public static bool Check(string theString)
    {
        var oddCharacters = new HashSet<char>();
        foreach (char aCharacter in theString)
        {
            if (!oddCharacters.Remove(aCharacter))
            {
                oddCharacters.Add(aCharacter);
            }
        }
        return oddCharacters.Count <= 1;
    }
}