using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
class Solution
{
  static void Main(string[] args){
    Console.WriteLine((Console.ReadLine().ToString().Distinct().Count())-1);
  }
}
