using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Banking
{
	class Program
	{
		//Calls the AddBanker Method. If the query returns trows exception because the username is already in use the method is calleda again
		static void Main(string[] args)
		{
			bool flag=false;
			do
			{
				try
				{
					AddBanker();
					Console.WriteLine("Succesfully added new banker account");
					flag = false;
				}
				catch (Exception)
				{
					flag = true;
					Console.WriteLine("Username is already in use.");
				}
			}
			while (flag);

		}
		//Adds new banker account to the database
		private static void AddBanker()
		{
			bool flag = false;
			string name;
			do
			{
				Console.Write("Name:");
				name = Console.ReadLine();
				foreach (var a in name)
				{
					if (char.IsDigit(a))
					{
						flag = true;
					}
				}
				if(flag)
				{
					Console.WriteLine("Name cannot contain digits");
				}
			} while (flag);
			Console.Write("Userame:");
			string username = Console.ReadLine();
			Console.Write("Password:");
			string password = Console.ReadLine();
			SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=bank;Integrated Security=True");
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("INSERT INTO bankers (username, password, name) VALUES ('" + username + "', '" + password + "', '" + name + "');", sqlConnection);
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}
	}
}
