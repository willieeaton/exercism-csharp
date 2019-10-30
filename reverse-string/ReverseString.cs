using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputAsArray = input.ToCharArray();
        string output = "";

        foreach (char element in inputAsArray)
        {
            output = element + output;
        }

        return output;
    }
}