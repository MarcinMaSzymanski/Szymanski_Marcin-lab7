using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {

        public delegate void Dzialanie(int x, int y);


        static void Main(string[] args)
        {
            bool powtorka = true;
            while (powtorka)
            {
                Console.WriteLine("Podaj numer cwiczenia");
                string cwiczenie = Console.ReadLine();
                if (cwiczenie == "1")
                {
                    List<Auto> cars = new List<Auto>();
                    cars.Add(new Auto("Sedan", "Ford", 120, 5, "JH4NA1150MT000683", "KR1023K", 2012, "Biały", "134513566", "Jan Kowalski", "ul. Klonowa 12 30-001 Kraków", "76032103645", "VOM677636", "21.01.2000", 2013, 21));
                    cars.Add(new Auto("Kombi", "Seat", 180, 3, "SCFAC23302B500083", "KR1021S", 2016, "Czerwony", "1344353566", "Jan Kowalski", "ul. Klonowa 12 30-001 Kraków", "76032103645", "VOM677636", "21.01.2000", 2017, 21));
                    cars.Add(new Auto("Kabriolet", "Seat", 100, 3, "1J4FT68SXXL633294", "KR1032A", 2010, "Niebieski", "13443535436", "Paweł Nowak", "ul. Akacjowa 52 30-003 Kraków", "76032103124", "VOM621636", "20.07.2010", 2012, 9));

                    ICepikData car1 = cars.Find(x => x.Nr_rejestracyjny=="KR1023K");
                    IStatData car2 = cars.Find(x => x.Nr_rejestracyjny == "KR1021S");
                    IPoliceData car3 = cars.Find(x => x.Nr_rejestracyjny == "KR1032A");

                    Console.WriteLine("Wywołanie obiektu typu ICepikData");
                    car1.getData();

                    Console.WriteLine(" \n Wywołanie obiektu typu IStatData");
                    car2.getData();

                    Console.WriteLine(" \n Wywołanie obiektu typu IPoliceData");
                    car3.getData();
                }
                if (cwiczenie == "2")
                {
                    Console.WriteLine("Przeciążanie operatorów: ");
                    Point p1 = new Point(4, 5);
                    Point p2 = new Point(3, 0);
                    Console.WriteLine("Utworzono dwa obiekty Point, p1(4,5) i p2 (3,0)");
                    Point p3 = p1 + p2;
                    Console.WriteLine("Punkt p3 przy wykorzystaniu operatora +: " + p3.x + ", " + p3.y);
                    if (p1)
                    {
                        Console.WriteLine("Zastosowanie operatora true/false na p1 dało true");
                    }
                    else
                    {
                        Console.WriteLine("Zastosowanie operatora true/false na p1 dało false");
                    }

                    if (p2)
                    {
                        Console.WriteLine("Zastosowanie operatora true/false na p2 dało true");
                    }
                    else
                    {
                        Console.WriteLine("Zastosowanie operatora true/false na p2 dało false");
                    }

                    Console.WriteLine("Wynik działania p1<p2: " + (p1<p2));
                    Console.WriteLine("Nie ma możliwości przeciążenia tylko operatora '<'");

                    p1++;
                    Console.WriteLine("Zastosowano operator ++ na p1, wynik: " + p1.x + ", " + p1.y);

                    p2--;
                    Console.WriteLine("Zastosowano operator ++ na p2, wynik: " + p2.x + ", " + p2.y);

                    Point p = 5;
                    p1++;
                    Console.WriteLine("Wykonana operacje Point p=5, współrzędne powstałego punktu: " + p.x + ", " + p.y);

                    p = new Point(2, 5);
                    int suma = (int)p;
                    Console.WriteLine("Wykonana operacje Point p=new Point(2,5); int suma = (int)suma, wynik operacji: " + suma);
                    Console.WriteLine("Nie ma możliwości nadpisania operatora +=, gdyż nie ma możlwiości przeciążania operatorów przypisań.");
                }

                if (cwiczenie == "3")
                {
                    Dzialania dzialania = new Dzialania();
                    Dzialanie dzialanie = new Dzialanie(dzialania.Dodaj);
                    dzialanie += dzialania.Odejmij;
                    dzialanie += dzialania.Pomnoz;
                    dzialanie += dzialania.Podziel;
                    dzialanie(10, 5);
                }

                Console.WriteLine("Powtórzyć program? [T/N]");
                string pytanie = Console.ReadLine();
                if (pytanie == "N" || pytanie == "n") powtorka = false;
            }
        
    }
    }
}
