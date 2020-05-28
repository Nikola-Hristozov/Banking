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
		public static bool CheckAccount(string username,string password,ref string name,ref int id)
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
						var named = from user in context.bankers
									where (user.username == username)
									select new
									{
										user.name,
 										user.id
									};
						foreach (var a in named)
						{
							id = a.id;
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

		public static List<Debtors> GetDebtors(int id)
		{
			using (var context = new bankEntities())
			{
				var a = from debtor in context.Debtors
						where (debtor.banker_id == id)
						select new
						{
							debtor.IBAN,
							debtor.name,
							debtor.debt,
							debtor.endDate,
							debtor.interest,
							debtor.installment,
							debtor.banker_id
						};
				List<Debtors> debtors = new List<Debtors>();
				foreach (var debtor in a)
				{
					debtors.Add(new Debtors(debtor.IBAN, debtor.name, debtor.debt, debtor.endDate, debtor.interest, debtor.banker_id));
				}
				return debtors;
			}
		}
		public static List<Creditors> GetCreditors(int id)
		{
			using (var context = new bankEntities())
			{
				var a = from creditor in context.Creditors
						where (creditor.banker_id == id)
						select new
						{
							creditor.IBAN,
							creditor.name,
							creditor.lend,
							creditor.endDate,
							creditor.interest,
							creditor.guarantee,
							creditor.banker_id
						};
				List<Creditors> creditors = new List<Creditors>();
				foreach (var creditor in a)
				{
					creditors.Add(new Creditors(creditor.IBAN, creditor.name, creditor.lend, creditor.endDate, creditor.interest, creditor.banker_id));
				}
				return creditors;
			}
		}
	}
}
