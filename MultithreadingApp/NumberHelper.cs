namespace MultithreadingApp
{
    public class NumberHelper
    {
        private readonly int _number;

        public NumberHelper(int number)
        {
            _number = number;
        }

        public void ShowNumbers()
        {
            for (int i = 0; i < _number; i++)
            {
                Console.WriteLine($"ShowNumbers : {i}");
            }
        }
    }
}
