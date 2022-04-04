using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Demo
{
    internal static class ClasseStatica
    {
        public static string Nome { get; set; } = "Nome della classe statica";
        public static List<string> Parole { get; set; } = new List<string>() { "parola1", "parola2", "parola3" };

        public static void SalutaDaClasseStatica()
        {
            Console.WriteLine("Ciao da parte della Classe statica!");
        }
    }
}
