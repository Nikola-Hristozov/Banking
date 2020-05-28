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
	public partial class ViewCreditors : MetroFramework.Forms.MetroForm
	{
		int id;
		public ViewCreditors(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void ViewCreditors_Load(object sender, EventArgs e)
		{
			List<Creditors> Creditors = Access.GetCreditors(id);
			int i = 0;
			foreach (var creditor in Creditors)
			{
				metroGrid1.Rows.Add();
				metroGrid1.Rows[i].Cells[0].Value = creditor.IBAN;
				metroGrid1.Rows[i].Cells[1].Value = creditor.name;
				metroGrid1.Rows[i].Cells[2].Value = creditor.lend;
				metroGrid1.Rows[i].Cells[3].Value = creditor.endDate.ToString();
				metroGrid1.Rows[i].Cells[4].Value = creditor.interest;
				metroGrid1.Rows[i].Cells[5].Value = creditor.guarantee;
				i++;
			}

		}

	}
}
