using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florae_Basket
{
    class LoginController
    {
        public LoginController(int userAcctType, string user, string pass) {
            
            /* 
            DatabaseManager dbMngr = new DatabaseManager();
            if (dbMngr.checkUsername(user))
            */

        }
        /*
        // checks if a username already exists in the database
        public bool checkUsername(string username)
		{
			bool used = false;
			conn.Open();
			string query = "SELECT UserName FROM [User]";
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();

			while (read.Read())
			{
				if (read.GetString(0) == username)
				{
					used = true;
					break;
				}
			}
			read.Close();
			conn.Close();
			return used;
		}

        public string FetchPassword(string username)
        {
            string result;
            conn.Open();
            string query = "SELECT Password FROM [User] WHERE UserName = @user";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.Add("@user", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@user"].Value = username;
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            result = read.GetString(0);
            read.Close();
            conn.Close();
            return result;
        }

        public string Fetchfirst(string username)
        {
            string result;
            conn.Open();
            string query = "SELECT FirstName FROM [User] WHERE UserName = @user";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.Add("@user", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@user"].Value = username;
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            result = read.GetString(0);
            read.Close();
            conn.Close();
            return result;
        }

        public string FetchLast(string username)
        {
            string result;
            conn.Open();
            string query = "SELECT LastName FROM [User] WHERE UserName = @user";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.Add("@user", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@user"].Value = username;
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            result = read.GetString(0);
            read.Close();
            conn.Close();
            return result;
        }

        public string Fetchaccttype(string username)
        {
            string result;
            conn.Open();
            string query = "SELECT AccountType FROM [User] WHERE UserName = @user";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.Add("@user", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@user"].Value = username;
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            result = read.GetString(0);
            read.Close();
            conn.Close();
            return result;
        }

        public bool addUser(string first, string last, string username, string password, string accType)
		{
            try
            {
                conn.Open();
                string query = "INSERT INTO [User] (UserName, Password, FirstName, LastName, AccountType) VALUES (@user, @pass, @first, @last, @type)";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Parameters.Add("@first", System.Data.SqlDbType.NVarChar);
                comm.Parameters.Add("@last", System.Data.SqlDbType.NVarChar);
                comm.Parameters.Add("@user", System.Data.SqlDbType.NVarChar);
                comm.Parameters.Add("@pass", System.Data.SqlDbType.NVarChar);
                comm.Parameters.Add("@type", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@first"].Value = first;
                comm.Parameters["@last"].Value = last;
                comm.Parameters["@user"].Value = username;
                comm.Parameters["@pass"].Value = password;
                comm.Parameters["@type"].Value = accType;
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
		} 
        */
    }
}
