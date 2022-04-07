using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal class RepositoryLibriCartaceiMOCK : IRepositoryLibriCartacei
    {
        private static List<LibroCartaceo> libriCartacei = new List<LibroCartaceo>()
        {
            new LibroCartaceo("TitoloLibro1", "Autore1", 100, 1000, 11),
            new LibroCartaceo("TitoloLibro2", "Autore2", 200, 2000, 22)
        };
        public bool Aggiungi(LibroCartaceo item)
        {
            throw new NotImplementedException();
        }

        public List<LibroCartaceo> GetAll()
        {
            return libriCartacei;
        }

        public LibroCartaceo GetByISBN(int isbn)
        {
            throw new NotImplementedException();
        }

        public bool ModificaQuantita(int isbn, int nuovaQuantita)
        {
            throw new NotImplementedException();
        }
    }
}
