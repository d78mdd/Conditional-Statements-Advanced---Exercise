using System;

namespace _08.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int chasNaIzpita = int.Parse(Console.ReadLine());
            int minutaNaIzpita = int.Parse(Console.ReadLine());
            int chasNaPristigane= int.Parse(Console.ReadLine());
            int minutaNaPristigane = int.Parse(Console.ReadLine());


            int izpitTimeStamp = chasNaIzpita * 60 + minutaNaIzpita;
            int pristiganeTimeStamp = chasNaPristigane * 60 + minutaNaPristigane;

            int difference = izpitTimeStamp - pristiganeTimeStamp;

            int mm;
            int hh;

            if (difference > 0)
            {
                mm = difference % 60;
                hh = difference / 60;

                string mmString = mm.ToString();
                if (mm < 10)
                {
                    mmString = $"0{mmString}";
                }

                if (hh == 0)
                {
                    if (mm > 30)
                    {
                        Console.WriteLine("Early");
                    }
                    else
                    {
                        Console.WriteLine("On time");
                    }
                    Console.WriteLine($"{mm} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hh}:{mmString} hours before the start");
                }
            }
            else if (difference < 0)
            {
                mm = (0 - difference) % 60;
                hh = (0 - difference) / 60;

                string mmString = mm.ToString();
                if (mm < 10)
                {
                    mmString = $"0{mmString}";
                }

                if (hh == 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{mm} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hh}:{mmString} hours after the start");
                }
            }
            else // difference == 0
            {
                Console.WriteLine("On time");
            }

        }
    }
}
