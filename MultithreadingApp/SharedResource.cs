using System.Diagnostics;

namespace MultithreadingApp
{
    public static class SharedResource
    {
        public static int sum = 0;
        public static object _lock = new object();

        public static void CreateThreads()
        {
            Console.WriteLine($"start");
            Stopwatch stopwatch = Stopwatch.StartNew();
            var t1 = new Thread(Addition);
            var t2 = new Thread(Addition);
            var t3 = new Thread(Addition);

            t1.Start(2);
            t3.Start(3);
            t2.Start(5);

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine($"sum = {sum}");

            stopwatch.Stop();

            Console.WriteLine($"total ticks = {stopwatch.ElapsedTicks}");
        }

        //public static void Addition(object count)
        //{
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        sum += (int)count;
        //        //Interlocked.Increment(ref sum);
        //        //lock (_lock)
        //        //{
        //        //    sum += (int)count;
        //        //}
        //    }
        //}

        //public static void Addition(object count)
        //{
        //    for (int i = 0; i < 50000; i++)
        //    {
        //        Monitor.Enter(_lock);
        //        try
        //        {
        //            sum += (int)count;
        //        }
        //        catch (Exception)
        //        {
        //            Monitor.Exit(_lock);
        //        }
        //    }
        //}

        public static void Addition(object count)
        {
            for (int i = 0; i < 50000; i++)
            {
                bool isLocked = false;
                Monitor.Enter(_lock, ref isLocked);
                try
                {
                    sum += (int)count;
                }
                catch (Exception)
                {
                    if (isLocked) Monitor.Exit(_lock);
                }
            }
        }
    }
}
