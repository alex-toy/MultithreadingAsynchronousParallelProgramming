﻿namespace MultithreadingApp
{
    public class NumberHelper
    {
        public delegate int SumOfNumbers(int sum);
        private readonly int _number;

        public NumberHelper(int number)
        {
            _number = number;
        }

        public void ShowNumbers()
        {
            int sum = 0;
            for (int i = 0; i < _number; i++)
            {
                sum += i;
                Console.WriteLine($"ShowNumbers : {i}");
            }
        }
    }
}
