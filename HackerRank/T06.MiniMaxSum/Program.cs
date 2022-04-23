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
        
        long sum = 0;
        long sum1 = 0;
        int[] arr1 = arr.OrderBy(x => x).ToArray();    
        for (int i = 0; i < arr.Count-1; i++)
        {
            sum += arr1[i];
        }
        for (int i = arr.Count-1; i > 0; i--)
        {
            sum1 += arr1[i];
        }
        Console.WriteLine($"{sum} {sum1}");
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
