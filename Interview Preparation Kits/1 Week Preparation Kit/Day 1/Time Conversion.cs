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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        int hours = int.Parse(s.Substring(0,2));
        string ampm = s.Substring(8,2).ToLower();
        if(ampm == "am"){
            if(hours != 12){
                return s.Remove(8,2);   
            }
            else{
                return string.Format("00{0:s}",s.Substring(2,6));
            }
        }
        else {
            if(hours<12){
            hours += 12;
            return string.Format(hours+"{0:s}", s.Substring(2,6));
            }
            else{
                return s.Remove(8,2);
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
