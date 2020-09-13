/// Homework 2		Part 2
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  September 12, 2020
///
/// Problem Statement: Create a program that converts degrees Farenheit to
/// Celsius.
/// 
/// 
/// Overall Plan:
/// 1) Declare degreesC and degreesF int variables.
/// 2) Prompt the user to enter a whole number as a temperature in Farenheit,
///    store this number as degreesF.
/// 3) Define degreesC to have the provided formula.
/// 4) Print the equivalent temperature in Celsius to the screen.
/// 

using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreesF; // we only want to accept whole number values 
            decimal degreesC; // we want to ouput a number with 1 decimal place

            Console.Write("Please enter a temperature in degrees Farenheit " +
                "using a whole number: ");
            degreesF = Convert.ToInt32(Console.ReadLine());

            // use type casting to change the degreesF from type int to a usable
            // decimal type to allow the proper rounding to take place 
            degreesC = (5 * ((decimal)degreesF - 32)) / 9;

            degreesC = Math.Round(degreesC, 1);

            Console.WriteLine("The equivalent temperature to " + degreesF +
              " degrees Farenheit is " + degreesC + " degrees Celsius.");

            Console.ReadKey();

        }
    }
}
