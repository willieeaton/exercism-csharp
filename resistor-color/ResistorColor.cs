using System;
using System.Collections.Generic;

//Using generic C# collections now instead of arrays, thanks to help
//from mentor MarkusReynolds1989

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        if(Colors().Contains(color))
        {
            return Colors().IndexOf(color);
        }

        else
        {
            return -1; //error
        }
    }

    public static List<string> Colors() => new List<string> {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
}