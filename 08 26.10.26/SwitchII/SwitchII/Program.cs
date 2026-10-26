namespace SwitchII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali tehe, meetod või vanus");

            string töö = Console.ReadLine();

            string meetod = Console.ReadLine();
            switch (töö)
            {

                case "tehe":
                    Console.WriteLine("Sisesta esimene number");
                    float firstNr = float.Parse(Console.ReadLine());
                    Console.WriteLine("Vajuta *");
                    string korrutamine = Console.ReadLine();
                    Console.WriteLine("Sisesta teine number");
                    float secondNr = float.Parse(Console.ReadLine());
                    Console.WriteLine("Vastus on: + input");
                    break;

                case "vanus":
                    Console.WriteLine("Kirjuta oma vanus");
                    string vanus = Console.ReadLine();
                    if (vanus == "16")
                    {
                        Console.WriteLine("Sinu vanus on 16");
                    }
                    else
                    {
                        Console.WriteLine("Sinu vanus on" + vanus);
                    }
                    break;

                case "meetod":
                    Console.WriteLine("Kui soovid meetodit kutsuda, kirjuta ja");
                    break;
            }
        }
    }
}
