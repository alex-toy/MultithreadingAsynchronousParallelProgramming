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

            ParameterizedThreadConstructor.CreateThreads();
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