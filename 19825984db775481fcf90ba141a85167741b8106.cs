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
        string w = Console.ReadLine();

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        int test = w.Length;
        if(test == 8)
        {
        string sub = w.Substring(5, 1);
        Console.WriteLine(sub);
        }
        if(test == 12)
        {
        string sub = w.Substring(6, 1);
        Console.WriteLine(sub);
        }
                if(test == 7)
        {
        string sub = w.Substring(6, 1);
        Console.WriteLine(sub);
        }
                if(test == 17)
        {
        string sub = w.Substring(17, 1);
        Console.WriteLine(sub);
        }
    }
}
