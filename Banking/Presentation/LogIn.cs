﻿using System;
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
	public partial class LogIn : MetroFramework.Forms.MetroForm
	{
		public LogIn()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void LogInButton_Click(object sender, EventArgs e)
		{
			string name="";
			if (Data.Access.CheckAccount(UsernameTextBox.Text, PasswordTextBox.Text,ref name))
			{
				Client client = new Client(name);
				client.Show();
				this.Hide();
			}
			else
				MetroMessageBox.Show(this, "Wrong Username or Password.\nTry again.", "Error");
		}

		private void UsernameTextBox_TextChanged(object sender, EventArgs e)
		{
			if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
				LogInButton.Enabled = true;
			else
				LogInButton.Enabled = false;
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
				LogInButton.Enabled = true;
			else
				LogInButton.Enabled = false;
		}

	}
}
