using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budynki
{
    class Program
    {
        public static bool FiltrujWysokie(Wieżowiec w, int prog)
        {
            return w.Wysokosc > prog;
        }

        public static bool FiltrujNowe(Wieżowiec w, int prog)
        {
            return w.rokBudowy > prog;
        }

        public delegate bool Del(Wieżowiec w, int prog);

        static void Main(string[] args)
        {
            int prog = 0;
            Wieżowiec w1 = new Wieżowiec(2004, "BigBen", 543);
            Wieżowiec w2 = new Wieżowiec(2008, "wieza LOL", 78);
            Wieżowiec w3 = new Wieżowiec(1997, "OlivaBC", 256);
            Wieżowiec w4 = new Wieżowiec(2011, "Wieza Eiffla", 330);
            w3.Wysokosc = 21;
            Console.WriteLine("Typ wiezowca to " + w3.typ);
            w3.Wysokosc = 121;
            Console.WriteLine("Typ wiezowca to " + w3.typ);

            List<Wieżowiec> lista = new List<Wieżowiec>();
            lista.Add(w1);
            lista.Add(w2);
            lista.Add(w3);
            lista.Add(w4);
            Console.WriteLine("Liczba wiezowcow to "+lista.Count());

            Console.WriteLine("Wpisz cos: ");
            String c = Console.ReadLine();
            Del d = new Del(FiltrujWysokie);
            if (c.Equals("w"))
            { d = FiltrujWysokie; prog = 200; }
            else
            { d = FiltrujNowe; prog = 2000; }
            
            Console.WriteLine("Za pomoca delegaty");
            foreach (Wieżowiec tmp in lista)
            {
                if(d(tmp,prog))
                {
                    Console.WriteLine("budynek:"+tmp.nazwa+" o wysokosci: " +tmp.Wysokosc+" rok budowy to: "+tmp.rokBudowy);
                }
            }

            Console.WriteLine("Za pomoca lambda i where");
            IEnumerable<Wieżowiec> lista1 = lista.Where(w => w.rokBudowy > 2000);
            foreach (Wieżowiec tmp in lista1)
            {        
                    Console.WriteLine("budynek:" + tmp.nazwa + " o wysokosci: " + tmp.Wysokosc + " rok budowy to: " + tmp.rokBudowy);
                
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
