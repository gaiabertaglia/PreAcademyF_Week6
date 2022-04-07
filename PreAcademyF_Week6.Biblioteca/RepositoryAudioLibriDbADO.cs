using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal class RepositoryAudioLibriDbADO : IRepositoryAudiolibri
    {
        public bool Aggiungi(AudioLibro item)
        {
            throw new NotImplementedException();
        }

        public List<AudioLibro> GetAll()
        {
            throw new NotImplementedException();
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
