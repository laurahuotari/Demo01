using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.WriteLine("Give a number: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a number: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a number: ");
            luku3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is: " + (luku1 + luku2 + luku3));
            Console.WriteLine("The average is: " + (luku1 + luku2 + luku3) / 3);


        }
    }
}
