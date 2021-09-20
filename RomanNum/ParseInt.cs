namespace RomanNum
{




   public class ParseInt{



       public static string  Translate(int inputNumber){
            //1000,900,500,400,100,90,50,40,10,9,5,4,1
            //"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"


            //MMXXI to 2021
            int diff = inputNumber;
            string outPut =  "";
            while(diff != 0){
                if(diff>999){
                    outPut = outPut + "M";
                    diff -=1000;
                    
                }else if(diff>899){
                    outPut = outPut + "CM";
                    diff -= 900;
                }else if(diff>499){
                    outPut = outPut + "D";
                    diff -= 500;
                }else if(diff>399){
                    outPut = outPut + "CD";
                    diff -= 400;
                }else if(diff>99){
                    outPut = outPut + "C";
                    diff -= 100;
                }else if(diff>89){
                    outPut = outPut + "XC";
                    diff -= 90;
                }else if(diff>49){
                    outPut = outPut + "L";
                    diff -= 50;
                }else if(diff>39){
                    outPut = outPut + "XL";
                    diff -= 40;
                }else if(diff>9){
                    outPut = outPut + "X";
                    diff -= 10;
                }else if(diff>8){
                    outPut = outPut + "IX";
                    diff -= 9;
                }else if(diff>4){
                    outPut = outPut + "V";
                    diff -= 5;
                }else if(diff>3){
                    outPut = outPut + "IV";
                    diff -= 4;
                }else{
                    outPut = outPut + "I";
                    diff -= 1;
                }
           }
        

            return outPut;
       }

   } 
}