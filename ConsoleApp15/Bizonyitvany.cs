using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Bizonyitvany
    {
        private string nev, osztaly;
        private int magyar, matek, angol, tori, info, igazolt, igazolatlan;

        private static string[] tantargyak = new string[] { "magyar", "matek", "angol", "tori", "info" };
        //Dictionary<string, int> tantargyJegy;



        public Bizonyitvany(string nev, string osztaly, int magyar, int matek, int angol, int tori, int info, int igazolt, int igazolatlan)
        {
            this.nev = nev;
            this.osztaly = osztaly;
            this.magyar = magyar;
            this.matek = matek;
            this.angol = angol;
            this.tori = tori;
            this.info = info;
            this.igazolt = igazolt;
            this.igazolatlan = igazolatlan;
           
            //tantargyJegy = new Dictionary<string, int>()
            //{
            //    {"Magyar", magyar},
            //    {"Matek", matek},
            //    {"Angol", angol},
            //    {"Töri", tori},
            //    {"Info", info},
            //};

        }

        public double Atlag()
        {
            return (double)(magyar + matek + angol + tori + info) / 5;
        }

        public void LegjobbOsztalyzat()
        {
            List<int> osztalyzatok = new List<int>()
            {
                magyar, matek,angol,tori,info
            };
            int legjobb = osztalyzatok.Max();

            for (int i = 0; i < osztalyzatok.Count; i++)
            {
                if (osztalyzatok[i] == legjobb)
                {
                    //Console.WriteLine(tantargyJegy.Keys.ElementAt(i));
                    Console.WriteLine(tantargyak[i]);
                }
            }
        }

        public void LegrosszabbOsztalyzat()
        {
            List<int> osztalyzatok = new List<int>()
            {
                magyar, matek, angol, tori, info
            };

            int legrosszabbJegy = osztalyzatok.Min();

            for (int i = 0; i < osztalyzatok.Count; i++)
            {
                if (osztalyzatok[i] == legrosszabbJegy)
                    Console.WriteLine(tantargyak[i]);
            }
        }

        public void LevelKuldes()
        {
            if(igazolatlan >= 10)
                Console.WriteLine("Figyelem! {0} igazolatlan hiányzásai ({1} óra) miatt a szülőnek levelet kell írni!",nev,igazolatlan);
            else if(igazolt >=250)
                Console.WriteLine("Figyelem! {0} igazol hiányzásai ({1}  óra) miatt a szülőnek levelet kell írni!",nev,igazolt);
            else
                Console.WriteLine("Nincs teendő a hiányzásokkal kapcsolatosan.");
        }

        
    }
}
