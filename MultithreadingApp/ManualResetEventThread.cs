namespace MultithreadingApp
{
    public class ManualResetEventThread
    {
        static ManualResetEvent _manualResetEvent = new ManualResetEvent(false);

        public static void CreateThreads()
        {
            Thread t1 = new Thread(Write);
            t1.Start();

            for (int i = 0; i < 10; i++)
            {
                ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Read);
                var thread = new Thread(threadStart);
                thread.Start(i);
            }
        }

        public static void Write()
        {
            Console.WriteLine($"Write start");
            _manualResetEvent.Reset();
            Thread.Sleep(5000);
            Console.WriteLine($"Write completed");
            _manualResetEvent.Set();
        }

        public static void Read(object i)
        {
            Console.WriteLine($"Read {i} waiting");
            _manualResetEvent.WaitOne();
            Console.WriteLine($"Read {i} completed");
        }
    }
}
