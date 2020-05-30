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
		Dictionary<string, int> bankers = new Dictionary<string, int>();
		//Setting Min and Default Value to the EndDateTime control defining BankersComboBox.DataSource by using the Data.Access.GetBankers Method
		private void AddDebtor_Load(object sender, EventArgs e)
		{
			EndDateTime.MinDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
			EndDateTime.Value = EndDateTime.MinDate;
			bankers = Access.GetBankers();
			BankersComboBox.DataSource = bankers.Keys.ToList();
		}
		//Validating the input of AddDebtor Form and using Data.Access.CreateDebtor to add new debtor in the database
		private void metroButton1_Click(object sender, EventArgs e)
		{
			Exception WrongIBAN = new Exception("Wrong IBAN format.");
			Exception MissingAnInput = new Exception("You are missing an input.");
			Exception WrongLend = new Exception("Wrong Lend format.");
			Exception AlreadyExcists = new Exception("Debtor with this IBAN already excists.");
			string exceptionText = "";
			try
			{
				if (!String.IsNullOrEmpty(IBANTextBox.Text) && !String.IsNullOrEmpty(NameTextBox.Text) && !String.IsNullOrEmpty(DebtTextBox.Text) && !String.IsNullOrEmpty(interestTextBox.Text))
				{
					if (IBANTextBox.Text[4] == '-' && IBANTextBox.Text[9] == '-')
					{
						int chars = 0;
						foreach (var a in IBANTextBox.Text)
						{
							if (a == '-')
							{
								chars++;
							}
						}
						if (chars == 2)
						{
							chars = 0;
							foreach (var a in DebtTextBox.Text)
							{
								if (a == ',')
								{
									chars++;
								}
							}
							if (chars <= 1)
							{
								if (Access.CreateDebtor(IBANTextBox.Text, NameTextBox.Text, double.Parse(DebtTextBox.Text), EndDateTime.Value, double.Parse(interestTextBox.Text), bankers[BankersComboBox.Text]))
								{
									MetroMessageBox.Show(this, "Debtor added successfully!", "Information updated", MessageBoxButtons.OK);
								}
								else
								{
									exceptionText = AlreadyExcists.Message;
									throw AlreadyExcists;

								}
							}
							else
							{
								exceptionText = WrongLend.Message;
								throw WrongLend;
							}
						}
						else
						{
							exceptionText = WrongIBAN.Message;
							throw WrongIBAN;
						}
					}
					else
					{
						exceptionText = WrongIBAN.Message;
						throw WrongIBAN;
					}
				}
				else
				{
					exceptionText = MissingAnInput.Message;
					throw MissingAnInput;
				}
			}
			catch (Exception)
			{
				MetroMessageBox.Show(this, exceptionText, "Error", MessageBoxButtons.OK);
			}

		}
		/// <summary>
		/// Input restrictions whick prevent unexpected exceptions
		/// </summary>
		private void IBANTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsDigit(e.KeyChar) && e.KeyChar!='-' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void DebtTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void interestTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
