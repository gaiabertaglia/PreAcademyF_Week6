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

        public void GetFilmByDurataMaggioreDi(int durata)
        {
            foreach (var item in Films)
            {
                if (item.Durata > durata)
                {
                    Console.WriteLine(item.ToString());
                }
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

        public void GetFilmByGenereEDurataMinoreDi(string genere, int durataMin)
        {
            foreach (var item in Films)
            {
                if (item.Genere == genere && item.Durata< durataMin)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public void GetFilmByTitolo(string titolo)
        {
            foreach (var item in Films)
            {
                if (item.Titolo == titolo)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public void GetNumeroDiFilm()
        {
            Console.WriteLine($"Ci sono {Films.Count} film");
        }

        public void InserisciFilm(string titolo, string genere, int durata)
        {
            int maxId = 0;
            foreach (var item in Films)
            {
                if (item.FilmId > maxId)
                {
                    maxId = item.FilmId;
                }
            }
            Film film = new Film();
            film.FilmId = maxId + 1;
            film.Durata = durata;
            film.Titolo = titolo;
            film.Genere = genere;
            Films.Add(film);
            Console.WriteLine($"Aggiunto il film {film.ToString()}");
        }

        public void ModificaDurataFilm(int idFilm, int nuovaDurata)
        {
            foreach(var item in Films)
            {
                if (item.FilmId == idFilm)
                {
                    item.Durata = nuovaDurata;                    
                }
            }            
            Console.WriteLine($"Film modificato");            
        }

        public void EliminaFilm(int idFilmDaEliminare)
        {
            foreach (var item in Films)
            {
                if (item.FilmId == idFilmDaEliminare)
                {
                    Films.Remove(item);
                }
            }
            Console.WriteLine($"Film eliminato");
        }
    }
}
