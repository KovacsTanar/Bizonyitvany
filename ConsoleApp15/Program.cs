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
           
            Bizonyitvany bizonyitvany = new Bizonyitvany("Laci","12/A",5,4,3,2,5,12,11);

            Console.WriteLine("Az átlag: {0:0.00}",bizonyitvany.Atlag());
            Console.WriteLine("\n");
            Console.WriteLine("A legjobb tantárgyai:");
            bizonyitvany.LegjobbOsztalyzat();
            Console.WriteLine("\n");
            Console.WriteLine("A legrosszabb tantárgyai:");
            bizonyitvany.LegrosszabbOsztalyzat();
            Console.WriteLine("\n");
            bizonyitvany.LevelKuldes();
            Console.ReadKey();

        }
    }
}
