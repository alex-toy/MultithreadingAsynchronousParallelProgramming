namespace MultithreadingApp
{
    public class JoiningThread
    {
        public void CreateThreads()
        {
            Console.WriteLine("Main execution started");
            var t1 = new Thread(Method1);
            var t2 = new Thread(Method2);
            var t3 = new Thread(Method3);
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();

            string message = t2.IsAlive ? "still going on" : "completed";
            Console.WriteLine($"IsAlive : Method2 execution {message}");

            if (t3.Join(2000))
            {
                Console.WriteLine("Method3 execution completed after 2 seconds");
            }

            if (t3.Join(6000))
            {
                Console.WriteLine("Method3 execution completed after 6 seconds");
            }

            Console.WriteLine("Main execution completed");
        }

        static void Method1()
        {
            Console.WriteLine("Method1 execution started");
            Thread.Sleep(3000);
            Console.WriteLine("Method1 execution completed");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 execution started");
            Thread.Sleep(5000);
            Console.WriteLine("Method2 execution completed");
        }

        static void Method3()
        {
            Console.WriteLine("Method3 execution started");
            Thread.Sleep(5000);
            Console.WriteLine("Method3 execution completed");
        }
    }
}
