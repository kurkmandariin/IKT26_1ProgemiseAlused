namespace ForLoopLisamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n\n");

            int sum = 0;

            for (int j = 1; j <= 10; j++)
            {
                sum = sum + sum;
                Console.WriteLine($"Summa on: " + j);
            }
        }
    }
}
