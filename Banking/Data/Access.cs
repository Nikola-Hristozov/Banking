using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using Banking.Logic;

namespace Banking.Data
{
	public class Access
	{
		public static bool CheckAccount(string username,string password,ref string name)
		{
			using (var context = new bankEntities())
			{
				var users = from user in context.bankers
							select new
							{
								user.username,
								user.password
							};
				Dictionary<string, string> Users = new Dictionary<string, string>();
				foreach (var user in users)
				{
					Users.Add(user.username, user.password);
				}
				if (Users.ContainsKey(username))
				{
					if (Users[username] == password)
					{
						var named= from user in context.bankers
								   where(user.username==username)
								   select new
								   {
									   user.name
								   };
						foreach (var a in named)
						{
							
							name = a.name;
						}

						return true;
					}
					else
						return false;
				}
				else
					return false;
			}
		}
		public static Dictionary<string, int> GetBankers()
		{
			Dictionary<string, int> bankers = new Dictionary<string, int>();
			using (var context = new bankEntities())
			{
				var users = from user in context.bankers
							select new
							{
								user.name,
								user.id
							};
				foreach(var banker in users)
				{
					bankers.Add(banker.name,banker.id);
				}
				return bankers;
			}
		}
		public static void CreateDebtor(string IBAN, string name, double debt, DateTime end, double interest, int banker_id)
		{
			bankEntities a = new bankEntities();
			a.Debtors.Add(new Debtors(IBAN, name, debt, end, interest, banker_id));
			a.SaveChanges();
		}
		public static void CreateCreditor(string IBAN, string name, double lend, DateTime end, double interest, int banker_id)
		{
			bankEntities a = new bankEntities();
			a.Creditors.Add(new Creditors(IBAN, name, lend, end, interest, banker_id));
			a.SaveChanges();
		}
	}
}
