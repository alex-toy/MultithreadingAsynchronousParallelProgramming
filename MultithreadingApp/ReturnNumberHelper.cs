namespace MultithreadingApp
{
    public class ReturnNumberHelper
    {
        public delegate void SumOfNumbers(int sum);
        private readonly int _number;
        private readonly SumOfNumbers? _sumOfNumbers;

        public ReturnNumberHelper(int number, SumOfNumbers sumOfNumbers)
        {
            _number = number;
            _sumOfNumbers = sumOfNumbers;
        }

        public void ShowNumbers()
        {
            int sum = 0;
            for (int i = 0; i < _number; i++)
            {
                sum += i;
                Console.WriteLine($"ShowNumbers : {i}");
            }

            if (_sumOfNumbers != null) _sumOfNumbers(sum);
        }
    }
}
