using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Calcio
{
    internal abstract class Atleta
    {
        public string  Nome { get; set; }
        public string  Cognome { get; set; }
        public int  Eta { get; set; }

        public Atleta(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }
    }
}
