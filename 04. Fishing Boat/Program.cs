using System;

namespace _04.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int biodzhet = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            int broiRibari= int.Parse(Console.ReadLine());

            double otstapka1 = 0.0;
            double cenaZaKoraba = 0.0;

            if (broiRibari <= 6)
            {
                otstapka1 = 0.10;
            }
            else if (broiRibari >= 7 && broiRibari <= 11)
            {
                otstapka1 = 0.15;
            }
            else if (broiRibari >= 12)
            {
                otstapka1 = 0.25;
            } else
            {
                Console.WriteLine("error");
            }

            double otstapka2 = 0.0;
            if (broiRibari % 2 == 0 && sezon != "Autumn")
            {
                otstapka2 = 0.05;
            }

            switch (sezon)
            {
                case "Spring":
                    cenaZaKoraba = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    cenaZaKoraba = 4200;
                    break;
                case "Winter":
                    cenaZaKoraba = 2600;
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            double cenaSOtstapka1 = cenaZaKoraba * (1 - otstapka1);
            double cenaSOtstapka2 = cenaSOtstapka1 * (1 - otstapka2);

            double krainaCena = cenaSOtstapka2;

            if (biodzhet >= krainaCena)
            {
                double ostanaliPari = biodzhet - krainaCena;
                Console.WriteLine($"Yes! You have {ostanaliPari:F2} leva left.");
            }
            else
            {
                double neDostiga = krainaCena - biodzhet;
                Console.WriteLine($"Not enough money! You need {neDostiga:F2} leva.");
            }
        }
    }
}
