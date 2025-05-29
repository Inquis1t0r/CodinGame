/**

A contribution by InJustice
Approved by micheldore , aimcreeper and GFLP10
 Goal
There is a car in the left lane that needs to merge into the right lane. The car cannot safely change lanes if any of the following are true:

1. There is another car directly to the right that is traveling the same speed
2. There is a car ahead and to the right that is traveling slower
3. There is a car behind and to the right that is traveling faster 


Input
Three rows of two-character strings indicating the location and speed of the cars.
| indicates no car is present.
An integer between 1 and 9 inclusive indicates a car traveling at that speed.
Traffic is moving upwards; in other words, the top row indicates the front of the traffic and the bottom row indicates the back of the traffic.

Example:

|3
2|
|1

Output
true if the car can safely change lanes, false otherwise.
Constraints
1 ≤ all speeds ≤ 9
Example
Input

||
1|
||

Output

t
**/


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
        for (int i = 0; i < 3; i++)
        {
            string line = Console.ReadLine();
        }
    }
}
