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
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        string s = "absdiuoc";
                                
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string WORD = Console.ReadLine();
            var output = string.Concat(WORD.ToCharArray()
                .OrderBy(c => c)
                .GroupBy(d => vowels.Contains(d))
                .OrderBy(g => !g.Key)
                .SelectMany(g => g));
            Console.WriteLine(output[0]);
        }


        
    }
}
