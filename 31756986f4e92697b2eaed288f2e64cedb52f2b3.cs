/*

 Goal
When you go out to dinner with your friends, everyone toasts with everyone else once. You wonder how often one glass bumps into another.
Input
An integer n indicating the number of guests
Output
An integer that indicates the number of times the glasses have been knocked together
Constraints
0 ≤ n ≤ 1000
Example
Input

2

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

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        //TODO:https://allagora.wordpress.com/2013/10/03/the-toast-formula/
        //result = Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item) / (Enumerable.Range(1, n - 2).Aggregate(1, (p, item) => p * item) * Enumerable.Range(1, 2).Aggregate(1, (p, item) => p * item));
        //Console.WriteLine(result);
             Console.WriteLine(Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item) / (Enumerable.Range(1, n - 2).Aggregate(1, (p, item) => p * item) * Enumerable.Range(1, 2).Aggregate(1, (p, item) => p * item)));

    }
}
