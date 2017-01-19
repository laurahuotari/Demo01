using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask a number
            int point;
            Console.Write("Anna pistemäärä: ");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out point);
            if (result == true)
            {
                switch (point)
                {
                    case 0:
                    case 1: Console.WriteLine("Arvosana on 0"); break;
                    case 2:
                    case 3: Console.WriteLine("Arvosana on 1"); break;
                    case 4:
                    case 5: Console.WriteLine("Arvosana on 2"); break;
                    case 6:
                    case 7: Console.WriteLine("Arvosana on 3"); break;
                    case 8:
                    case 9: Console.WriteLine("Arvosana on 4"); break;
                    case 10:
                    case 11:
                    case 12: Console.WriteLine("Arvosana on 5"); break;
                    default: Console.WriteLine("Arvo ei ole pisterajojen sisällä"); break;
                }
                
            } else
            {
                Console.WriteLine("Not a integer value!");
            }
            Console.ReadLine();
        }
    }
}
