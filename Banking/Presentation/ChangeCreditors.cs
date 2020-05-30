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
	public partial class ChangeCreditor : MetroFramework.Forms.MetroForm
	{
		int id;
		public ChangeCreditor(int id)
		{
			InitializeComponent();
			this.id = id;
		}
		Creditors changed = null;
		//Load a specified Creditor's information
		private void metroButton2_Click(object sender, EventArgs e)
		{
			Exception IBANorNameNotFound = new Exception("The Creditor was not found.\nCheck the IBAN/Name and try again");
			string exceptionText = "";
			try
			{
				if (Access.GetCreditors(id).Where(x => (x.name.Trim() == IBANTextBox.Text || x.IBAN.Trim() == IBANTextBox.Text)).Count()!=0)
				{
				
					changed = Access.GetCreditors(id).Where(x => (x.name.Trim() == IBANTextBox.Text || x.IBAN.Trim() == IBANTextBox.Text)).First();
					lendTextBox.Text = changed.lend.ToString();
					interestTextBox.Text = changed.interest.ToString();
					lendTextBox.Enabled = true;
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
			catch(Exception)
			{
				MetroMessageBox.Show(this, exceptionText, "Error", MessageBoxButtons.OK);
			}
		}
		//Change the database data of the specified Creditor with the new inputed data
		private void metroButton1_Click(object sender, EventArgs e)
		{
			changed.lend = double.Parse(lendTextBox.Text);
			changed.interest = double.Parse(interestTextBox.Text);
			Access.Update(changed);
			MetroMessageBox.Show(this, "Successfully changed the information.", "Success", MessageBoxButtons.OK);
		}
		//Deleting the specified Creditor
		private void metroButton3_Click(object sender, EventArgs e)
		{
			MetroMessageBox.Show(this, "Successfully deleted.", "Success", MessageBoxButtons.OK);
			Access.Delete(changed);
		}

		/// <summary>
		/// Input restrictions whick prevent unexpected exceptions
		/// </summary>
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
