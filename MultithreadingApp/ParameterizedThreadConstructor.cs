namespace MultithreadingApp
{
    public static class ParameterizedThreadConstructor
    {
        public static void CreateThreads()
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ShowNumbers);
            var thread = new Thread(threadStart);
            int numberCount = 6;
            thread.Start(numberCount);
        }

        public static void ShowNumbers(object count)
        {
            for (int i = 0; i < Convert.ToInt32(count); i++)
            {
                Console.WriteLine($"ShowNumbers : {i}");
            }
        }
    }
}
