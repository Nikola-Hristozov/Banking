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
	public partial class AddDebtor : MetroFramework.Forms.MetroForm
	{
		public AddDebtor()
		{
			InitializeComponent();
		}

		private void AddDebtor_Load(object sender, EventArgs e)
		{
			BankersComboBox.DataSource = Access.GetBankers().Keys.ToList();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			Access.CreateDebtor(IBANTextBox.Text, NameTextBox.Text, double.Parse(DebtTextBox.Text), EndDateTime.Value, 5, 1, double.Parse(BalanceTextBox.Text));
			MetroMessageBox.Show(null, "oke");
		}
	}
}
