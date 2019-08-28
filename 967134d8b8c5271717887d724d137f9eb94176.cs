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
        //Console.WriteLine(result);
        int temp = 0;
        for(int j = n; j > 0; j--)
        {
            result = result.Insert(temp, "+");
            result = result.Remove(j);
            //Console.WriteLine(j);
            Console.WriteLine(result);
            temp++;
        }

    }
}
