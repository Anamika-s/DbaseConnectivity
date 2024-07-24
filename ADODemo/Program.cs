// step 1
using System.Data.SqlClient;

namespace ADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // step 2
            // connectioString = server name ; database ; credentials
            SqlConnection connection = new SqlConnection("server=ANAMIKA\\SQLSERVER;database=practDb;integrated security=true");
            SqlCommand command = new SqlCommand("select * from Employee", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }
                
            }
            else
            {
                Console.WriteLine("there are no records");
            }
            connection.Close();
            command = new SqlCommand("insert into employee(id, name, address) " +
                "values(2,'Vijay','Odelhi')", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
