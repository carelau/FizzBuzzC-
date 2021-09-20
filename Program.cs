using System;

namespace FizzBuzz
{
    class Program
    {
        static string Fizz (int num, string output){
            if (num % 3 == 0){
                output += "Fizz";
                }
                return output;
            }
            static string Fezz (int num, string output){
            if (num % 13 == 0){
                output += "Fezz";
                }
                return output;
            }

        static string Buzz (int num, string output){
            if (num % 5 == 0){
                output += "Buzz";
            }
                return output;
            }  

         static string Bang (int num, string output){
            if (num % 7 == 0){
                output += "Bang";
            }
                return output;
            }    
        static string Bong (int num, string output){
            if (num % 11 == 0 && num % 13 ==0){
                output += "Bong";
            } else if (num % 11 ==0){
                output = "Bong";
            }
                return output;
            }                 
      
        static void Main (string[] args)
        {
            for(int i=1; i <=195; i++)
            {

                string output = "";
                output = Fizz (i, output);
                output = Fezz (i, output);
                output = Buzz (i, output);
                output = Bang (i, output);
                output = Bong (i, output);
                Console.WriteLine (output == "" ? i : output);
            }
        }
    }
}

