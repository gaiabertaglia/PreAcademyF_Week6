using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Demo
{
    internal class Docente : Persona
    {
        public int AnniServizio { get; set; }

        public Docente()
        {

        }
        public Docente(string nome, string cognome, DateTime dataNascita, int anniDiServizio) 
            :base(nome, cognome, dataNascita)
        {
            AnniServizio = anniDiServizio;
        }
        //public override void SalutaTutti()
        //{
        //    Console.WriteLine("Ciao a tutti. Sono il docente");
        //}

        public override void Saluta2()
        {
            Console.WriteLine($"Ciao2, sono un DOCENTE e mi chiamo: {Nome}");
        }

        public override string ToString()
        {
            return base.ToString() + $" Anni di servizio: {AnniServizio}";
        }
    }
}
