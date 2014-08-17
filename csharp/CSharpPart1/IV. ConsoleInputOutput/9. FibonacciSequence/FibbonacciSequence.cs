using System;

class FibbonacciSequence
{
    static ulong Fib(int n)
    {
        int fib1 = 0;
        int fib2 = 1;
        int temp;

        for (int i = 0; i < n; i++)
		{
            temp = fib1;
            fib1 = fib2;
            fib2 = temp + fib2;
		}
        return (ulong)fib1;
    }

    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.Write("{0}, ", Fib(i));
        }
    }

}