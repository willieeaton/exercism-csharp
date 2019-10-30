using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        bool allLettersUnique = true;
        char[] wordLetters = word.ToLower().ToCharArray();
        char[] comparator = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        int matches;

        for (int i = 0; i < 26; i++)
        {
            matches = 0;
            for (int j = 0; j < wordLetters.Length; j++)
            {
                if (wordLetters[j] == comparator[i])
                    matches++;
            }

            if (matches > 1)
            {
                allLettersUnique = false;
            }

        }

        return allLettersUnique;
    }
}
