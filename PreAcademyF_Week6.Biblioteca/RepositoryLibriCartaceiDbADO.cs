using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyF_Week6.Biblioteca
{
    internal class RepositoryLibriCartaceiDbADO : IRepositoryLibriCartacei
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool Aggiungi(LibroCartaceo item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "insert into LibroCartaceo values(@Titolo, @Autore,@isbn, @NumPag, @Quantita)";
                command.Parameters.AddWithValue("@Titolo", item.Titolo);
                command.Parameters.AddWithValue("@Autore", item.Autore);
                command.Parameters.AddWithValue("@isbn", item.ISBN);
                command.Parameters.AddWithValue("@NumPag", item.NumeroDiPagine);
                command.Parameters.AddWithValue("@Quantita", item.QuantitaInMagazzino);

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

        public List<LibroCartaceo> GetAll()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from Librocartaceo", connection);

                SqlDataReader tabelleRisultato= cmd.ExecuteReader();

                List<LibroCartaceo> libriCartacei=new List<LibroCartaceo>();
                while (tabelleRisultato.Read())
                {
                    var titolo=(string)tabelleRisultato["Titolo"];
                    var autore=(string)tabelleRisultato["Autore"];
                    var isbn=(int)tabelleRisultato["ISBN"];
                    var qta=(int)tabelleRisultato["QuantitaMagazzino"];
                    var numP=(int)tabelleRisultato["NumeroPagine"];

                    LibroCartaceo libro = new LibroCartaceo(titolo, autore, isbn, numP, qta);
                    libriCartacei.Add(libro);
                }
                connection.Close();
                return libriCartacei;

            }
        }

        public LibroCartaceo GetByISBN(int isbn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from LibroCartaceo where ISBN = @isbn";
                command.Parameters.AddWithValue("@isbn", isbn);

                SqlDataReader reader = command.ExecuteReader();

                LibroCartaceo libroCartaceo = null;

                while (reader.Read())
                {
                    string titolo = (string)reader["Titolo"];
                    string autore = (string)reader["Autore"];
                    var isbn1 = (int)reader["ISBN"];
                    var qta = (int)reader["QuantitaMagazzino"];
                    var numP = (int)reader["NumeroPagine"];

                    libroCartaceo = new LibroCartaceo(titolo, autore, isbn1, numP, qta);
                }
                connection.Close();
                return libroCartaceo;
            }
        }

        public LibroCartaceo GetByTitle(string titolo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from LibroCartaceo where Titolo = @titolo";
                command.Parameters.AddWithValue("@titolo", titolo);

                SqlDataReader reader = command.ExecuteReader();

                LibroCartaceo libroCartaceo = null;

                while (reader.Read())
                {
                    string autore = (string)reader["Autore"];
                    var isbn = (int)reader["ISBN"];
                    var qta = (int)reader["QuantitàMagazzino"];
                    var numP = (int)reader["NumeroPagine"];

                    libroCartaceo = new LibroCartaceo(titolo, autore, isbn, numP, qta);
                }
                connection.Close();
                return libroCartaceo;
            }
        }

        public bool ModificaQuantita(int isbn, int nuovaQuantita)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "update LibroCartaceo set QuantitaMagazzino = @qta where ISBN = @Isbn";
                command.Parameters.AddWithValue("@Isbn", isbn);
                command.Parameters.AddWithValue("@qta", nuovaQuantita);

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
