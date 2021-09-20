using System;

namespace RomanNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var loopVariable = true;
            
            while(loopVariable){
            Console.WriteLine("Please Enter Roman Numeral:");
            var Input = Console.ReadLine();
            Console.WriteLine($"Roman Numeral:{Input}");
            Console.WriteLine($"Integer Equivalent:{RomanParse.Translate(Input)}");
            loopVariable = false;
            }
           
           

            

        }
    }
}
