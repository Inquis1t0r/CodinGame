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
        float diag = float.Parse(Console.ReadLine());
        string ratio = Console.ReadLine();

        //float diag = 65;
        //string ratio = "16:9";
        int[] ratioTab = ratio.Split(':').Select(n => Convert.ToInt32(n)).ToArray();
        float ratioCalc = (float)ratioTab[0] / ratioTab[1];

        float height = diag / (float)Math.Sqrt((ratioCalc * ratioCalc) + 1);
        float width = ratioCalc * height;

        Console.WriteLine(width.ToString("0.00") + " x " + height.ToString("0.00"));

    }
}
