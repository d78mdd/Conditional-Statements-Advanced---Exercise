using System;

namespace _03.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string vidCvetq = Console.ReadLine();
            int broiCvetq = int.Parse(Console.ReadLine());
            int biodzhet = int.Parse(Console.ReadLine());

            double otstapka = 0.0;
            double cenaZaEdno = 0.0;

            switch (vidCvetq)
            {
                case "Roses":
                    cenaZaEdno = 5.00;
                    if (broiCvetq > 80)
                    {
                        otstapka = -0.10;
                    }
                    break;
                case "Dahlias":
                    cenaZaEdno = 3.80;
                    if (broiCvetq > 90)
                    {
                        otstapka = -0.15;
                    }
                    break;
                case "Tulips":
                    cenaZaEdno = 2.80;
                    if (broiCvetq > 80)
                    {
                        otstapka = -0.15;
                    }
                    break;
                case "Narcissus":
                    cenaZaEdno = 3;
                    if (broiCvetq < 120)
                    {
                        otstapka = 0.15;
                    }
                    break;
                case "Gladiolus":
                    cenaZaEdno = 2.50;
                    if (broiCvetq < 80)
                    {
                        otstapka = 0.20;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            double cena = broiCvetq * cenaZaEdno;

            double cenaSOtstapka = (1 + otstapka) * cena;

            if (biodzhet >= cenaSOtstapka)
            {
                double ostanalaSuma = biodzhet - cenaSOtstapka;
                Console.WriteLine($"Hey, you have a great garden with {broiCvetq} {vidCvetq} and {ostanalaSuma:F2} leva left.");
            } else
            {
                double nujnaSuma = cenaSOtstapka - biodzhet;
                Console.WriteLine($"Not enough money, you need {nujnaSuma:F2} leva more.");
            }


        }
    }
}
