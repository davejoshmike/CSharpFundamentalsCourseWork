using System;

namespace CSharpFundamentalsCourse.FizzBuzz 
{
    /// <summary>
    /// Here are the FizzBuzz rules that you need to implement in your code project:
    ///   Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
    ///   When the current value is divisible by 3, print the term Fizz next to the number.
    ///   When the current value is divisible by 5, print the term Buzz next to the number.
    ///   When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
    /// </summary>
    public class FizzBuzz
    {
        public static void Main(string[] args)
        {
            DetermineFizzBuzz();
        }

        public static void DetermineFizzBuzz()
        {
            // initialize variables
            for (int i = 1; i <= 100; i++){
                Console.Write(i);
                if (i % 3 == 0){
                    Console.Write($"Fizz");
                }
                if(i % 5 == 0){
                    Console.Write("Buzz");
                }
                // if (i %3 ==0 && i%5==0){
                    // Console.Write("FizzBuzz");                    
                // }

                Console.WriteLine("");
            }            
        }
    }
}