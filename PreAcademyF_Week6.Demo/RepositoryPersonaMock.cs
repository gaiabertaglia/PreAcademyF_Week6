using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Demo
{
    internal class RepositoryPersonaMock : IRepository<Persona>
    {
        private static List<Persona> persone = new List<Persona>();
        public bool Aggiungi(Persona item)
        {
            persone.Add(item);
            return true;
        }

        public bool Delete(Persona item)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetAll()
        {
            return persone;
        }

        public bool Update(Persona item)
        {
            throw new NotImplementedException();
        }
    }
}
