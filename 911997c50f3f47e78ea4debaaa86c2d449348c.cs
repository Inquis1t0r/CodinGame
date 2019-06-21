using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {     
        string S = Console.ReadLine();
        int test = S.Length;
        
        if(test < 16)
        Console.WriteLine(S.Substring(0, 16));
        else
        Console.WriteLine(S);
    }
}
