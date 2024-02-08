namespace MultithreadingApp
{
    public static class RetrieveDataThread
    {
        public static void DisplaySumOfNum(int sum)
        {
            Console.WriteLine($"The sum of numbers is {sum}");
        }

        public static void CreateThreads()
        {
            NumberCalculator numberHelper = new NumberCalculator(10, DisplaySumOfNum);
            var thread = new Thread(numberHelper.ShowNumbers);
            thread.Start();
        }
    }
}
