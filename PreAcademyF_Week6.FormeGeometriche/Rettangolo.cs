using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.FormeGeometriche
{
    internal class Rettangolo : IForma
    {

        public double Base { get; set; }
        public double Altezza { get; set; }
        

        public Rettangolo(double b, double h)
        {
            Base = b;
            Altezza = h;
        }

        public double CalcolaArea()
        {
            return Base * Altezza;
        }

        public double CalcolaPerimetro()
        {
            return (Base + Altezza) * 2;
        }

        public override string ToString()
        {
            return $"Rettangolo: base={Base} \tAltezza={Altezza}";
        }

    }
}
