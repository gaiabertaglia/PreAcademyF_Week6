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
                    var id = risultato["CodiceFilm"]; //risultato[0]
                    var titolo = risultato["Titolo"];
                    var genere = risultato["Genere"];
                    var durata = risultato["Durata"];
                    Film f = new Film();
                    f.FilmId = (int)id;
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

        public void GetFilmByDurataMaggioreDi(int durata)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Film where Durata<@d";
                command.Parameters.AddWithValue("@d", durata);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader["FilmId"];
                    var genere = reader["Genere"];
                    var titolo = reader["Titolo"];
                    var dur = reader["Durata"];

                    Film f = new Film();
                    f.FilmId = (int)id;
                    f.Titolo = (string)titolo;
                    f.Genere = (string)genere;
                    f.Durata = (int)dur;
                    Console.WriteLine(f.ToString());
                }
                connection.Close();
            }
        }

       

        public void GetFilmByGenereEDurataMinoreDi(string genere, int durata)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Film where Genere=@g and Durata>@d";
                command.Parameters.AddWithValue("@g", genere);
                command.Parameters.AddWithValue("@d", durata);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader["FilmId"];
                    var titolo = reader["Titolo"];
                    var dur = reader["Durata"];

                    Film f = new Film();
                    f.FilmId = (int)id;
                    f.Titolo = (string)titolo;
                    f.Genere = genere;
                    f.Durata = (int)dur;
                    Console.WriteLine(f.ToString());
                }
                connection.Close();
            }
        }


        public void GetFilmByTitolo(string titolo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from Film where Titolo= @t";
                command.Parameters.AddWithValue("@t", titolo);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader["FilmId"];
                    var genere = reader["Genere"];
                    var durata = reader["Durata"];

                    Film f = new Film();
                    f.FilmId = (int)id;
                    f.Titolo = titolo;
                    f.Genere = (string)genere;
                    f.Durata = (int)durata;
                    Console.WriteLine(f.ToString());
                }
                connection.Close();
            }
        }

        public void GetNumeroDiFilm()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "select count(*) from Film ";
                //command.CommandText = "select * from Film";                
                //SqlDataReader reader = command.ExecuteReader();
                //int numFilm = 0;
                //while (reader.Read())
                //{
                //    numFilm++;
                //}

                int numFilm = (int)command.ExecuteScalar();

                Console.WriteLine($"ci sono {numFilm} film nella videoteca");
                connection.Close();
            }
        }

        public void InserisciFilm(string titolo, string genere, int durata)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Film values(@Titolo, @Genere, @Durata)";
                command.Parameters.AddWithValue("@Titolo", titolo);
                command.Parameters.AddWithValue("@Durata", durata);
                command.Parameters.AddWithValue("@Genere", genere);

                int rigaInserita = command.ExecuteNonQuery();

                if (rigaInserita == 1)
                {
                    Console.WriteLine("Film inserito correttamente");
                }
                else
                {
                    Console.WriteLine("Errore. Non è stato possibile inserire il film.");
                }
                connection.Close();
            }
        }

        public void ModificaDurataFilm(int idFilm, int nuovaDurata)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "update Film set Durata=@Durata where CodiceFilm=@Codice";
                command.Parameters.AddWithValue("@Durata", nuovaDurata);
                command.Parameters.AddWithValue("@Codice", idFilm);

                int rigaAggiornata = command.ExecuteNonQuery();

                if (rigaAggiornata == 1)
                {
                    Console.WriteLine("Film aggiornato correttamente");
                }
                else
                {
                    Console.WriteLine("Errore. Non è stato possibile aggiornare il film.");
                }
                connection.Close();
            }
        }
        public void EliminaFilm(int idFilmDaEliminare)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "Delete Film where FilmId=@Id";
                command.Parameters.AddWithValue("@Id", idFilmDaEliminare);

                int rigaInserita = command.ExecuteNonQuery();
                if (rigaInserita == 1)
                {
                    Console.WriteLine("Film eliminato correttamente");
                }
                else
                {
                    Console.WriteLine("Errore.Non è stato possibile eliminare il Film. Ricontrolla i dati inseriti!");
                }
                connection.Close();
            }
        }
    }
}
