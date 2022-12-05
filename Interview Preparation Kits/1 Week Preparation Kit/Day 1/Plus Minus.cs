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
        double zeroes = 0;
        double negatives = 0;
        double positives = 0;
        foreach(int value in arr){
            if(value<0){
                negatives+=1;
            }
            else if(value == 0){
                zeroes+=1;
            }
            else{
                positives+=1;
            }
        }
        Console.WriteLine( (positives/arr.Count()).ToString("N6"));
        Console.WriteLine( (negatives/arr.Count()).ToString("N6"));
        Console.WriteLine( (zeroes/arr.Count()).ToString("N6"));
    }

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
