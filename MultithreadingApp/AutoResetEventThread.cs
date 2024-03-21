namespace MultithreadingApp
{
    public class AutoResetEventThread
    {
        static AutoResetEvent _autoResetEvent = new AutoResetEvent(true);

        public static void CreateThreads()
        {
            for (int i = 0; i < 10; i++)
            {
                ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Write);
                var thread = new Thread(threadStart);
                thread.Start(i);
            }
        }

        public static void Write(object i)
        {
            Console.WriteLine($"Write {i}  waiting");
            _autoResetEvent.WaitOne();
            Console.WriteLine($"Write {i}  start");
            Thread.Sleep(5000);
            Console.WriteLine($"Write {i}  completed");
            _autoResetEvent.Set();
        }
    }
}
