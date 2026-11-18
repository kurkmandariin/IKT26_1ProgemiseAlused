using System.Threading.Channels;

namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //numbri arvamise mäng

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            //tuleb kasutada while, kus öeldakse, kas sinu
            //pakutud number oli suurem või väiksem

            while (secretNumber != guess);
        }
    }
}
