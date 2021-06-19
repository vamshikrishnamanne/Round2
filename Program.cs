using System;

namespace PrimeFinder
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            var n = long.Parse(Console.ReadLine());

            PrimeFinder p = new PrimeFinder();
            DateTime t0 = DateTime.Now;
            bool result = p.isPrime(n);
            DateTime t1 = DateTime.Now;
            Console.WriteLine(n + " is prime ? " + result);
            Console.WriteLine("isPrime method runtime is  "+ t1.Subtract(t0).Milliseconds+ " Milliseconds");
            t0 = DateTime.Now;
            result = p.isPrimeConsideringSqrt(n);
            t1 = DateTime.Now;
            Console.WriteLine(n + " is prime ? " + result);
            Console.WriteLine("isPrimeConsideringSqrt method runtime is " + t1.Subtract(t0).Milliseconds + " Milliseconds");
            t0 = DateTime.Now;
            result= p.isPrimeConsideringSqrtEliminatingEvenNumbers(n);
            t1 = DateTime.Now;
            Console.WriteLine(n + " is prime ? " + result);
            Console.WriteLine("isPrimeConsideringSqrtEliminatingEvenNumbers method runtime is " + t1.Subtract(t0).Milliseconds + " Milliseconds");
        }
    }
}