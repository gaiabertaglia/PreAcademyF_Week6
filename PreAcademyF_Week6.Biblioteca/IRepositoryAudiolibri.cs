using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal interface IRepositoryAudiolibri : IRepository<AudioLibro>
    {
        bool ModificaDurata(int isbn, int nuovaDurata);

    }
}
