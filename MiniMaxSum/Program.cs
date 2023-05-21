using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void miniMaxSum(List<int> arr)
    {

        int min = int.MaxValue;

        int max = int.MinValue;

        long sum = 0;

        foreach (int num in arr)
        {
            sum += num;

            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"{sum - max} {sum - min}");

    }


}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);

    }
}
