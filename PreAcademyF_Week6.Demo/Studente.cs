using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Demo
{
    internal class Studente : Persona
    {
        private static int MatricolaPartenza = 10000;

        public int Matricola { get; set; }

        //public int MYPROPERTY { get; set; }


        public Studente()
        {

        }
        public Studente(string nomeStudente, string cognomeStudente, DateTime dataDiNascitaStudente)
            :base(nomeStudente, cognomeStudente, dataDiNascitaStudente) //richiamo il costruttore del padre passando i parametri 
        {            
            Matricola = MatricolaPartenza;
            MatricolaPartenza++;
        }

        //public void Metodo(int MYPROPERTY)
        //{
        //    this.MYPROPERTY = MYPROPERTY; //per distinguere le proprietà dai parametri
        //}

        public new void Saluta() // se il metodo NON è marcato come virtual nel padre
        {
            Console.WriteLine($"Ciao, sono una STUDENTE e mi chiamo: {Nome}");
        }

        public override void Saluta2() // se il metodo è marcato come virtual nel padre
        {
            Console.WriteLine($"Ciao2, sono una STUDENTE e mi chiamo: {Nome}");
        }

        //public override void SalutaTutti()
        //{
        //    Console.WriteLine($"Ciao a tutti");
        //}

        public override string ToString()
        {
            return base.ToString() + $"Matricola: {Matricola}";
        }
    }
}
