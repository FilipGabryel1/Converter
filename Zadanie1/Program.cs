using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double stopnie, minuty, sekundy, dziesietny;
            Console.WriteLine("Podaj stopnie: ");
            stopnie = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj minuty: ");
            minuty = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj sekundy: ");
            sekundy = Convert.ToDouble(Console.ReadLine());

            dziesietny = sekundy / 3600 + minuty / 60 + stopnie;

            Console.WriteLine("Koordynaty w formacie dziesiętnym to: {0}", dziesietny);
            Console.ReadKey();

        }
    }
}
