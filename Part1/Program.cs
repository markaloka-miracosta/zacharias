/// Homework 2		Part 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  September 12, 2020
///
/// Problem Statement: Create a program that, once given a first and last name,
/// creates a new string that contains your full name in pig latin with the
/// first letter capitalized for the first and last name.
/// 
/// 
/// Overall Plan:
/// 1) Declare first,last and result string variables.
/// 2) Select the first character of the string and move it to the end of the
///    string for both first and last.
/// 3) Capitalize the new first character of the first and last variables.
/// 4) Append the pig latin rule to the end of first and last.
/// 5) Create the pig latin name by joining the modified first and last variables.
/// 6) Print the pig latin name to the screen.
/// 

using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            String first, last, rule, pigLatin;

            first = "stephanie";
            last = "zacharias";
            rule = "ay";

            Console.WriteLine("My name is: " + first + " " + last);

            first = first.Substring(1) + first.Substring(0, 1);
            first = first.Substring(0, 1).ToUpper() + first.Substring(1);
            first = first + rule;

            last = last.Substring(1) + last.Substring(0, 1);
            last = last.Substring(0, 1).ToUpper() + last.Substring(1);
            last = last + rule;

            pigLatin = first + " " + last;
            Console.WriteLine("My pig latin name is: " + pigLatin);
        }
    }
}
