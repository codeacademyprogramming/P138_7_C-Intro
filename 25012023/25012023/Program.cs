using System;

namespace _25012023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCount = 0;
            int num = 7919;

            bool isPrime = true;
            for(var i=2; i*i<=num; i++)
            {
                loopCount++;

                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(isPrime == true)
                Console.WriteLine("Sadedir");
            else
                Console.WriteLine("Murekkebdir");


            Console.WriteLine(loopCount);
        }
    }
}
