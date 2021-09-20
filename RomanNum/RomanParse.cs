using System;
namespace RomanNum
{


    public class RomanParse{
        public static int Translate(string romanNum){

            int previous = default;
            int sum = default;
            int current = default;
            foreach(char letter in romanNum){
                switch (letter)
                { 
                    case 'I':
                        current = (int)RomanNums.I;
                        break;
                    case 'V':
                        current = (int)RomanNums.V;
                        break;
                    case 'X':
                        current = (int)RomanNums.X;
                        break;
                    case 'L':
                        current = (int)RomanNums.L;
                        break;
                    case 'C':
                        current = (int)RomanNums.C;
                        break;
                    case 'D':
                        current = (int)RomanNums.D;
                        break;
                    case 'M':
                        current = (int)RomanNums.M;
                        break;
                }
                if(current>previous){current -= previous*2;}
                sum += current;
                previous = current;
            }
           
            Console.WriteLine(sum);
            return sum;

        }
    }
}