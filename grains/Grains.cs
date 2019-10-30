using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException();

        ulong grains = 1;
        for (int i = 1; i < n; i++)
            grains *= 2;

        return grains;
    }

    public static ulong Total()
    {
        ulong grains = 0;
        for (int i = 1; i <= 64; i++)
            grains += Square(i);

        return grains;
    }
}