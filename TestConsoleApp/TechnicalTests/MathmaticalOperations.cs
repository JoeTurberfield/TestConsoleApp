using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.TechnicalTests
{
    public class MathmaticalOperations
    {
        public void FizzPopBuzz()
        {
            for (int i = 0; i < 101; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine("Pop");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ShowPrimeNumbers()
        {
            // Prime number is only divisible by itselft and 1.
            //
            // Example Prime Number:
            // 5
            // (1, 5)
            // 1*5, 5*1
            //
            // Example Compositie (Non-prime):
            // 8
            // (1, 8, 2, 4)
            // 1*8, 8*1, 2*4, 4*2

            // Start at 2 as prime numbers 

            
            int divisors = 0;
            bool isPrime = true;// Assume prime is true.

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        // Not prime.
                        // Has
                        isPrime = false;
                    }
                }
            }
        }
    }
}
