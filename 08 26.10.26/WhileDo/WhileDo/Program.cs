namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do!");

            int nr = int.Parse(Console.ReadLine());
            int i = 1;

            //see on iteratsioon e tsükkel, mis kordub
            //nii kaua, kui vastab tingimustele
            do
            {
                Console.WriteLine(i);
                //++ suurendab ühe võrra väärtust
                i++;
                Thread.Sleep(1);

            } while (i<= nr);

        }
    }
}
