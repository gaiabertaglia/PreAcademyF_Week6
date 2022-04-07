using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal class RepositoryAudioLibriDbADO : IRepositoryAudiolibri
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool Aggiungi(AudioLibro item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into dbo.Audiolibro values(@Titolo, @Autore,@isbn,@DurataMin)";
                command.Parameters.AddWithValue("@Titolo", item.Titolo);
                command.Parameters.AddWithValue("@Autore", item.Autore);
                command.Parameters.AddWithValue("@isbn", item.ISBN);
                command.Parameters.AddWithValue("@DurataMin", item.DurataInMinuti);

                int numRighe = command.ExecuteNonQuery();
                if (numRighe == 1)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
        }

        public List<AudioLibro> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from dbo.Audiolibro";

                SqlDataReader reader = command.ExecuteReader();

                List<AudioLibro> audiolibri = new List<AudioLibro>();

                while (reader.Read())
                {
                    string titolo = (string)reader["Titolo"];
                    string autore = (string)reader["Autore"];
                    var isbn = (int)reader["ISBN"];
                    var durataMinuti = (int)reader["DurataMinuti"];

                    AudioLibro al = new AudioLibro(titolo, autore, isbn, durataMinuti);
                    audiolibri.Add(al);
                }
                connection.Close();

                return audiolibri;
            }
        }

        public AudioLibro GetByISBN(int isbn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Audiolibro where ISBN = @isbn";
                command.Parameters.AddWithValue("@isbn", isbn);

                SqlDataReader reader = command.ExecuteReader();

                AudioLibro audiolibro = null;

                while (reader.Read())
                {
                    string tit = (string)reader["Titolo"];
                    string autore = (string)reader["Autore"];
                    var isbn1 = (int)reader["ISBN"];
                    var durataMinuti = (int)reader["DurataMinuti"];

                    audiolibro = new AudioLibro(tit, autore, isbn1, durataMinuti);
                }
                connection.Close();
                return audiolibro;
            }
        }

        public AudioLibro GetByTitle(string titolo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from Audiolibro where Titolo = @Titolo";
                command.Parameters.AddWithValue("@Titolo", titolo);

                SqlDataReader reader = command.ExecuteReader();

                AudioLibro audiolibro = null;

                while (reader.Read())
                {
                    string tit = (string)reader["Titolo"];
                    string autore = (string)reader["Autore"];
                    var isbn = (int)reader["ISBN"];
                    var durataMinuti = (int)reader["DurataInMinuti"];

                    audiolibro = new AudioLibro(tit, autore, isbn, durataMinuti);
                }
                connection.Close();
                return audiolibro;
            }
        }

        public bool ModificaDurata(int isbn, int nuovaDurata)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "update dbo.Audiolibro set DurataMinuti = @DurataInMinuti where ISBN = @Isbn";
                command.Parameters.AddWithValue("@Isbn", isbn);
                command.Parameters.AddWithValue("@DurataInMinuti", nuovaDurata);

                int numRighe = command.ExecuteNonQuery();
                if (numRighe == 1)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
        }
    }
}
