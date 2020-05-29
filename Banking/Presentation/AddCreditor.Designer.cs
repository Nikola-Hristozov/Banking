using Banking.Properties;

namespace Banking.Presentation
{
	partial class AddCreditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Icon = Banking.Properties.Resources.icon;
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.InterestTextBox = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.BankersComboBox = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.LendTextBox = new MetroFramework.Controls.MetroTextBox();
			this.debt = new MetroFramework.Controls.MetroLabel();
			this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
			this.NameLabel = new MetroFramework.Controls.MetroLabel();
			this.IBANTextBox = new MetroFramework.Controls.MetroTextBox();
			this.IBAM = new MetroFramework.Controls.MetroLabel();
			this.metroPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.metroPanel1.Controls.Add(this.metroLabel2);
			this.metroPanel1.Controls.Add(this.InterestTextBox);
			this.metroPanel1.Controls.Add(this.metroLabel1);
			this.metroPanel1.Controls.Add(this.metroButton1);
			this.metroPanel1.Controls.Add(this.BankersComboBox);
			this.metroPanel1.Controls.Add(this.metroLabel3);
			this.metroPanel1.Controls.Add(this.LendTextBox);
			this.metroPanel1.Controls.Add(this.debt);
			this.metroPanel1.Controls.Add(this.NameTextBox);
			this.metroPanel1.Controls.Add(this.NameLabel);
			this.metroPanel1.Controls.Add(this.IBANTextBox);
			this.metroPanel1.Controls.Add(this.IBAM);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(23, 63);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(754, 364);
			this.metroPanel1.TabIndex = 1;
			this.metroPanel1.UseCustomBackColor = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.metroLabel2.Location = new System.Drawing.Point(134, 51);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(143, 15);
			this.metroLabel2.TabIndex = 23;
			this.metroLabel2.Text = "*use 1111-2222-3333 format";
			this.metroLabel2.UseCustomBackColor = true;
			this.metroLabel2.UseCustomForeColor = true;
			// 
			// InterestTextBox
			// 
			// 
			// 
			// 
			this.InterestTextBox.CustomButton.Image = null;
			this.InterestTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
			this.InterestTextBox.CustomButton.Name = "";
			this.InterestTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.InterestTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.InterestTextBox.CustomButton.TabIndex = 1;
			this.InterestTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.InterestTextBox.CustomButton.UseSelectable = true;
			this.InterestTextBox.CustomButton.Visible = false;
			this.InterestTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.InterestTextBox.Lines = new string[0];
			this.InterestTextBox.Location = new System.Drawing.Point(510, 95);
			this.InterestTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.InterestTextBox.MaxLength = 32767;
			this.InterestTextBox.Name = "InterestTextBox";
			this.InterestTextBox.PasswordChar = '\0';
			this.InterestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.InterestTextBox.SelectedText = "";
			this.InterestTextBox.SelectionLength = 0;
			this.InterestTextBox.SelectionStart = 0;
			this.InterestTextBox.ShortcutsEnabled = true;
			this.InterestTextBox.Size = new System.Drawing.Size(187, 29);
			this.InterestTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.InterestTextBox.TabIndex = 5;
			this.InterestTextBox.UseSelectable = true;
			this.InterestTextBox.UseStyleColors = true;
			this.InterestTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.InterestTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.InterestTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestTextBox_KeyPress);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(390, 97);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(67, 25);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel1.TabIndex = 21;
			this.metroLabel1.Text = "Interest";
			this.metroLabel1.UseCustomBackColor = true;
			this.metroLabel1.UseStyleColors = true;
			// 
			// metroButton1
			// 
			this.metroButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
			this.metroButton1.Highlight = true;
			this.metroButton1.Location = new System.Drawing.Point(524, 268);
			this.metroButton1.Margin = new System.Windows.Forms.Padding(30);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(187, 52);
			this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton1.TabIndex = 6;
			this.metroButton1.Text = "Add new creditor";
			this.metroButton1.UseCustomForeColor = true;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.UseStyleColors = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// BankersComboBox
			// 
			this.BankersComboBox.FormattingEnabled = true;
			this.BankersComboBox.ItemHeight = 23;
			this.BankersComboBox.Location = new System.Drawing.Point(510, 19);
			this.BankersComboBox.Name = "BankersComboBox";
			this.BankersComboBox.Size = new System.Drawing.Size(187, 29);
			this.BankersComboBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.BankersComboBox.TabIndex = 4;
			this.BankersComboBox.UseSelectable = true;
			this.BankersComboBox.UseStyleColors = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.Location = new System.Drawing.Point(390, 21);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(64, 25);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel3.TabIndex = 16;
			this.metroLabel3.Text = "Banker";
			this.metroLabel3.UseCustomBackColor = true;
			this.metroLabel3.UseStyleColors = true;
			// 
			// LendTextBox
			// 
			// 
			// 
			// 
			this.LendTextBox.CustomButton.Image = null;
			this.LendTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
			this.LendTextBox.CustomButton.Name = "";
			this.LendTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.LendTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.LendTextBox.CustomButton.TabIndex = 1;
			this.LendTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.LendTextBox.CustomButton.UseSelectable = true;
			this.LendTextBox.CustomButton.Visible = false;
			this.LendTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.LendTextBox.Lines = new string[0];
			this.LendTextBox.Location = new System.Drawing.Point(162, 175);
			this.LendTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.LendTextBox.MaxLength = 32767;
			this.LendTextBox.Name = "LendTextBox";
			this.LendTextBox.PasswordChar = '\0';
			this.LendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.LendTextBox.SelectedText = "";
			this.LendTextBox.SelectionLength = 0;
			this.LendTextBox.SelectionStart = 0;
			this.LendTextBox.ShortcutsEnabled = true;
			this.LendTextBox.Size = new System.Drawing.Size(187, 29);
			this.LendTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.LendTextBox.TabIndex = 3;
			this.LendTextBox.UseSelectable = true;
			this.LendTextBox.UseStyleColors = true;
			this.LendTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.LendTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.LendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LendTextBox_KeyPress);
			// 
			// debt
			// 
			this.debt.AutoSize = true;
			this.debt.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.debt.Location = new System.Drawing.Point(46, 177);
			this.debt.Name = "debt";
			this.debt.Size = new System.Drawing.Size(49, 25);
			this.debt.Style = MetroFramework.MetroColorStyle.Blue;
			this.debt.TabIndex = 10;
			this.debt.Text = "Lend";
			this.debt.UseCustomBackColor = true;
			this.debt.UseStyleColors = true;
			// 
			// NameTextBox
			// 
			// 
			// 
			// 
			this.NameTextBox.CustomButton.Image = null;
			this.NameTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
			this.NameTextBox.CustomButton.Name = "";
			this.NameTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.NameTextBox.CustomButton.TabIndex = 1;
			this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.NameTextBox.CustomButton.UseSelectable = true;
			this.NameTextBox.CustomButton.Visible = false;
			this.NameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.NameTextBox.Lines = new string[0];
			this.NameTextBox.Location = new System.Drawing.Point(162, 95);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.NameTextBox.MaxLength = 32767;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.PasswordChar = '\0';
			this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.NameTextBox.SelectedText = "";
			this.NameTextBox.SelectionLength = 0;
			this.NameTextBox.SelectionStart = 0;
			this.NameTextBox.ShortcutsEnabled = true;
			this.NameTextBox.Size = new System.Drawing.Size(187, 29);
			this.NameTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.NameTextBox.TabIndex = 2;
			this.NameTextBox.UseSelectable = true;
			this.NameTextBox.UseStyleColors = true;
			this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.NameLabel.Location = new System.Drawing.Point(41, 97);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(58, 25);
			this.NameLabel.Style = MetroFramework.MetroColorStyle.Blue;
			this.NameLabel.TabIndex = 8;
			this.NameLabel.Text = "Name";
			this.NameLabel.UseCustomBackColor = true;
			this.NameLabel.UseStyleColors = true;
			// 
			// IBANTextBox
			// 
			// 
			// 
			// 
			this.IBANTextBox.CustomButton.Image = null;
			this.IBANTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
			this.IBANTextBox.CustomButton.Name = "";
			this.IBANTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.IBANTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.IBANTextBox.CustomButton.TabIndex = 1;
			this.IBANTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.IBANTextBox.CustomButton.UseSelectable = true;
			this.IBANTextBox.CustomButton.Visible = false;
			this.IBANTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.IBANTextBox.Lines = new string[0];
			this.IBANTextBox.Location = new System.Drawing.Point(162, 19);
			this.IBANTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.IBANTextBox.MaxLength = 32767;
			this.IBANTextBox.Name = "IBANTextBox";
			this.IBANTextBox.PasswordChar = '\0';
			this.IBANTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.IBANTextBox.SelectedText = "";
			this.IBANTextBox.SelectionLength = 0;
			this.IBANTextBox.SelectionStart = 0;
			this.IBANTextBox.ShortcutsEnabled = true;
			this.IBANTextBox.Size = new System.Drawing.Size(187, 29);
			this.IBANTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.IBANTextBox.TabIndex = 1;
			this.IBANTextBox.UseSelectable = true;
			this.IBANTextBox.UseStyleColors = true;
			this.IBANTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.IBANTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.IBANTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IBANTextBox_KeyPress);
			// 
			// IBAM
			// 
			this.IBAM.AutoSize = true;
			this.IBAM.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.IBAM.Location = new System.Drawing.Point(45, 21);
			this.IBAM.Name = "IBAM";
			this.IBAM.Size = new System.Drawing.Size(50, 25);
			this.IBAM.Style = MetroFramework.MetroColorStyle.Blue;
			this.IBAM.TabIndex = 6;
			this.IBAM.Text = "IBAN";
			this.IBAM.UseCustomBackColor = true;
			this.IBAM.UseStyleColors = true;
			// 
			// AddCreditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroPanel1);
			this.Name = "AddCreditor";
			this.Text = "Add Creditor";
			this.Load += new System.EventHandler(this.AddCreditor_Load);
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroComboBox BankersComboBox;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox LendTextBox;
		private MetroFramework.Controls.MetroLabel debt;
		private MetroFramework.Controls.MetroTextBox NameTextBox;
		private MetroFramework.Controls.MetroLabel NameLabel;
		private MetroFramework.Controls.MetroTextBox IBANTextBox;
		private MetroFramework.Controls.MetroLabel IBAM;
		private MetroFramework.Controls.MetroTextBox InterestTextBox;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
	}
}