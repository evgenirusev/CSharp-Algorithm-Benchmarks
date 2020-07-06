using System;
using System.Diagnostics;

namespace PerformanceTest
{
    class Program
    {
        static public void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int n = 10000000;

            // merge sort:
                // 1mil - 0.25
                // 10mil - about 2 sec

                // 16mil - 4.42 with numbers 1 to 10k
                // 16mil - 4.92 with numbers 1 to 1 mil
                // 16mil - 5.04 with numbers from 1 to 20 mil


            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 10000);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            mergeSort(arr, 0, n - 1);

            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
    }
}
