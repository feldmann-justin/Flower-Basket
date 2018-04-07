using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Florae_Basket
{
    public class Database_Manager
    {
        //This is the connection object
        public SqlConnection conn = new SqlConnection();
        public Database_Manager()
        {
            //connection string DO NOT CHANGE/REMOVE!!!
            conn.ConnectionString = @"Data Source =(localDB)\MSSQLLocalDB;" +
                @"AttachDbFilename = |DataDirectory|\Flowers.mdf;" +
                "Integrated Security = True;" +
                "Connect Timeout = 30";
            
        }

        //Inserts flower into database
        public void InsertFlower(string name, string latin, string botan, string note, string images)
        {
            conn.Open();
            int flowerid = -1;
            string query = "INSERT INTO Flower (English, Latin, Botanical) VALUES ('"
                + name + "', '" + latin + "', '" + botan + "')";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            query = "Select id FROM Flower WHERE English = '" + name + "'";
            comm = new SqlCommand(query, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            flowerid = read.GetInt32(0);
            read.Close();
            query = "INSERT INTO Images (Filepath, Histogram, FlowerID) VALUES ('"
                + images + "', " + "1, '" + flowerid + "')";
            comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteFlower(int id)
        {
            conn.Open();
            string query = "DELETE FROM Note WHERE FlowerID = " + id;
            SqlCommand comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public string FetchEnglish(int id)
        {
            conn.Open();
            string temp;
            string query = "SELECT English FROM Flower WHERE id = " + id;
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            temp = read.GetString(0);
            conn.Close();
            return temp;
        }

        public string FetchLatin(int id)
        {
            conn.Open();
            string temp;
            string query = "SELECT Latin FROM Flower WHERE id = " + id;
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            temp = read.GetString(0);
            conn.Close();
            return temp;
        }

        public string FetchBotan(int id)
        {
            conn.Open();
            string temp;
            string query = "SELECT Botanical FROM Flower WHERE id = " + id;
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            temp = read.GetString(0);
            conn.Close();
            return temp;
        }
    }
}
