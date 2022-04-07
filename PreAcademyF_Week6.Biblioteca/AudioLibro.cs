using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal class AudioLibro :Libro
    {
        public int DurataInMinuti { get; set; }

        public AudioLibro()
        {

        }
        public AudioLibro(string titolo, string autore, int isbn, int durataInMinuti)
            : base(titolo, autore, isbn)
        {
            DurataInMinuti=durataInMinuti;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t Durata={DurataInMinuti} minuti \tTipo: {GetType().Name}";
        }
    }
}
