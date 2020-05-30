using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using Banking.Logic;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Banking.Data
{
	public class Access
	{
		//Checks if the username and password of the user escist in the database
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
		//Returns a dictionary with the name and id of the current banker user
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
		//Creates new object from class Debtor and adding it to the database
		public static bool CreateDebtor(string IBAN, string name, double debt, DateTime end, double interest, int banker_id)
		{
			
			using (bankEntities a = new bankEntities())
			{
				var all = from debtor in a.Debtors
							where (debtor.IBAN == IBAN)
							select new
							{
								debtor.Id
							};
				if (all.Count() == 0)
				{
					a.Debtors.Add(new Debtors(IBAN, name, debt, end, interest, banker_id));
					a.SaveChanges();
					return true;
				}
				else
				{
					return false;
				}
			}
			
		}
		
		//Returns list of the Dabtors of the current banker user
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
		//Changes the data of specified Debtor
		public static void Update(Debtors debtor)
		{
			using(var context=new bankEntities())
			{
				var result=context.Debtors.Where(x=>x.IBAN==debtor.IBAN && x.name==debtor.name).First();
				result.debt = debtor.debt;
				result.endDate = debtor.endDate;
				result.interest = debtor.interest;
				context.SaveChanges();
			}
		}
		//Deletes specified Debtor
		public static void Delete(Debtors debtor)
		{
			using (var context = new bankEntities())
			{
				var result = context.Debtors.Where(x => x.IBAN == debtor.IBAN && x.name == debtor.name).First();
				context.Debtors.Remove(result);
				context.SaveChanges();
			}
		}
		//Creates new object from class Creditor and adding it to the database
		public static bool CreateCreditor(string IBAN, string name, double lend, DateTime end, double interest, int banker_id)
		{
			using (bankEntities a = new bankEntities())
			{
				var all = from creditor in a.Creditors
						  where (creditor.IBAN == IBAN)
						  select new
						  {
							  creditor.Id
						  };
				if (all.Count() == 0)
				{
					a.Creditors.Add(new Creditors(IBAN, name, lend, end, interest, banker_id));
					a.SaveChanges();
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		//Returns list of the Creditors of the current banker user
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
		//Changes the data of specified Creditor
		public static void Update(Creditors creditor)
		{
			using (var context = new bankEntities())
			{
				var result = context.Creditors.Where(x => x.IBAN == creditor.IBAN && x.name == creditor.name).First();
				result.lend = creditor.lend;
				result.endDate = creditor.endDate;
				result.interest = creditor.interest;
				context.SaveChanges();
			}
		}
		//Deletes specified Creditor
		public static void Delete(Creditors creditor)
		{
			using (var context = new bankEntities())
			{
				var result = context.Creditors.Where(x => x.IBAN == creditor.IBAN && x.name == creditor.name).First();
				context.Creditors.Remove(result);
				context.SaveChanges();
			}
		}
	}
}
