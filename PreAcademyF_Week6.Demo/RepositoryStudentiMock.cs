using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Demo
{
    internal class RepositoryStudentiMock : IRepository<Studente>
    {
        private static List<Studente> Studenti= new List<Studente>() { new Studente("Giuseppe","Verdi", new DateTime(1990, 01, 01))};
        public bool Aggiungi(Studente item)
        {
            Studenti.Add(item);
            return true;
        }

        public bool Delete(Studente item)
        {
            throw new NotImplementedException();
        }

        public List<Studente> GetAll()
        {
            return Studenti;
        }

        public bool Update(Studente item)
        {
            throw new NotImplementedException();
        }
    }
}
