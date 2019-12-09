using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Dzialania
    {
        public void Dodaj (int x, int y) { Console.WriteLine("Wynik dodawania: " + (x + y)); }
        public void Odejmij(int x, int y) { Console.WriteLine("Wynik odejmowania: " + (x - y)); }
        public void Pomnoz(int x, int y) { Console.WriteLine("Wynik mnożenia: " + (x * y)); }
        public void Podziel(int x, int y) { Console.WriteLine("Wynik dzielenia: " + (x / y)); }
    }
}
