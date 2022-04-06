using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.ADO
{
    internal interface IManager
    {
        void GetAllFilms();
        void GetFilmByGenere(string genere);

        void GetFilmByTitolo(string titolo);
        
        /// Restituisce i film del genere passato in input che hanno una duarata superione a durataMin passata in input
        /// </summary>
        /// <param name="genere"></param>
        /// <param name="durataMin"></param>
        void GetFilmByGenereEDurataMinoreDi(string genere, int durata);

        /// <summary>
        /// Restituisce i film con durata minore della durataMax passata in input. 
        /// </summary>
        /// <param name="durataMax"></param>
        void GetFilmByDurataMaggioreDi(int durata);
        void GetNumeroDiFilm();

        void InserisciFilm(string titolo, string genere, int durata);
        void ModificaDurataFilm(int idFilm, int nuovaDurata);
        void EliminaFilm(int idFilmDaEliminare);
    }
}
