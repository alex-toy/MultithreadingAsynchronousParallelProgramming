namespace MultithreadingApp
{
    public static class MonitorThread
    {
        static object _lock =  new object();

        public static void CreateThreads()
        {
            Thread t1 = new Thread(Write);
            Thread t2 = new Thread(Read);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        public static void Write()
        {
            Monitor.Enter(_lock);
            for (int i = 0; i < 10; i++)
            {
                Monitor.Pulse(_lock);
                Console.WriteLine($"Write {i}");
                Monitor.Wait(_lock);
            }
        }

        public static void Read()
        {
            Monitor.Enter(_lock);
            for (int i = 0; i < 10; i++)
            {
                Monitor.Pulse(_lock);
                Console.WriteLine($"Read {i}");
                Monitor.Wait(_lock);
            }
        }
    }
}
