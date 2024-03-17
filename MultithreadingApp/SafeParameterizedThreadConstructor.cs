namespace MultithreadingApp
{
    public class SafeParameterizedThreadConstructor
    {
        private readonly NumberHelper _helper;

        public SafeParameterizedThreadConstructor(NumberHelper nh)
        {
            _helper = nh;
        }

        public void CreateThreads()
        {
            ThreadStart threadStart = new ThreadStart(_helper.ShowNumbers);
            var thread = new Thread(threadStart);
            thread.Start();
        }
    }
}
