namespace MultithreadingApp
{
    public static class ThreadConstructors
    {
        public static void CreateThreads()
        {
            //ThreadStart threadStart = new ThreadStart(ShowNumbers);
            //ThreadStart threadStart = ShowNumbers;
            //ThreadStart threadStart = delegate () { ShowNumbers(); };
            ThreadStart threadStart = () => ShowNumbers();

            var thread = new Thread(threadStart);
            thread.Start();
        }

        public static void ShowNumbers()
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"ShowNumbers : {i}");
            }
        }
    }
}
