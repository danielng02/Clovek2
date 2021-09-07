using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Clovek
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Clovek
    {

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }


        public Clovek()
        {
            Jmeno = "Neznama";
            Prijmeni = "Neznama";
        }
        public Clovek(string j, string p)
        {
            Jmeno = j;
            Prijmeni = p;
        }

    }

    class Obcan : Clovek
    {
        private string rodneCislo;
        Regex rx = new Regex(@"\d{6}\/\d{4}");

        public string RodneCislo
        {
            get { return rodneCislo; }
            set
            {
                if (rx.IsMatch(value))
                {
                    rodneCislo = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        public Obcan() : base()
        {
            RodneCislo = "000000/0000";
        }
        public Obcan(Clovek c, string r) : base(c.Jmeno, c.Prijmeni)
        {
            RodneCislo = r;
        }
        public override string ToString()
        {
            return "Obcan: " + Jmeno + " " + Prijmeni + "" + RodneCislo;
        }
    }
}
