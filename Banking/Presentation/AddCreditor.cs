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
	public partial class AddCreditor : MetroFramework.Forms.MetroForm
	{
		public AddCreditor()
		{
			InitializeComponent();
		}
		Dictionary<string, int> bankers = new Dictionary<string, int>();

		private void metroButton1_Click(object sender, EventArgs e)
		{
			
			Access.CreateCreditor(IBANTextBox.Text, NameTextBox.Text, double.Parse(DebtTextBox.Text), EndDateTime.Value, double.Parse(InterestTextBox.Text), bankers[BankersComboBox.Text]);
			MetroMessageBox.Show(this, "oke");
		}

		private void AddCreditor_Load(object sender, EventArgs e)
		{
			bankers = Access.GetBankers();
			BankersComboBox.DataSource = bankers.Keys.ToList();
			
		}
	}
}
