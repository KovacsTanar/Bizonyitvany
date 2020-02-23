using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Bizonyitvany bizonyitvany = new Bizonyitvany("Laci","12/A",5,4,3,2,5,12,0);

            bizonyitvany.LegjobbOsztalyzat();
            Console.ReadKey();

        }
    }
}
