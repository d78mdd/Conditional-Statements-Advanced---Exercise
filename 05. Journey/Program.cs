using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {

            double biodzhet = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();

            string destinacia;
            string vidPochivka;
            double procentOtBiodzheta;

            if (biodzhet <= 100)
            {
                destinacia = "Bulgaria";

                if (sezon == "summer")
                {
                    vidPochivka = "Camp";
                    procentOtBiodzheta = 0.30;
                }
                else if (sezon == "winter")
                {
                    vidPochivka = "Hotel";
                    procentOtBiodzheta = 0.70;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (biodzhet <= 1000)
            {
                destinacia = "Balkans";

                if (sezon == "summer")
                {
                    vidPochivka = "Camp";
                    procentOtBiodzheta = 0.40;
                }
                else if (sezon == "winter")
                {
                    vidPochivka = "Hotel";
                    procentOtBiodzheta = 0.80;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                destinacia = "Europe";

                vidPochivka = "Hotel";
                procentOtBiodzheta = 0.90;
            }


            double poharchenaSuma = procentOtBiodzheta * biodzhet;

            Console.WriteLine($"Somewhere in {destinacia}");
            Console.WriteLine($"{vidPochivka} - {poharchenaSuma:F2}");

        }
    }
}
