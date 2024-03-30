using System;

namespace _07.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesec = Console.ReadLine();
            int broiNoshtuvki = int.Parse(Console.ReadLine());

            double cenaZaCeliaPrestoiVStudio;
            double cenaZaCeliaPrestoiVApartament;
           
            double cenaZa1NoshtuvkaVStudio;
            double cenaZa1NoshtuvkaVApartament;
           
            double namalenieStudio = 0.0;
            double namalenieApartament = 0.0;

            switch (mesec)
            {
                case "May":
                case "October":
                    cenaZa1NoshtuvkaVStudio = 50.00;
                    cenaZa1NoshtuvkaVApartament = 65.00;

                    if (broiNoshtuvki > 7 && broiNoshtuvki <= 14)
                    {
                        namalenieStudio = 0.05;
                    }
                    else if (broiNoshtuvki > 14)
                    {
                        namalenieStudio = 0.30;
                    }

                    break;

                case "June":
                case "September":
                    cenaZa1NoshtuvkaVStudio = 75.20;
                    cenaZa1NoshtuvkaVApartament = 68.70;

                    if (broiNoshtuvki > 14)
                    {
                        namalenieStudio = 0.20;
                    }
                    break;

                case "July":
                case "August":
                    cenaZa1NoshtuvkaVStudio = 76.00;
                    cenaZa1NoshtuvkaVApartament = 77.00;

                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }
            if (broiNoshtuvki > 14)
            {
                namalenieApartament = 0.10;
            }

            double cenaZa1NoshtuvkaVStudioSOtstapka = cenaZa1NoshtuvkaVStudio * (1 - namalenieStudio);
            double cenaZa1NoshtuvkaVApartamentSOtstapka = cenaZa1NoshtuvkaVApartament * (1 - namalenieApartament);

            cenaZaCeliaPrestoiVStudio = cenaZa1NoshtuvkaVStudioSOtstapka * broiNoshtuvki;
            cenaZaCeliaPrestoiVApartament = cenaZa1NoshtuvkaVApartamentSOtstapka * broiNoshtuvki;

            Console.WriteLine($"Apartment: {cenaZaCeliaPrestoiVApartament:F2} lv.");
            Console.WriteLine($"Studio: {cenaZaCeliaPrestoiVStudio:F2} lv.");
        }
    }
}
