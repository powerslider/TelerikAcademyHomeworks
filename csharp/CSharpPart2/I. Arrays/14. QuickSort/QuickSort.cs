using System;

class QuickSort
{
    static void Main()
    {
        int[] array = { 1, 5, 89, 999, 37, -6, 42 };

        QSort(0, array.Length - 1, array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public static void QSort(int left, int right, int[] a)
    {
        int pivot, l, r;

        pivot = a[left];
        l = left;
        r = right;

        while (left < right)
        {
            while ((a[right] >= pivot) && (left < right))
            {
                right--;
            }

            if (left != right)
            {
                a[left] = a[right];
                left++;
            }

            while ((a[left] <= pivot) && (left < right))
            {
                left++;
            }

            if (left != right)
            {
                a[right] = a[left];
                right--;
            }
        }

        a[left] = pivot;
        pivot = left;
        left = l;
        right = r;

        if (left < pivot)
        {
            QSort(left, pivot - 1, a);
        }

        if (right > pivot)
        {
            QSort(pivot + 1, right, a);
        }
    }
}

