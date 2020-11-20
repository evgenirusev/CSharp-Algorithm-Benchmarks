using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp4
{
    class MultithreadingPerformanceTest
    {
        static void Main(string[] args)
        {
            var prog = new MultithreadingPerformanceTest();

            Thread thread1 = new Thread(() => x.DoWork("1"));
            Thread thread2 = new Thread(() => x.DoWork("2"));
            Thread thread3 = new Thread(() => x.DoWork("3"));
            Thread thread4 = new Thread(() => x.DoWork("4"));
            Thread thread5 = new Thread(() => x.DoWork("5"));
            Thread thread6 = new Thread(() => x.DoWork("6"));
            Thread thread7 = new Thread(() => x.DoWork("7"));
            Thread thread8 = new Thread(() => x.DoWork("8"));
            Thread thread9 = new Thread(() => x.DoWork("9"));
            Thread thread10 = new Thread(() => x.DoWork("10"));
            Thread thread11 = new Thread(() => x.DoWork("11"));
            Thread thread12 = new Thread(() => x.DoWork("12"));
            Thread thread13 = new Thread(() => x.DoWork("13"));
            Thread thread14 = new Thread(() => x.DoWork("14"));
            Thread thread15 = new Thread(() => x.DoWork("15"));
            Thread thread16 = new Thread(() => x.DoWork("16"));
            Thread thread17 = new Thread(() => x.DoWork("17"));
            Thread thread18 = new Thread(() => x.DoWork("18"));
            Thread thread19 = new Thread(() => x.DoWork("19"));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();
            thread9.Start();
            thread10.Start();
            thread11.Start();
            thread12.Start();
            thread13.Start();
            thread14.Start();
            thread15.Start();
            thread16.Start();
            thread17.Start();
            thread18.Start();
            thread19.Start();
        }

        private void DoWork(string threadNumber)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // ARTITRARY WORK
            int a = 0;
            for (int i = 1; i < 2100000000; i++)
            {
                a++;
            }

            sw.Stop();
            Console.WriteLine(threadNumber + "<---- DoWork()={0}", sw.Elapsed);
        }
    }
}
