using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException();

        int aliquot = 0;

        for(int i = 1; i < number; i++)
        {
            if (number % i == 0)
                aliquot += i;
        }

        if (number > aliquot)
            return Classification.Deficient;
        else if (aliquot > number)
            return Classification.Abundant;
        else
            return Classification.Perfect;
    }
}
