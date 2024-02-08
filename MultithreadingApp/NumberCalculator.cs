namespace MultithreadingApp
{
    public class NumberCalculator
    {
        private readonly int _number;
        public delegate void SumOfNumbers(int sumOfNums);
        private readonly SumOfNumbers _sumOfNumbers;

        public NumberCalculator(int number, SumOfNumbers sumOfNumbers)
        {
            _number = number;
            _sumOfNumbers = sumOfNumbers;
        }

        public void ShowNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _number; i++)
            {
                sum += i;
            }

            if (_sumOfNumbers is not null) _sumOfNumbers(sum);
        }
    }
}
