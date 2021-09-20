using System;

namespace RomanNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var loopVariable = true;
            int numInput = default;
            while(loopVariable){
            Console.WriteLine("Please Enter Roman Numeral or Number to be translated or press enter to exit program:");
            var Input = Console.ReadLine();
            if(Input == ""){loopVariable = false;}
            if(int.TryParse(Input,out numInput)){
                Console.WriteLine($"Integer:{Input}");
                Console.WriteLine($"Roman Numeral Equivalent:{ParseInt.Translate(numInput)}");
                

            }else{
                Console.WriteLine($"Roman Numeral:{Input}");
                Console.WriteLine($"Integer Equivalent:{RomanParse.Translate(Input)}");
                
            }
            }
           
           

            

        }
    }
}
