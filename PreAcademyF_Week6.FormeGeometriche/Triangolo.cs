using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.FormeGeometriche
{
    internal class Triangolo : IForma
    {
        public double Base { get; set; }
        public double Altezza { get; set; }
        public double Cateto1 { get; set; }
        public double Cateto2 { get; set; }

        public Triangolo(double baseTriangolo, double altezza, double cateto1, double cateto2)
        {
            Base = baseTriangolo;
            Altezza = altezza;
            Cateto1 = cateto1;
            Cateto2 = cateto2;

        }

        public double CalcolaArea()
        {
            return Base * Altezza / 2;
        }

        public double CalcolaPerimetro()
        {
            return Base + Cateto1 + Cateto2;
        }
        public override string ToString()
        {
            return $"Triangolo: base={Base} \tAltezza={Altezza} \tCateto1={Cateto1} \tCateto2={Cateto2}";
        }

    }
}
