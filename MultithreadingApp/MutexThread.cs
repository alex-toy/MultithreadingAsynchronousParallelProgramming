namespace MultithreadingApp
{
    public class MutexThread
    {
        static Mutex _mutex = new Mutex();

        public static void CreateThreads()
        {
            for (int i = 0; i < 10; i++)
            {
                ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Write);
                var thread = new Thread(threadStart);
                thread.Start(i);
            }

            Thread.Sleep(4000);
            _mutex.ReleaseMutex();
        }

        public static void Write(object i)
        {
            Console.WriteLine($"Write {i}  waiting");
            _mutex.WaitOne();
            Console.WriteLine($"Write {i}  start");
            Thread.Sleep(5000);
            Console.WriteLine($"Write {i}  completed");
            _mutex.ReleaseMutex();
        }
    }
}
