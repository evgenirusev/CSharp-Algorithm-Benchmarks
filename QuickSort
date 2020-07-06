using System;
using System.Diagnostics;

namespace PerformanceTest
{
    class Program
    {
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int n = 40000000;

            // quick sort:
                // 1mil -> 


            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 10000);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            Quick_Sort(arr, 0, n - 1);

            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
    }
}
