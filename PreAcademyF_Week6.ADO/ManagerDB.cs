using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.ADO
{
    internal class ManagerDB : IManager
    {

        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Cinema; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void GetAllFilms()
        {
            using (SqlConnection connessione = new SqlConnection(connectionString))
            {
                connessione.Open();

                SqlCommand comando = new SqlCommand("select * from Film", connessione);
                //SqlCommand comando = new SqlCommand();
                //comando.Connection = connessione;
                //comando.CommandType=CommandType.Text;
                //comando.CommandText = "select * from Film";

                SqlDataReader risultato = comando.ExecuteReader();

                while (risultato.Read())
                {
                    int id = (int)risultato["CodiceFilm"]; //risultato[0]
                    var titolo = risultato["Titolo"];
                    var genere = risultato["Genere"];
                    var durata = risultato["Durata"];
                    Film f = new Film();
                    f.FilmId = id;
                    f.Titolo = (string)titolo;
                    f.Genere = (string)genere;
                    f.Durata = (int)durata;
                    Console.WriteLine(f.ToString());
                }
                connessione.Close();

            }
        }

        public void GetFilmByGenere(string genere)
        {
            using (SqlConnection connessione = new SqlConnection(connectionString))
            {
                connessione.Open();

                SqlCommand comando = new SqlCommand("select * from Film where Genere=@g", connessione);
                //SqlCommand comando = new SqlCommand();
                //comando.Connection = connessione;
                //comando.CommandType=CommandType.Text;
                //comando.CommandText = "select * from Film";
                comando.Parameters.AddWithValue("@g", genere);
                

                SqlDataReader risultato = comando.ExecuteReader();

                while (risultato.Read())
                {
                    int id = (int)risultato["CodiceFilm"]; //risultato[0]
                    var titolo = risultato["Titolo"];
                    //var gen = risultato["Genere"];
                    var durata = risultato["Durata"];
                    Film f = new Film();
                    f.FilmId = id;
                    f.Titolo = (string)titolo;
                    f.Genere = genere;
                    f.Durata = (int)durata;
                    Console.WriteLine(f.ToString());
                }
                connessione.Close();

            }
        }
    }
}
