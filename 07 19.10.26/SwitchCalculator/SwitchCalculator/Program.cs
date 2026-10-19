using System.Threading.Channels;

namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float firstNr = float.Parse(Console.ReadLine());
            //siin valitakse switchi case
            Console.WriteLine("Vali tehe: *,/, +, -");
            string tehe = Console.ReadLine();
            Console.WriteLine("Sisesta teine number");
            float secondNr = float.Parse(Console.ReadLine());
            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel
            Console.WriteLine("Vastus on: ");
            switch (tehe)
            {
                case "*":
                        Console.WriteLine(firstNr * secondNr);
                        break;
                case "/":
                    if (secondNr == 0)
                    {
                        Console.WriteLine("Nulliga ei saa jagada!");
                    }
                    else
                    {
                        Console.WriteLine(firstNr / secondNr);
                    }
                    break;
                case "+":
                    Console.WriteLine(firstNr + secondNr);
                    break;
                case "-":
                    Console.WriteLine(firstNr - secondNr);
                    break;
                default:
                    Console.WriteLine("See ei ole õige tehe!");
                    break;
            }
        }
    }
}
