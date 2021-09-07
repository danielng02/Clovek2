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

        private string jmeno;
        private string prijmeni;

        public string Jmeno { get { return jmeno; } set { jmeno = value;} }
        public string Prijmeni { get { return prijmeni; } set { prijmeni = value; } }


        public Clovek()
        {
            Jmeno = "Neznama";
            Prijmeni= "Neznama";
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

        public string RodneCislo { get { return rodneCislo; } set { rodneCislo = value; } }

        public Obcan() : base()
        {
            RodneCislo = "000000/0000";
        }
        public Obcan(Clovek c, string r) : base(c.Jmeno, c.Prijmeni)
        {

            Regex rx = new Regex(@"[0 - 9]{ 2,6}\/[0 - 9]{ 4}");
            if (rx.IsMatch(r))
            {
                RodneCislo = r;
            }
            else { throw new FormatException(); }
        }
    }
}
