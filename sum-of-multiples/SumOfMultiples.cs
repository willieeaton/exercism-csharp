using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int answer = 0;
        for (int i = 1; i < max; i++)
        {
            bool isMultiple = false; 
            foreach (int element in multiples)
            {
                if (element > 0)
                    if (i % element == 0)
                        isMultiple = true;
            }

            if (isMultiple)
                answer += i;
        }

        return answer;
    }
}