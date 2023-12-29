namespace ThreadApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main thread";
            Console.WriteLine($"Thread Name = {mainThread.Name}");
            Console.WriteLine($"My current Thread = {Thread.CurrentThread.Name}");
        }
    }
}