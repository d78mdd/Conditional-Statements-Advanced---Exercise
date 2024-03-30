using System;

namespace _09.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dniZaPrestoi = int.Parse(Console.ReadLine());
            string vidPomeshtenie = Console.ReadLine();
            string ocenka = Console.ReadLine();

            double cenaZaNoshtuvka;

            switch (vidPomeshtenie)
            {
                case "room for one person":
                    cenaZaNoshtuvka = 18.00;
                    break;
                case "apartment":
                    cenaZaNoshtuvka = 25.00;
                    break;
                case "president apartment":
                    cenaZaNoshtuvka = 35.00;
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            double namalenie = 0.0;

            switch (vidPomeshtenie)
            {
                case "room for one person":
                    break;

                case "apartment":

                    if (dniZaPrestoi < 10)
                    {
                        namalenie = 0.30;
                    }
                    else if (dniZaPrestoi >= 10 && dniZaPrestoi <= 15)
                    {
                        namalenie = 0.35;
                    }
                    else // dniZaPrestoi > 15
                    {
                        namalenie = 0.50;
                    }
                    break;

                case "president apartment":

                    if (dniZaPrestoi < 10)
                    {
                        namalenie = 0.10;
                    }
                    else if (dniZaPrestoi >= 10 && dniZaPrestoi <= 15)
                    {
                        namalenie = 0.15;
                    }
                    else // dniZaPrestoi > 15
                    {
                        namalenie = 0.20;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            int noshtuvki = dniZaPrestoi - 1;

            double cena = cenaZaNoshtuvka * noshtuvki;

            double cenaSNamalenie = cena * (1 - namalenie);

            double cenaSOcenka;

            if (ocenka == "positive")
            {
                cenaSOcenka = cenaSNamalenie * (1 + 0.25);
            }
            else if (ocenka == "negative")
            {
                cenaSOcenka = cenaSNamalenie * (1 - 0.10);
            }
            else
            {
                Console.WriteLine("error");
                return;
            }


            Console.WriteLine($"{cenaSOcenka:F2}");
        }
    }
}
