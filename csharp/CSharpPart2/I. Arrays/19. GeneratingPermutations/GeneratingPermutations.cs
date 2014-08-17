using System;

class GeneratingPermutations
{
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            numbers[i] = i;
        }

        Console.WriteLine();
        Permute(1, n, numbers);
    }

    static void Permute(int left, int size, int[] nums)
    {
        int i, j, temp;

        if (left <= size)
        {

            for (i = left; i <= size; i++)
            {
                temp = nums[i];
                for (j = i; j > left; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[left] = temp;

                Permute(left + 1, size, nums);

                for (j = left; j < i; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[i] = temp;
            }
        }
        else
        {
            for (i = 1; i <= size; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
        }
    }
}

