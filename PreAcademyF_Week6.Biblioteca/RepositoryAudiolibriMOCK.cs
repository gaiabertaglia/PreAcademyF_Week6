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
            if (item != null)
            {
                var libroEsistente = GetByISBN(item.ISBN);
                if (libroEsistente == null)
                {
                    audiolibri.Add(item);
                    return true;
                }
            }
            return false;
        }

        public List<AudioLibro> GetAll()
        {
            return audiolibri;
        }

        public AudioLibro GetByISBN(int isbn)
        {
            foreach (var item in audiolibri)
            {
                if (item.ISBN == isbn)
                {
                    return item;
                }
            }
            return null;
        }

        public AudioLibro GetByTitle(string titolo)
        {
            foreach (var item in audiolibri)
            {
                if (item.Titolo == titolo)
                {
                    return item;
                }
            }
            return null;
        }

        public bool ModificaDurata(int isbn, int nuovaDurata)
        {
            var audiolibroDaModificare = GetByISBN(isbn);
            if (audiolibroDaModificare == null)
            {
                return false;
            }
            else
            {
                audiolibroDaModificare.DurataInMinuti = nuovaDurata;
                return true;
            }
        }
    }
}
