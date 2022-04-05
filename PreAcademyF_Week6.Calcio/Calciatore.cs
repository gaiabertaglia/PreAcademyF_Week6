using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Calcio
{
    internal class Calciatore : Atleta
    {
        public int NumeroMaglia { get; set; }
        public Ruolo Ruolo { get; set; }

        public Calciatore(string nome, string cognome, int eta, int numeroMaglia, Ruolo ruolo) :base(nome, cognome, eta)
        {
            NumeroMaglia = numeroMaglia;
            Ruolo = ruolo;
        }

        public override string ToString()
        {
            return $"Maglia n. {NumeroMaglia} - {Nome} {Cognome} - ruolo {Ruolo}";
        }
    }
    enum Ruolo
    {
        Attaccante,
        Centrocapista,
        Difensore,
        Portiere
    }
}
