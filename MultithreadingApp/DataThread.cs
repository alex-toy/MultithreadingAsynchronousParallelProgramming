namespace MultithreadingApp
{
    public class DataThread
    {
        public static void CreateThreads()
        {
            NumberHelper numberHelper = new NumberHelper(10);
            var thread = new Thread(numberHelper.ShowNumbers);
            thread.Start();
        }
    }
}
