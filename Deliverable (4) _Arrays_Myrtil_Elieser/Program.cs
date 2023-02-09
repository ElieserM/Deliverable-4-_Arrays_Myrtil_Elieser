/*
 * Author: Elieser Myrtil
 * Date: 02/08/2023
 * The program is responsible for outputing a fibonacci sequence without using user input.
 */

using System;

namespace Deliverable__4___Arrays_Myrtil_Elieser
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 25;

            int[] fibonacci = new int[s];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < s; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Fibonacci number(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}