using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.FormeGeometriche
{
    internal class Cerchio: IForma
    {
        public double Raggio { get; set; }
        //private const double pi = 3.14;

        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }
        public  double CalcolaArea()
        {
            return Math.Pow(Raggio, 2) * Math.PI;
        }

        public  double CalcolaPerimetro()
        {
            return 2 * Raggio * Math.PI;
        }

        public override string ToString()
        {
            return $"Cerchio: Raggio={Raggio}";
        }
    }
}
