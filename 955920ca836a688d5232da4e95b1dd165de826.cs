//Your program must perform a binary XOR on two binary numbers given through the standard input and print the result to the standard output.

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
        System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
        // string[] inputs = Console.ReadLine().Split(' ');
        string[] inputs = "001 011".Split(' ');
        string n1 = inputs[0];
        string n2 = inputs[1];


        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        // Console.WriteLine(encoding.GetBytes(n1));
        byte[] bytes = Encoding.ASCII.GetBytes(n1);
        string someString = Encoding.ASCII.GetString(bytes);
        Console.WriteLine(someString);

        Console.WriteLine("binary digits");
    }

    public string ToBinary(string stringPassed)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(stringPassed);
        string someString = Encoding.ASCII.GetString(bytes);
        return someString;
    }

}
