/*
Goal
You are given an integer matrix of size N * M (a matrix is a 2D array of numbers).

A norm is a positive value meant to quantify the "size/length" of an element. In our case we want to compute the norm of a matrix.
There exist several norms, used for different scenarios.

Some of the most common matrix norms are :
- The norm 1: for each column of the matrix, compute the sum of the absolute values of every element in that column. The norm 1 is the maximum of these sums.
- The infinite norm: for each row of the matrix, compute the sum of the absolute values of every element in that row. The infinite norm is the maximum of these sums.
- The max norm: compute the maximum of the absolute values of every element in the matrix.

Given the matrix, print these three norms.
Input
N the number of rows
M the number of columns
Next N lines: the M values of each element in the row of the matrix
Output
A single line: N_1 N_INF N_MAX
With :
N_1 the norm 1 of the matrix
N_INF the infinite norm of the matrix
N_MAX the max norm of the matrix
Example
Input

2
2
0 1
1 0

Output

1 1 1


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
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                int read = int.Parse(inputs[j]);
            }
        }
    }
}
