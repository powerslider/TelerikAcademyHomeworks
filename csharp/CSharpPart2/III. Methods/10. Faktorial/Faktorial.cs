using System;

    class Faktorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] factorial = new int[1000];
            int position;

            factorial = Factorial(n, out position);

            for (int i = position; i >= 0; i--)
            {
                Console.Write(factorial[i]);
            }
            Console.WriteLine();
        }

        static int[] Factorial(int n, out int position)
        {
            int[] result = new int[10000];
            result[0] = 1;
            int carry = 0;
            position = 0;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j <= position; j++)
                {
                    result[j] *= i;
                    if (result[position] > 9)
                    {
                        if (position > 0)
                        {
                            int temp = result[position] + result[position - 1] / 10;
                            while ((temp /= 10) > 0)
                            {
                                position++;
                            }
                        }
                        else
                        {
                            position++;
                        }
                    }
                }
                for (int j = 0; j <= position; j++)
                {
                    carry = (result[j] / 10) % 1000;
                    result[j] %= 10;
                    result[j + 1] += carry;
                    if (position > 1 && result[position - 1] + result[position] > 100)
                    {
                        position++;
                    }
                }
            }
            return result;
        }        
}
