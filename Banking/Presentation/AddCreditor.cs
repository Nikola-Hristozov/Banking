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

		private void metroButton1_Click(object sender, EventArgs e)
		{
			Access.CreateCreditor(IBANTextBox.Text, NameTextBox.Text, double.Parse(DebtTextBox.Text), EndDateTime.Value, 5, 1);
			MetroMessageBox.Show(this, "oke");
		}
	}
}
