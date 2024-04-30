using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaVizsga
{
    internal class Futar
    {
        public int fazon;
        public string fnev;
        public string ftel;
        public int ertek;

        public Futar(int fazon, string fnev, string ftel, int ertek)
        {
            this.fazon = fazon;
            this.fnev = fnev;
            this.ftel = ftel;
            this.ertek = ertek;
        }
    }
}
