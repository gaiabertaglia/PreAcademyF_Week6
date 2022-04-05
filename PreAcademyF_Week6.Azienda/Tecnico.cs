using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Azienda
{
    internal class Tecnico : Dipendente
    {
        public string CodiceFiscale { get; set; }
        public int PagaOraria { get; set; } = 10;

        public Tecnico()
        {

        }
        public Tecnico(string nome, string cognome, string codiceFiscale) : base(nome, cognome)
        {
            CodiceFiscale = codiceFiscale;
        }
        //public Tecnico(Dati dati): base(dati.Nome, dati.Cognome)
        //{
        //    CodiceFiscale = dati.CF;
        //}

        public Tecnico(string nome, string cognome, string codiceFiscale, int pagaBaseOraria) : base(nome, cognome)
        {
            CodiceFiscale = codiceFiscale;
            PagaOraria = pagaBaseOraria;
        }

        protected int CalcolaStipendio()
        {
            return 26 * 8 * PagaOraria;
        }

        public override void StampaStipendio()
        {
            Console.WriteLine($"Lo stipendio è: {CalcolaStipendio()}");
        }
        public override void StampaRuolo()
        {
            Console.WriteLine($"Il ruolo è : Tecnico");
        }
        public override void StampaFerie()
        {
            Console.WriteLine("Il tecnico ha 4 giorni di ferie");
        }

    }
}
