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

class Solution {

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) {
        int swapCount = 0;
        for(int i=0;i<arr.Count();i++){
            if(arr[i]!=i+1){
                int unorderedNum = arr[i];
                arr[i] = arr[unorderedNum-1];
                arr[unorderedNum-1] = unorderedNum;
                if(arr[i] != i+1){
                    i--;
                }
                swapCount++;
                // for(int j=i+1;j<arr.Count();j++){
                //     if(arr[j]==i+1){
                //       int unorderedNum = arr[i];
                //       arr[i] = arr[j];
                //       arr[j] = unorderedNum;  
                //       swapCount++;
                //       break;
                //     }
                // }
            }
        }
        return swapCount;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
