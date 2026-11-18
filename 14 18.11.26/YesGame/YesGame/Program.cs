using System.Threading.Channels;

namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = "";
            

            //while ja nii kaua tsükkel kestab kuni kasutaja sisetab sõna yes
            

            while (word != "yes")
            {
                Console.WriteLine("Kirjuta sõna yes või midagi muud");
                word = Console.ReadLine();
            }

            Console.WriteLine("Tubli töö");
        }
    }
}
