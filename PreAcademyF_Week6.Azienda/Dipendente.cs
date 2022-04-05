using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Azienda
{
    internal abstract class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Dipendente()
        {

        }
        public Dipendente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public void StampaDatiAnagrafici()
        {
            Console.WriteLine($"Nome: {Nome} \t Cognome: {Cognome}");
        }
        public virtual void StampaRuolo()
        {
            Console.WriteLine("Il ruolo è: Dipendente");
        }
        public abstract void StampaStipendio();

        public virtual void StampaFerie()
        {
            Console.WriteLine("Il dipendente ha 2 giorni di ferie");
        }
    }
}
