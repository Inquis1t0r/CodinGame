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
        while (true) {
     string dices = Console.ReadLine();
    if (dices == null) break;

        if (dices.Contains("1 2 3 4") || dices.Contains("2 3 4 5") || dices.Contains("3 4 5 6"))
        Console.WriteLine("true");
        else
        Console.WriteLine("false");
        }
        
    }
}
