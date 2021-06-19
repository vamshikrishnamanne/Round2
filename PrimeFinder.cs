using System;
using System.Linq;

namespace PrimeFinder
{


    public class PrimeFinder
    {
        public  bool isPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public  bool isPrimeConsideringSqrt(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (long i = 2; i < Math.Floor(Math.Sqrt(number)) + 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public  bool isPrimeConsideringSqrtEliminatingEvenNumbers(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number > 2 && number % 2 == 0)
            {
                return false;
            }
            for (long i = 3; i < Math.Floor(Math.Sqrt(number)) + 1; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}