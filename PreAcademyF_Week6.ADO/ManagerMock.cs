using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.ADO
{
    internal class ManagerMock : IManager
    {
        static List<Film> Films = new List<Film>()
        {
            new Film{FilmId=1, Titolo="Titanic", Durata=240, Genere="Storico"},
            new Film{FilmId=2, Titolo="Peter Pan", Durata=60, Genere="Animazione"}
        };

        public void GetAllFilms()
        {
            foreach (var item in Films)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void GetFilmByGenere(string genere)
        {
            foreach (var item in Films)
            {
                if(item.Genere == genere)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
