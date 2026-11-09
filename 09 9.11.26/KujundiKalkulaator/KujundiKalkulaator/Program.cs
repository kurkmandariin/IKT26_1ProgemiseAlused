namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //leia ja väljasta ekraanile ruudu pindala ja ümbermõõt
            int roundRadius = 3;
            int diameter = roundRadius * 2;
            double squareArea1 = Math.Pow(diameter, 2);
            double squareArea2 = diameter * diameter;
            double squarePerimiter = diameter * 4;

            Console.WriteLine("Ruudu pindala: " + squareArea2);
            Console.WriteLine("Ruudu ümbermõõt: " + squarePerimiter);

            //arvuta ringi pindala ja ümbermõõt
            double roundArea1 = Math.PI * Math.Pow(roundRadius, 2);
            double roundArea2 = Math.PI * (roundRadius * roundRadius);
            double roundPerimiter = 2 * Math.PI * roundRadius;

            //kuidas teha, et maksimaalselt kaks kohta pärast koma oleks?
            Console.WriteLine("1Ringi pindala " + Math.Round(roundArea1,2));
            //# arv määrab kui palju kohti pärast koma on
            Console.WriteLine($"2Ringi pindala {roundArea1:0.##}");

            Console.WriteLine($"Ringi ümbermõõt  + {roundPerimiter:0.##}");
        }
    }
}