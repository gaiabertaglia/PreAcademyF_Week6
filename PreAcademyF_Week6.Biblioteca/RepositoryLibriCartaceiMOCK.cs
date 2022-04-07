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
            if (item != null)
            {
                var libroEsistente = GetByISBN(item.ISBN);
                if (libroEsistente == null)
                {
                    libriCartacei.Add(item);
                    return true;
                }
            }
            return false;
        }

        public List<LibroCartaceo> GetAll()
        {
            return libriCartacei;
        }

        public LibroCartaceo GetByISBN(int isbn)
        {
            foreach (var item in libriCartacei)
            {
                if(item.ISBN == isbn)
                {
                    return item;
                }
            }
            return null;
        }

        public LibroCartaceo GetByTitle(string titolo)
        {
            foreach (var item in libriCartacei)
            {
                if (item.Titolo == titolo)
                {
                    return item;
                }
            }
            return null;
        }

        public bool ModificaQuantita(int isbn, int nuovaQuantita)
        {
            var libroDaModificare = GetByISBN(isbn);
            if(libroDaModificare == null) {
                return false;
            }
            else
            {
                libroDaModificare.QuantitaInMagazzino = nuovaQuantita;
                return true;
            }
        }
    }
}
