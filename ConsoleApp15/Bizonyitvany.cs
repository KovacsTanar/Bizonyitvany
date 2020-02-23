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
        Dictionary<string, int> tantargyJegy;



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
            //Feltolt();
            tantargyJegy = new Dictionary<string, int>()
            {
                {"Magyar", magyar},
                {"Matek", matek},
                {"Angol", angol},
                {"Töri", tori},
                {"Info", info},
            };

        }

        public double Atlag() {
            return (double)(magyar + matek + angol + tori + info) / 5;
        }
        public void LegjobbOsztalyzat()
        {
            List<int> osztalyzatok = new List<int>()
            {magyar, matek,angol,tori,info};
            int legjobb = osztalyzatok.Max();

            for (int i = 0; i < osztalyzatok.Count; i++)
            {
                if (osztalyzatok[i] == legjobb) Console.WriteLine(tantargyJegy.Keys.ElementAt(i));
            }
        }

        //private void Feltolt()
        //{
        //    tantargyJegy.Add("Magyar", magyar);
        //    tantargyJegy.Add("Matek", matek);
        //    tantargyJegy.Add("Angol", angol);
        //    tantargyJegy.Add("Töri", tori);
        //    tantargyJegy.Add("Info", info);
        //}
        
    }
}
