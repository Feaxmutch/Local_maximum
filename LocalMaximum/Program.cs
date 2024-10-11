namespace LocalMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int minNumber = 0;
            int maxNumber = 9;
            int[] numbers = new int[30];
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber + 1);
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine("\n\nВсе локальные максимумы:");

            if (numbers[firstIndex] > numbers[firstIndex + 1])
            {
                Console.Write($"{numbers[0]} ");
            }

            for (int i = 1; i < lastIndex; i++)
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

            if (numbers[lastIndex] > numbers[lastIndex - 1])
            {
                Console.Write($"{numbers[numbers.Length - 1]} ");
            }

            Console.ReadKey();
        }
    }
}
