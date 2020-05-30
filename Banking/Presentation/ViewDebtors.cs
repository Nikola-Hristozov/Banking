using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking.Data;
using MetroFramework;

namespace Banking.Presentation
{
	public partial class ViewDebtors : MetroFramework.Forms.MetroForm
	{
		int id;
		public ViewDebtors(int id)
		{
			InitializeComponent();
			this.id = id;
		}
		//Loads all Debtors for which the banker using the application is responsible for
		private void ViewDebtors_Load(object sender, EventArgs e)
		{
			List<Debtors> debtors = Access.GetDebtors(id);
			int i = 0;
			foreach(var debtor in debtors)
			{ 
				metroGrid1.Rows.Add();
				metroGrid1.Rows[i].Cells[0].Value = debtor.IBAN;
				metroGrid1.Rows[i].Cells[1].Value = debtor.name;
				metroGrid1.Rows[i].Cells[2].Value = debtor.debt;
				metroGrid1.Rows[i].Cells[3].Value = debtor.endDate.ToString();
				metroGrid1.Rows[i].Cells[4].Value = debtor.interest;
				metroGrid1.Rows[i].Cells[5].Value = debtor.installment;
				i++;
			}

		}
	}
}
