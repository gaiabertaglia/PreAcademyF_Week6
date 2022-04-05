using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Calcio
{
    internal class Portiere : Calciatore
    {
        public int GoalSubiti { get; set; } = 0;

        //public Portiere(string nome, string cognome, int eta/*, int numeroMaglia, Ruolo ruolo*/)
        //    : base(nome, cognome, eta, 1, Ruolo.Portiere)
        //{

        //}
        public Portiere(string nome, string cognome, int eta, int numeroMaglia=1)
           : base(nome, cognome, eta, numeroMaglia, Ruolo.Portiere)
        {

        }
    }
}
