using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Demo
{
    public  class Persona : Object
    {
        //proprietà
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int  AnnoDiNascita { get; set; }
        public DateTime DataDiNascita { get; set; }

        public Persona()
        {

        }
        public Persona(string nome, string cognome, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            AnnoDiNascita = dataDiNascita.Year;
        }


        //Metodo
        public static void Saluta(Persona p)
        {
            Console.WriteLine($"Ciao, sono una PERSONA e mi chiamo: {p.Nome}");
        }

        public void Saluta()
        {
            Console.WriteLine($"Ciao, sono una PERSONA e mi chiamo: {Nome}");
        }

        public virtual void Saluta2()
        {
            Console.WriteLine($"Ciao2, sono una PERSONA e mi chiamo: {Nome}");
        }

        //public abstract void SalutaTutti();

        public override string ToString()
        {
            return $"{Nome} - {Cognome} nato il : {DataDiNascita.ToShortDateString()}";
        }

    }
}
