/*
Remove Spaces from a String from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-13

Given a string as input, output it without spaces. 

For example: 
string = "ab c  d e fgh i  j kl mn  opqr  stuvwxyz" 
result = "abcdefghijklmnopqrstuvwxyz" 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpacesFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "ab c  d e fgh i  j kl mn  opqr  stuvwxyz"; // Insert a string to remove spaces

            Console.WriteLine($"string = \"{input}\"");
            Console.WriteLine($"result = \"{input.Replace(" ", String.Empty)}\"");
        }
    }
}