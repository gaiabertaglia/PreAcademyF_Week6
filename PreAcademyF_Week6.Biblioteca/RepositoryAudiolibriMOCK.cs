using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal class RepositoryAudiolibriMOCK : IRepositoryAudiolibri
    {
        private static List<AudioLibro> audiolibri = new List<AudioLibro>()
        {
            new AudioLibro("TitoloLibro1", "Autore1", 1, 10),
            new AudioLibro("TitoloLibro2", "Autore2", 2, 20)
        };

        public bool Aggiungi(AudioLibro item)
        {
            throw new NotImplementedException();
        }

        public List<AudioLibro> GetAll()
        {
            return audiolibri;
        }

        public AudioLibro GetByISBN(int isbn)
        {
            throw new NotImplementedException();
        }

        public bool ModificaDurata(int isbn, int nuovaDurata)
        {
            throw new NotImplementedException();
        }
    }
}
