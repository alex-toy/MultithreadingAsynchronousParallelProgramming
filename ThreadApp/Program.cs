using MultithreadingApp;

namespace ThreadApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetMainThread();

            //SingleThreaded.RunAll();

            //MultiThreaded.RunAll();

            //ThreadConstructors.CreateThreads();

            //ParameterizedThreadConstructor.CreateThreads();

            //DataThread.CreateThreads();

            //RetrieveDataThread.CreateThreads();

            //ParameterizedThreadConstructor.CreateThreads();

            //NumberHelper numberHelper = new NumberHelper(6);
            //var sptc = new SafeParameterizedThreadConstructor(numberHelper);
            //sptc.CreateThreads();

            //var numberHelper = new ReturnNumberHelper(6, sum => { Console.WriteLine(sum); });
            //var sptc = new ReturningDataThread(numberHelper);
            //sptc.CreateThreads();

            //var sptc = new JoiningThread();
            //sptc.CreateThreads();

            //SharedResource.CreateThreads();

            //MonitorThread.CreateThreads();

            //ManualResetEventThread.CreateThreads();

            AutoResetEventThread.CreateThreads();
        }

        private static void GetMainThread()
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine($"Thread Name = {mainThread.Name}");
            Console.WriteLine($"My current Thread = {Thread.CurrentThread.Name}");
        }
    }
}