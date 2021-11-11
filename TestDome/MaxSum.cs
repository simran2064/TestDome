using System;
using System.Collections.Generic;

public class MaxSum
{
    public static int FindMaxSum(List<int> list)
    {
        int first = 0;
        int second = 0;

        for (int i = 0; i < list.Count; i++)
        {
            int current = list[i];
            if (first < current)
            {
                second = first;
                first = current;
            }
            else if (second < current)
            {
                second = current;
            }
        }
        return (first + second);
    }

    public static void Main(string[] args)
    {
        List<int> list = new List<int> { 5, 9, 7, 11 };
        Console.WriteLine(FindMaxSum(list));
    }
}
}