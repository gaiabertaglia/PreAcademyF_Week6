using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Azienda
{
    internal class Stagista : Dipendente
    {
        public int CompensoMensile { get; set; } = 600;

        public Stagista()
        {

        }
        public Stagista(string nome, string cognome): base(nome, cognome)
        {

        }

        public Stagista(string nome, string cognome, int compenso): base(nome, cognome)
        {
            CompensoMensile = compenso;
        }

        public override void StampaStipendio()
        {
            Console.WriteLine($"Lo stipendio è di {CompensoMensile} euro");
        }

        public override void StampaRuolo()
        {
            Console.WriteLine($"Il ruolo è : Stagista");
        }
        public override void StampaFerie()
        {
            Console.WriteLine("Lo stagista ha 5 giorni di ferie");
        }
    }
}
