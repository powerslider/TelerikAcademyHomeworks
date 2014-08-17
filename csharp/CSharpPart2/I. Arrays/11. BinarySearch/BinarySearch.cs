using System;

class BinarySearch
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
            
        int[] arrayOfInts = { 1, 5, 10, 14, 42, 96, 845, 987, 1542, 1652, 4568, 8745, 
                                9689, 15423, 18452, 19687, 20365, 45265, 65234, 98712 };
        int leftBound, rightBound, middle;

            if (arrayOfInts.Length > 0)
            {
                leftBound = 0;
                rightBound = arrayOfInts.Length - 1;
                middle = rightBound / 2;

                while(true)
                {
                    if (num == arrayOfInts[leftBound])
                    {
                        Console.WriteLine(leftBound);
                        break;
                    }
                    else if (num == arrayOfInts[rightBound])
                    {
                        Console.WriteLine(rightBound);
                        break;
                    }
                    else if (num == arrayOfInts[middle])
                    {
                        Console.WriteLine(middle);
                        break;
                    }
                    else if (num > arrayOfInts[middle])
                    {
                        if ((leftBound = middle + 1) < rightBound)
                        {
                            middle = (rightBound + leftBound) / 2;
                        }
                        else
                        {
                            Console.WriteLine("No such element in the array!");
                            break;
                        }
                    }
                    else
                    {
                        if ((rightBound = middle - 1) > leftBound)
                        {
                            middle = (rightBound + leftBound) / 2;
                        }
                        else
                        {
                            Console.WriteLine("No such element in the array!");
                            break;
                        }
                    }
                    if (rightBound == leftBound)
                    {
                        Console.WriteLine("No such element in the array!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Empty array!");
            }
        }
}

