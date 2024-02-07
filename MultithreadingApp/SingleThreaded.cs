using System.Diagnostics;

namespace MultithreadingApp
{
    public static class SingleThreaded
    {
        public static void RunAll()
        {
            Method1();
            Console.WriteLine("Method1 completed");

            Method2();
            Console.WriteLine("Method2 completed");

            Method3();
            Console.WriteLine("Method3 completed");

            Console.ReadLine();
        }

        public static void Method1()
        {
            Console.WriteLine($"Started {nameof(Method1)} inside {Thread.CurrentThread.Name}");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method 1 : {i}");
            }
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
        }

        public static void Method3()
        {
            Console.WriteLine($"Started {nameof(Method3)} inside {Thread.CurrentThread.Name}");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method 3 : {i}");
            }
        }
    }
}