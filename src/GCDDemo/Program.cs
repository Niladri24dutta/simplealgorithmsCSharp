using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCDDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long number1 = 0;
            Console.WriteLine("Enter first number");
            var num1 = Console.ReadLine();
            long.TryParse(num1, out number1);
            long number2 = 0;
            Console.WriteLine("Enter second number");
            var num2 = Console.ReadLine();
            long.TryParse(num2, out number2);
            if(number1 < number2)
            {
                Console.WriteLine("first number should be greater");
                Console.ReadKey();
            }
            else
            {
                var result = GenerateGCD(number1, number2);
                Console.WriteLine($"the GCD of {number1} and {number2} is {result}");
                Console.ReadKey();
            }
        }

        private static long GenerateGCD(long num1,long num2)
        {
            while(num2 != 0)
            {
                var remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }

            return num1;
        }
    }
}
