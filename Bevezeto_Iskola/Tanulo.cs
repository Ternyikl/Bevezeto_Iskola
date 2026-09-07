using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bevezeto_Iskola
{
    public class Tanulo
    {
        private string nev;
        private int szuletesiEv;
        private double atlag;
        private string osztaly;

        public Tanulo(string nev, int szuletesiEv, double atlag, string osztaly)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            if(atlag <= 5 || atlag >= 0 )
            {
                this.atlag = atlag;
            }
            else
            {
                this.atlag = 0;
            }
            this.osztaly = osztaly;
        }

        public string Nev { get => nev; set => nev = value; }
        public int SzuletesiEv { get => szuletesiEv; set => szuletesiEv = value; }
        public double Atlag { get => atlag; set => atlag = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }

        public int Eletkorszamitas()
        {
            return DateTime.Now.Year - this.szuletesiEv;
        }

        public bool KitunoE()
        {
            return (Atlag == 5 ? true : false);
        }

        public override string ToString()
        {
            return $"{this.nev}, született {this.szuletesiEv}, {this.osztaly} osztályos, átlaga: {this.atlag}";
        }
    }
}
