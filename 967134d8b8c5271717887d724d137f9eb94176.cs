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
        int n = int.Parse(Console.ReadLine());

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i < n+1; i++)
        {
            sb.Append(i);
        }
        String result = sb.ToString();
        for(int j = 0; j < n; j++)
        {
            result = result.Insert(j, "+");
            Console.WriteLine(result);
            result = result.Remove(result.Length - 1);
        }

    }
}
