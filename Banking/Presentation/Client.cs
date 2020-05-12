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
	public partial class Client : MetroFramework.Forms.MetroForm
	{
		string name;
		public Client(string name)
		{
			InitializeComponent();
			this.name = name;
		}

		private void Client_Load(object sender, EventArgs e)
		{
			Text += " "+name+"!";
		}

		private void Client_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void AddDebtor_Click(object sender, EventArgs e)
		{
			AddDebtor NewDebtor = new AddDebtor();
			NewDebtor.Show();
		}
	}
}
