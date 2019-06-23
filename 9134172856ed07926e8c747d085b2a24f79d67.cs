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
        string s = Console.ReadLine();
        var arr = s.ToCharArray();
        float sum = 0;
        var n = ASCIIEncoding.ASCII.GetBytes(s);
        for (int i = 0; i < s.Length; i++){ sum +=n[i]; }
        Console.WriteLine((sum/s.Length).ToString("N1"));
    }
}
