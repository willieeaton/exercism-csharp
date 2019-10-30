using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool containsAllLetters = true;
        char[] comparator = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        //Build an array of every character in the alphabet, to iterate through

        for (int i = 0; i < 26; i++)
        {
            if (!input.ToLower().Contains(comparator[i]))
            {
                containsAllLetters = false;
            }
        }
        return containsAllLetters; 
    }
}
