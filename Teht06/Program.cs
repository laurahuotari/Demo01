using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double hinta=1.595;
            double kulutus =7.02/100; 

            Console.WriteLine("Anna matka > ");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            Console.WriteLine("Bensaa kuluu " + matka*kulutus + ", kustannus " + matka*hinta*kulutus + " euroa");
            

        }
    }
}
