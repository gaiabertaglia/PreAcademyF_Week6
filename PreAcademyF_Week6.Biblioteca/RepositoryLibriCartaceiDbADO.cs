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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool ModificaQuantita(int isbn, int nuovaQuantita)
        {
            throw new NotImplementedException();
        }
    }
}
