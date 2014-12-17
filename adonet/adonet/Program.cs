using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace adonet
{
    class Program
    {
        public static string ConnectionString;
        static void Main(string[] args)
        {
            string connectionString = @"Data source=(localdb)\v11.0;Initial Catalog=IngesupLesson;Integrated Security = True";

            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();
            Console.WriteLine("Connexion etablie !");

            SqlCommand allStudentsCommand = new SqlCommand("select * from Students", connection);
            SqlDataReader reader = allStudentsCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Prenom: {0} ; Nom : {1}; Age: {2}",
                    reader["FirstName"], reader["Name"], reader["Age"]);

                reader.Close();
                connection.Close();
            }
        }
    }
}
