using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Demo
{
    internal interface IRepository<T> 
    {
        bool Aggiungi(T item);
        bool Update(T item);
        bool Delete(T item);
        List<T> GetAll();
    }
}
