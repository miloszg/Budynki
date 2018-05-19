using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budynki
{
    class Wieżowiec : Budynek
    {
        private int wysokosc;
        public int Wysokosc {
            get { return this.wysokosc; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("podano błędna wartosc");  
                }
                else if(value> 0 && value<100)
                {
                    typ = "maly wiezowiec";
                    this.wysokosc = value;
                }
                else
                {
                    typ = "zwykly wiezowiec";
                    this.wysokosc = value;
                }

            }
        }
        public String nazwa;
        public String typ;
        public Wieżowiec(int rokBudowy, String nazwa, int wysokosc) : base(rokBudowy)
        {
            this.rokBudowy = rokBudowy;
            this.nazwa = nazwa;
            this.wysokosc = wysokosc;
        }

    }
}
