/*
The program:
Your program must determine in which category belongs a given integer. The possible integers are named intervals that are also given.
The intervals do not overlap.
The integer always belongs to a category.

INPUT:
Line 1: X the integer to categorize.
Line 2: N an integer for the number of categories.
Next N lines: Two integers F and T for the inclusive bounds of the interval, followed by a word category, its name.

OUTPUT:
The name of the category with the interval that contains X.

CONSTRAINTS:
0 < N < 100
-1000 ≤ F ≤ T ≤ 1000
F ≤ X ≤ T

EXAMPLE:
Input
10
3
-1000 -1 negative
0 0 null
1 1000 positive
Output
positive
 

*/

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
        int X = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int F = int.Parse(inputs[0]);
            int T = int.Parse(inputs[1]);
            string category = inputs[2];
        }
    }
}
