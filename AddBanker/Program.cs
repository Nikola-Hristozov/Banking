using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Banking
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Name:");
			string name=Console.ReadLine();
			Console.Write("Userame:");
			string username = Console.ReadLine();
			Console.Write("Password:");
			string password = Console.ReadLine();
			SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=bank;Integrated Security=True");
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("INSERT INTO bankers (username, password, name) VALUES ('"+username+ "', '" + password + "', '" + name + "');", sqlConnection);
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();



		}
	}
}
