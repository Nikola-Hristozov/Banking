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
	public partial class ChangeDebtor : MetroFramework.Forms.MetroForm
	{
		int id;
		public ChangeDebtor(int id)
		{
			InitializeComponent();
			this.id = id;
		}
		Debtors changed = null;
		//Load a specified Debtor's information
		private void metroButton2_Click(object sender, EventArgs e)
		{
			Exception IBANorNameNotFound = new Exception("The Debtors was not found.\nCheck the IBAN/Name and try again");
			string exceptionText = "";
			try
			{
				if (Access.GetDebtors(id).Where(x => (x.name.Trim() == IBANTextBox.Text || x.IBAN.Trim() == IBANTextBox.Text)).Count() != 0)
				{

					changed = Access.GetDebtors(id).Where(x => (x.name.Trim() == IBANTextBox.Text || x.IBAN.Trim() == IBANTextBox.Text)).First();
					debtTextBox.Text = changed.debt.ToString();
					EndDateTime.Value = changed.endDate;
					interestTextBox.Text = changed.interest.ToString();
					debtTextBox.Enabled = true;
					EndDateTime.Enabled = true;
					interestTextBox.Enabled = true;
					metroButton1.Enabled = true;
					metroButton3.Enabled = true;
				}
				else
				{
					exceptionText = IBANorNameNotFound.Message;
					throw IBANorNameNotFound;
				}
			}
			catch (Exception)
			{
				MetroMessageBox.Show(this, exceptionText, "Error", MessageBoxButtons.OK);
			}
		}
		//Change the database data of the specified Debtor with the new inputed data
		private void metroButton1_Click(object sender, EventArgs e)
		{
			changed.debt = double.Parse(debtTextBox.Text);
			changed.endDate = EndDateTime.Value;
			changed.interest=double.Parse(interestTextBox.Text);
			Access.Update(changed);
			MetroMessageBox.Show(this, "Successfully changed the information.", "Success", MessageBoxButtons.OK);
		}
		//Deleting the specified Debtor
		private void metroButton3_Click(object sender, EventArgs e)
		{
			Access.Delete(changed);
			MetroMessageBox.Show(this, "Successfully deleted.", "Success", MessageBoxButtons.OK);
		}
		//Setting Min and Default Value to the EndDateTime control 
		private void ChangeDebtor_Load(object sender, EventArgs e)
		{
			EndDateTime.MinDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
			EndDateTime.Value = EndDateTime.MinDate;
		}
		/// <summary>
		/// Input restrictions whick prevent unexpected exceptions
		/// </summary>
		private void debtTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
