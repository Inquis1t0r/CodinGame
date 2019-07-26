/*
You are an Archwizard defending your city from the last onslaught of ogres. You excel in casting massive explosion spells which can inflict apocalyptic damage. Unfortunately you only have enough mana to cast one explosion spell of size n*n. Given an m*m battleground littered with hordes of ogres, find greatest number of casualties you can devastate with a single explosion spell.

Even if there are no enemies to eradicate, you will still cast your explosion spell of maximum size because you simply love explosions too much.
Input
First line: one integer n which is the size of your explosion spell.
Next line: one integer m which is the size of the battleground.
Next m lines: the floor plan of the battleground, where '.' is empty space and 'x' is a horde of ogres.
Output
The maximum number of hordes you can destroy with one explosion spell.
Constraints
0<p,n,m<=10
Example
Input

1
2
x.
.x

Output

1

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
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string battleground = Console.ReadLine();
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("number of orcs killed");
    }
}
