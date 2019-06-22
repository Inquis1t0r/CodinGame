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
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int s1 = int.Parse(inputs[0]);
            int s2 = int.Parse(inputs[1]);
        if(s1 % s2 == 0)
        Console.WriteLine("Yes");
        else
        Console.WriteLine("No");
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

    }
}
