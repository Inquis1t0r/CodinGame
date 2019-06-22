using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;  
using System.Threading;  

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

S = textInfo.ToTitleCase(S); 
        Console.WriteLine(S);
    }
}
