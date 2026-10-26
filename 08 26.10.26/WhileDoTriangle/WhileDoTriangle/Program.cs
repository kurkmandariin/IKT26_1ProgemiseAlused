namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number!");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            //otsida Internetist While koodiga kolmnurka
            //kujundeide tegemise viise
            //kui kood on leitud, siis kirjutada see siia alla

            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= 1)
                {
                    Console.WriteLine(j + " ");
                    j++;
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
