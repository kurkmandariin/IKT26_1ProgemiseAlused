namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //sisestatud algrarvu

            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = number > 1;

            //for loopiga käib kontroll, kas on algarv

            //if ja else annavad vastuse, kas on algarv või mitte
            //if ja else annavad vastuse, kas on algarv või mitte
            for (int i = 2; i * i <= number; i++)
            {
                //avab tsükli sisu. Sulgude vahel olev kood kordub
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }


            if (isPrime)
            {
                Console.WriteLine($"{number} on algarv");
            }
            else
            {
                Console.WriteLine($"{number} ei ole algarv");
            }
        }
    }
}
