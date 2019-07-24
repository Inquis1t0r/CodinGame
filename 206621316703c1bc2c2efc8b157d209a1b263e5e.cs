using System;
using System.Linq;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        Console.WriteLine(s.Count(f => f == 'A') + " " + s.Count(f => f == 'C') + " " + s.Count(f => f == 'G') + " " +  s.Count(f => f == 'T'));
    }
}
