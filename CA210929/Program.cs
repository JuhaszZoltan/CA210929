using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210929
{
    class Cica
    {
        private string _nev;
        public string Nev 
        {
            get => _nev;
            set
            {
                if (value is null) throw new Exception("nincsen cica név nélkül! :(((((");
                _nev = value;
            }
        }
        public bool Ehes { get; set; }
        public float SzorHossz { get; set; }
        public string Fajta { get; set; }

        public string Dorombol()
        {
            return $"{Nev} mondja: doromb-doromb!";
        }

        public void Eszik()
        {
            if (!Ehes) throw new Exception($"{Nev} nem akar enni! :(");
            Ehes = false;
        }

        public Cica(string nev, bool ehes, float szorHossz, string fajta)
        {
            Nev = nev;
            Ehes = ehes;
            SzorHossz = szorHossz;
            Fajta = fajta;
        }

        public Cica(string nev) : this(nev, false, 1F, "közönséges házi") { }
    }


    class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            Cica c1 = new Cica("Lukrécica");
            //Cica c2 = new Cica("Leonidasz", true, 3F, "Perzsa");

            Console.Write("adj meg egy számot: ");
            var szam = int.Parse(Console.ReadLine());

            //if (szam % 2 == 0) Console.WriteLine("ez a szám páros");
            //else Console.WriteLine("ez a számó nem páros");


            Console.WriteLine($"ez a szám {(szam % 2 == 0 ? "" : "nem")} páros");



            //Console.WriteLine(c1.Dorombol());
            //c2.Eszik();
            Console.ReadKey();
        }
    }
}
