using System;
using System.Numerics;

class SumOfNMembersOfFibonacciSeq
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        
        BigInteger fib1 = 0;
        BigInteger fib2 = 1;
        BigInteger temp;
        BigInteger sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            temp = fib1;
            fib1 = fib2;
            fib2 += temp;

            sum += temp;
        }
        Console.WriteLine("\nThe sum of the first {0} members of the Fibonacci sequence is {1}.\n", n, sum);
    }  
}

