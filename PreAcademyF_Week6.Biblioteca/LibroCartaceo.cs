using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal class LibroCartaceo : Libro
    {
        public int NumeroDiPagine { get; set; }
        public int QuantitaInMagazzino { get; set; }

        public LibroCartaceo()
        {

        }

        public LibroCartaceo(string titolo, string autore, int isbn, int numPagine, int qtaMagazzino)
            :base(titolo, autore, isbn)
        {
            NumeroDiPagine=numPagine;
            QuantitaInMagazzino=qtaMagazzino;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t Pagine={NumeroDiPagine} \t Scorte:{QuantitaInMagazzino} \tTipo: {GetType().Name}";
        }
    }
}
