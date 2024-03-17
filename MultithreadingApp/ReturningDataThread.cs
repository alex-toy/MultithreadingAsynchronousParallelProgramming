namespace MultithreadingApp
{
    public class ReturningDataThread
    {
        private readonly ReturnNumberHelper _helper;

        public delegate int SumOfNumbers(int sum);

        public ReturningDataThread(ReturnNumberHelper nh)
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
