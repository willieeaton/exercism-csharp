using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colorNames = {"black", "brown", "red", "orange",
            "yellow", "green", "blue", "violet", "grey", "white" };

        for (int i = 0; i < 10; i++)
        {
            if (color == colorNames[i])
                return i;
        }

        return -1; //error
    }


    public static string[] Colors() => new string[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
}