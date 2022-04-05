using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Calcio
{
    internal class Attaccante : Calciatore
    {
        public int GoalFatti { get; set; } = 0;

        public Attaccante(string nome, string cognome, int eta, int numeroMaglia)
            : base(nome, cognome, eta, numeroMaglia, Ruolo.Attaccante)
        {
        }
    }
}
