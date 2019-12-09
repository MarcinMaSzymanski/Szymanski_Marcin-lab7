using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Auto : ICepikData, IStatData, IPoliceData
    {
        private string typ_pojazdu;
        private string marka;
        private double pojemnosc;
        private int liczba_miejsc;
        private string vin;
        private string nr_rejestracyjny;
        private int rok_produkcji;
        private string kolor;
        private string nr_polisy;

        private string imie_nazwisko;
        private string adres_zamieszkania;
        private string pesel;
        private string nr_prawa_jazdy;
        private string data_uzyskania_prawa_jazdy;
        private int rok_zakupu;
        private int liczba_punktow_na_nagrody;

        public Auto(string typ_pojazdu, string marka, double pojemnosc, int liczba_miejsc, string vin, string nr_rejestracyjny, int rok_produkcji, string kolor, string nr_polisy, string imie_nazwisko, string adres_zamieszkania, string pesel, string nr_prawa_jazdy, string data_uzyskania_prawa_jazdy, int rok_zakupu, int liczba_punktow_na_nagrody)
        {
            this.typ_pojazdu = typ_pojazdu;
            this.marka = marka;
            this.pojemnosc = pojemnosc;
            this.liczba_miejsc = liczba_miejsc;
            this.vin = vin;
            this.Nr_rejestracyjny = nr_rejestracyjny;
            this.rok_produkcji = rok_produkcji;
            this.kolor = kolor;
            this.nr_polisy = nr_polisy;
            this.imie_nazwisko = imie_nazwisko;
            this.adres_zamieszkania = adres_zamieszkania;
            this.pesel = pesel;
            this.nr_prawa_jazdy = nr_prawa_jazdy;
            this.data_uzyskania_prawa_jazdy = data_uzyskania_prawa_jazdy;
            this.rok_zakupu = rok_zakupu;
            this.liczba_punktow_na_nagrody = liczba_punktow_na_nagrody;
        }

        public string Nr_rejestracyjny { get => nr_rejestracyjny; set => nr_rejestracyjny = value; }

        void ICepikData.getData()
        {
            Console.WriteLine("Dane pojazdu: ");
            Console.WriteLine("Typ pojazdu: " +typ_pojazdu);
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Pojemność: " + pojemnosc);
            Console.WriteLine("Liczba miejsc: " + liczba_miejsc);
            Console.WriteLine("VIN: " + vin);
            Console.WriteLine("Numer rejestracyjny: " + Nr_rejestracyjny);
            Console.WriteLine("Rok produkcji: " + rok_produkcji);
            Console.WriteLine("Kolor: " + kolor);
            Console.WriteLine("Numer polisy" + nr_polisy);

            Console.WriteLine("Dane właściciela: ");
            Console.WriteLine("Imię i nazwisko: " + imie_nazwisko);
            Console.WriteLine("Adres zamieszkania: " + adres_zamieszkania);
            Console.WriteLine("PESEL: " + pesel);
            Console.WriteLine("Numer prawa jazdy: " + nr_prawa_jazdy);
            Console.WriteLine("Data uzyskania prawa jazdy: " + data_uzyskania_prawa_jazdy);
            Console.WriteLine("Rok zakupu: " + rok_zakupu);           
        }

        void IStatData.getData()
        {
            Console.WriteLine("Dane pojazdu: ");
            Console.WriteLine("Typ pojazdu: " + typ_pojazdu);
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Pojemność: " + pojemnosc);
            Console.WriteLine("Liczba miejsc: " + liczba_miejsc);
            Console.WriteLine("VIN: " + vin);
            Console.WriteLine("Numer rejestracyjny: " + Nr_rejestracyjny);
            Console.WriteLine("Rok produkcji: " + rok_produkcji);
            Console.WriteLine("Kolor: " + kolor);
            Console.WriteLine("Numer polisy" + nr_polisy);
        }

        void IPoliceData.getData()
        {
            Console.WriteLine("Dane pojazdu: ");
            Console.WriteLine("Typ pojazdu: " + typ_pojazdu);
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Pojemność: " + pojemnosc);
            Console.WriteLine("Liczba miejsc: " + liczba_miejsc);
            Console.WriteLine("VIN: " + vin);
            Console.WriteLine("Numer rejestracyjny: " + Nr_rejestracyjny);
            Console.WriteLine("Rok produkcji: " + rok_produkcji);
            Console.WriteLine("Kolor: " + kolor);
            Console.WriteLine("Numer polisy: " + nr_polisy);

            Console.WriteLine("Dane właściciela: ");
            Console.WriteLine("Imię i nazwisko: " + imie_nazwisko);
            Console.WriteLine("Adres zamieszkania: " + adres_zamieszkania);
            Console.WriteLine("PESEL: " + pesel);
            Console.WriteLine("Numer prawa jazdy: " + nr_prawa_jazdy);
            Console.WriteLine("Data uzyskania prawa jazdy: " + data_uzyskania_prawa_jazdy);
            Console.WriteLine("Rok zakupu: " + rok_zakupu);
            Console.WriteLine("Liczba punktów karnych: " + liczba_punktow_na_nagrody);
        }


    }
}
