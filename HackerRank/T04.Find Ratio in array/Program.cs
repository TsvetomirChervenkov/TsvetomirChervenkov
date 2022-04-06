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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int counter = 0;
        int counterPlus = 0;
        int counterMinus = 0;
        int counterNull = 0;

        foreach (var num in arr)
        {
            if (num > 0)
            {
                counterPlus++;
            }
            else if (num < 0)
            {
                counterMinus++;
            }
            else
            {
                counterNull++;
            }
            counter++;
        }
        decimal result1 = (decimal)counterPlus / counter;
        decimal result2 = (decimal)counterMinus / counter;
        decimal result3 = (decimal)counterNull / counter;

        Console.WriteLine($"{result1:f6}");
        Console.WriteLine($"{result2:f6}");
        Console.WriteLine($"{result3:f6}");

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}
