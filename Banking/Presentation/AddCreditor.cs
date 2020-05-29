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
			Exception WrongIBAN = new Exception("Wrong IBAN format.");
			Exception MissingAnInput = new Exception("You are missing an input.");
			Exception WrongLend = new Exception("Wrong Lend format.");
			Exception AlreadyExcists = new Exception("Creditor with this IBAN already excists.");
			string exceptionText = "";
			try
			{
				if (!String.IsNullOrEmpty(IBANTextBox.Text) && !String.IsNullOrEmpty(NameTextBox.Text) && !String.IsNullOrEmpty(LendTextBox.Text) && !String.IsNullOrEmpty(InterestTextBox.Text))
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
							foreach (var a in LendTextBox.Text)
							{
								if (a == ',')
								{
									chars++;
								}
							}
							if (chars < 1)
							{
								DateTime endDate = new DateTime(DateTime.Today.Year + 2, DateTime.Today.Month, DateTime.Today.Day);
								if (Access.CreateCreditor(IBANTextBox.Text, NameTextBox.Text, double.Parse(LendTextBox.Text), endDate, double.Parse(InterestTextBox.Text), bankers[BankersComboBox.Text]))
								{
									MetroMessageBox.Show(this, "Creditor added successfully!", "Information updated", MessageBoxButtons.OK);
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

		private void AddCreditor_Load(object sender, EventArgs e)
		{
			bankers = Access.GetBankers();
			BankersComboBox.DataSource = bankers.Keys.ToList();

			
		}

		private void IBANTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
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

		private void LendTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
