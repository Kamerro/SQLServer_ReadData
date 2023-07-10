using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
//using is needed for provide proper sql classes
using System.Data.SqlClient;

namespace SQLServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Connection string that is needed for open connection 
            string connectionString = "Data Source=LAPTOP\\TESTINSTANCE;Initial Catalog=pluto;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            //Making connection
            SqlConnection conn = new SqlConnection(connectionString);
           //Making query
            string command = "Select * from dbo.Authors";
            //Opening connection
            conn.Open();
            //After opening connection there is need for create command (connect command and connection string)
            SqlCommand cmd = new SqlCommand(command, conn);
            //Creating instance of reader 
            SqlDataReader reader = cmd.ExecuteReader();
            //Read data one by one row
            while (reader.Read())
            {
                //Here we read data from sql 
                // access your data through reader, for example:
                Console.WriteLine(reader[1].ToString()); // this will print the first column of each row
            }
            //NEED to close the connection
            conn.Close();
            Console.ReadKey();
        }
    }
}
