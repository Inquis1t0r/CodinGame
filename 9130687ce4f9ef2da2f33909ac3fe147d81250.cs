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
        if(n == 1)
        Console.WriteLine('#');
           else
           {       
                
           Console.WriteLine(new string('#', n)); 
    
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("#" + new string(' ', n - 2) + "#");
            }
    
            Console.WriteLine(new string('#', n));
           }
    }
}
