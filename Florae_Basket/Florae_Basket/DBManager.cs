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
			string query = "INSERT INTO Flower (English, Latin, Botanical) VALUES (@name, @latin, @botan)";
			SqlCommand comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
			comm.Parameters.Add("@latin", System.Data.SqlDbType.NVarChar);
			comm.Parameters.Add("@botan", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@name"].Value = name;
			comm.Parameters["@latin"].Value = latin;
			comm.Parameters["@botan"].Value = botan;
			comm.ExecuteNonQuery();
			query = "Select Id FROM Flower WHERE English = @name";
			comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@name"].Value = name;
			SqlDataReader read = comm.ExecuteReader();
			read.Read();
			flowerid = read.GetInt32(0);
			read.Close();
			query = "INSERT INTO Images (Filepath, Histogram, FlowerID) VALUES (@images, 1, " + flowerid +
				///////ADD HISTOGRAM VALUE LATER***////////
				")";
			////////////////////^//////////////////////
			comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@images", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@images"].Value = images;
			comm.ExecuteNonQuery();
			query = "INSERT INTO Note (FlowerId, Contents) VALUES (" + flowerid + ", @note)";
			comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@note", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@note"].Value = note;
			comm.ExecuteNonQuery();
			conn.Close();
		}

		public void DeleteFlower(int id)
		{
			conn.Open();
			string query = "DELETE FROM Note WHERE FlowerID = " + id;
			SqlCommand comm = new SqlCommand(query, conn);
			comm.ExecuteNonQuery();
			query = "DELETE FROM Images WHERE FlowerID = " + id;
			comm = new SqlCommand(query, conn);
			comm.ExecuteNonQuery();
			query = "DELETE FROM Flower WHERE Id = " + id;
			comm = new SqlCommand(query, conn);
			comm.ExecuteNonQuery();
			conn.Close();
		}

		//Returns a string containing the english name of the flower whos ID was provided
		public string FetchEnglish(int id)
		{
			conn.Open();
			string temp;
			string query = "SELECT English FROM Flower WHERE Id = " + id;
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();
			read.Read();
			temp = read.GetString(0);
			read.Close();
			conn.Close();
			return temp;
		}

		//Returns a string containing the latin name of the flower whos ID was provided
		public string FetchLatin(int id)
		{
			conn.Open();
			string temp;
			string query = "SELECT Latin FROM Flower WHERE Id = " + id;
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();
			read.Read();
			temp = read.GetString(0);
			read.Close();
			conn.Close();
			return temp;
		}

		//Returns a string containing the botanical family of the flower whos ID was provided
		public string FetchBotan(int id)
		{
			conn.Open();
			string temp;
			string query = "SELECT Botanical FROM Flower WHERE Id = " + id;
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();
			read.Read();
			temp = read.GetString(0);
			read.Close();
			conn.Close();
			return temp;
		}

		//Checks which type of name is requested, either "English", "Latin", or "Botanical
		//This type is inserted into the SQL query 
		//The requested string and flowerID is returned and put into the candidate object.
		public void FetchAllNames(ref LinkedList<Candidate> list, string type)
		{
			Candidate temp = new Candidate();
			conn.Open();
			string query = "SELECT " + type + " , Id FROM FLOWER";
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();
			while (read.Read())
			{
				temp.id = read.GetInt32(1);
				temp.contents = read.GetString(0);
				list.AddLast(temp);
			}
			read.Close();
			conn.Close();
		}

		public void FetchAllNotes(string entry, ref LinkedList<Candidate> list)
		{
			Candidate temp = new Candidate();
			conn.Open();
			string query = "SELECT Contents, FlowerID FROM Note WHERE Contents LIKE '%" + entry + "%';";
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();
			while (read.Read())
			{
				temp.id = read.GetInt32(1);
				temp.contents = read.GetString(0);
				list.AddLast(temp);
			}
			read.Close();
			conn.Close();
		}

		public string FetchNote(int id)
		{
			string temp;
			conn.Open();
			string query = "SELECT Contents FROM Note WHERE FlowerID = " + id;
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();
			read.Read();
			temp = read.GetString(0);
			read.Close();
			conn.Close();
			return temp;
		}

		public string FetchFilePath(int id)
		{
			string temp;
			conn.Open();
			string query = "SELECT Filepath FROM Images WHERE FlowerID = " + id;
			SqlCommand comm = new SqlCommand(query, conn);
			SqlDataReader read = comm.ExecuteReader();
			read.Read();
			temp = read.GetString(0);
			read.Close();
			conn.Close();
			return temp;
		}

		public int FetchID(string knownLatinName)
		{

			conn.Open();
			int tempInt;
			string query = "SELECT Id FROM Flower WHERE Latin = @latin";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.Add("@latin", System.Data.SqlDbType.NVarChar);
			cmd.Parameters["@latin"].Value = knownLatinName;
			cmd.ExecuteReader().Read();
			tempInt = cmd.ExecuteReader().GetInt32(0);
			cmd.ExecuteReader().Close();
			conn.Close();

			return tempInt;


		}

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

		public void changeLatinName(string latinChange, int primaryKey)
		{
			conn.Open();
			string query = "UPDATE Flower SET Latin = @latin WHERE Id = " + primaryKey;
			SqlCommand comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@latin", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@latin"].Value = latinChange;
			comm.ExecuteNonQuery();
			conn.Close();


		}

		public void changeEnglishName(string englishChange, int primaryKey)
		{
			conn.Open();
			string query = "UPDATE Flower SET English = @name WHERE Id = " + primaryKey;
			SqlCommand comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@name"].Value = englishChange;
			comm.ExecuteNonQuery();
			conn.Close();

		}

		public void changeBotanicalFam(string botanChange, int primaryKey)
		{
			conn.Open();
			string query = "UPDATE Flower SET Botanical = @botan WHERE Id = " + primaryKey;
			SqlCommand comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@botan", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@botan"].Value = botanChange;
			comm.ExecuteNonQuery();
			conn.Close();


		}
		public void changeNote(string noteChange, int primaryKey)
		{
			conn.Open();
			string query = "UPDATE Note SET Contents = @note WHERE Id = " + primaryKey;
			SqlCommand comm = new SqlCommand(query, conn);
			comm.Parameters.Add("@note", System.Data.SqlDbType.NVarChar);
			comm.Parameters["@note"].Value = noteChange;
			comm.ExecuteNonQuery();
			conn.Close();


		}

		//public void changeImgPath(string imgPathChange, int primaryKey)
		//{
		//	conn.Open();
		//	string query = "UPDATE Images SET Filepath = @botan WHERE Id = " + primaryKey;
		//	SqlCommand comm = new SqlCommand(query, conn);
		//	comm.Parameters.Add("@botan", System.Data.SqlDbType.NVarChar);
		//	comm.Parameters["@botan"].Value = imgPathChange;
		//	comm.ExecuteNonQuery();
		//	conn.Close();


		//}
	}
}
