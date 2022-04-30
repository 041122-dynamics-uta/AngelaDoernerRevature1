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

    // Complete the catAndMouse function below.
static void Main(String[] args) 
{
    int q = Convert.ToInt32(Console.ReadLine());
    
        for(int a0 = 0; a0 < q; a0++)
        {
            string[] tokens_x = Console.ReadLine().Split(' ');
            
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int z = Convert.ToInt32(tokens_x[2]);
            
            if (Math.Abs(z - x) == Math.Abs(z - y))
            {
                Console.WriteLine("Mouse C");
            }
            if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                Console.WriteLine("Cat A");
            }
            if (Math.Abs(z - x) > Math.Abs(z - y))
            {
                Console.WriteLine("Cat B");
            }
        }
    }
}
