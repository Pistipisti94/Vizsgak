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

        public Futar(int fazon, string fnev, string ftel)
        {
            this.fazon = fazon;
            this.fnev = fnev;
            this.ftel = ftel;
        }
        public override string ToString()
        {
            return $"{fazon} {fnev} {ftel}";
        }
    }
}