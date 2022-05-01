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

    public static string timeConversion(string s)
    {

        string[] split = s.Split(':');
        string f = split[2].Substring(2);
        split[2] = split[2].Substring(0, 2);
        
        if(f == "PM"){
            int hour = int.Parse(split[0]);
            split[0] = hour >= 1 && hour <= 11? (hour + 12).ToString() : split[0];
        }
        else{
            int hour = int.Parse(split[0]);
            split[0] = hour == 12? "00" : split[0];
        }
        return string.Join(":", split);
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