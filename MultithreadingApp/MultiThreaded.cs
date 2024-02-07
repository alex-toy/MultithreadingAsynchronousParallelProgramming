namespace MultithreadingApp
{
    public static class MultiThreaded
    {
        public static void RunAll()
        {
            Thread t1 = new Thread(Method1) { Name = "Thread 1" };
            Thread t2 = new Thread(Method2) { Name = "Thread 2" };
            Thread t3 = new Thread(Method3) { Name = "Thread 3" };

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }

        public static void Method1()
        {
            Console.WriteLine($"Started {nameof(Method1)} inside {Thread.CurrentThread.Name}");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method 1 : {i}");
            }

            Console.WriteLine($"Ended {nameof(Method1)} inside {Thread.CurrentThread.Name}");
        }

        public static void Method2()
        {
            Console.WriteLine($"Started {nameof(Method2)} inside {Thread.CurrentThread.Name}");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method 2 : {i}");
                if (i == 2)
                {
                    Console.WriteLine("start executing i == 2");
                    Thread.Sleep(10000);
                    Console.WriteLine("end executing i == 2");
                }
            }

            Console.WriteLine($"Ended {nameof(Method2)} inside {Thread.CurrentThread.Name}");
        }

        public static void Method3()
        {
            Console.WriteLine($"Started {nameof(Method3)} inside {Thread.CurrentThread.Name}");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method 3 : {i}");
            }

            Console.WriteLine($"Ended {nameof(Method3)} inside {Thread.CurrentThread.Name}");
        }
    }
}