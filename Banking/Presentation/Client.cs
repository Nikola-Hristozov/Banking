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
	/// <summary>
	/// All buttons define new forms corespounding to the button's text
	/// </summary>
	public partial class Client : MetroFramework.Forms.MetroForm
	{
		string name;
		int id;
		public Client(bankers banker)
		{
			InitializeComponent();
			name = banker.name;
			id = banker.id;
		}
		//Add the name of the banker who uses the application
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

		private void AddCreditor_Click(object sender, EventArgs e)
		{
			AddCreditor NewCreditor = new AddCreditor();
			NewCreditor.Show();
		}

		private void InfoDebtor_Click(object sender, EventArgs e)
		{
			ViewDebtors viewDebtors = new ViewDebtors(id);
			viewDebtors.Show();
		}

		private void InfoCreditor_Click(object sender, EventArgs e)
		{
			ViewCreditors viewCreditors = new ViewCreditors(id);
			viewCreditors.Show();
		}

		private void ChangeDebtorInfo_Click(object sender, EventArgs e)
		{
			ChangeDebtor changeDebtor = new ChangeDebtor(id);
			changeDebtor.Show();
		}

		private void ChangeCreditorInfo_Click(object sender, EventArgs e)
		{
			ChangeCreditor changeCreditor = new ChangeCreditor(id);
			changeCreditor.Show();
		}
	}
}
