using System;
using System.Runtime.ConstrainedExecution;
namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            primeNumbers();
        }
        static void primeNumbers()
        {
            
            int counter = 0;
            int firstPrime = 2;
            
            while(counter < 10)
            {
                if(isPrime(firstPrime))
                {
                    Console.Write(firstPrime);
                    counter++;
                    if (counter < 10)
                    {
                        Console.Write(", ");
                    }
                }
                firstPrime++;
            }
        }
        static bool isPrime(int num)
        {
            if(num < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
