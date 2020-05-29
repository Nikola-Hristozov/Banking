using System;

namespace Banking.Presentation
{
	partial class AddDebtor
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
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.interestTextBox = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.BankersComboBox = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.EndDateTime = new MetroFramework.Controls.MetroDateTime();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.DebtTextBox = new MetroFramework.Controls.MetroTextBox();
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
			this.metroPanel1.Controls.Add(this.metroLabel4);
			this.metroPanel1.Controls.Add(this.interestTextBox);
			this.metroPanel1.Controls.Add(this.metroLabel1);
			this.metroPanel1.Controls.Add(this.metroButton1);
			this.metroPanel1.Controls.Add(this.BankersComboBox);
			this.metroPanel1.Controls.Add(this.metroLabel3);
			this.metroPanel1.Controls.Add(this.EndDateTime);
			this.metroPanel1.Controls.Add(this.metroLabel2);
			this.metroPanel1.Controls.Add(this.DebtTextBox);
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
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.UseCustomBackColor = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
			this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.metroLabel4.Location = new System.Drawing.Point(134, 50);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(143, 15);
			this.metroLabel4.TabIndex = 24;
			this.metroLabel4.Text = "*use 1111-2222-3333 format";
			this.metroLabel4.UseCustomBackColor = true;
			this.metroLabel4.UseCustomForeColor = true;
			// 
			// interestTextBox
			// 
			// 
			// 
			// 
			this.interestTextBox.CustomButton.Image = null;
			this.interestTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
			this.interestTextBox.CustomButton.Name = "";
			this.interestTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.interestTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.interestTextBox.CustomButton.TabIndex = 1;
			this.interestTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.interestTextBox.CustomButton.UseSelectable = true;
			this.interestTextBox.CustomButton.Visible = false;
			this.interestTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.interestTextBox.Lines = new string[0];
			this.interestTextBox.Location = new System.Drawing.Point(524, 175);
			this.interestTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.interestTextBox.MaxLength = 32767;
			this.interestTextBox.Name = "interestTextBox";
			this.interestTextBox.PasswordChar = '\0';
			this.interestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.interestTextBox.SelectedText = "";
			this.interestTextBox.SelectionLength = 0;
			this.interestTextBox.SelectionStart = 0;
			this.interestTextBox.ShortcutsEnabled = true;
			this.interestTextBox.Size = new System.Drawing.Size(187, 29);
			this.interestTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.interestTextBox.TabIndex = 6;
			this.interestTextBox.UseSelectable = true;
			this.interestTextBox.UseStyleColors = true;
			this.interestTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.interestTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.interestTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestTextBox_KeyPress);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(404, 177);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(67, 25);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel1.TabIndex = 19;
			this.metroLabel1.Text = "Interest";
			this.metroLabel1.UseCustomBackColor = true;
			this.metroLabel1.UseStyleColors = true;
			// 
			// metroButton1
			// 
			this.metroButton1.BackColor = System.Drawing.Color.White;
			this.metroButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
			this.metroButton1.Highlight = true;
			this.metroButton1.Location = new System.Drawing.Point(524, 268);
			this.metroButton1.Margin = new System.Windows.Forms.Padding(30);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(187, 52);
			this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton1.TabIndex = 7;
			this.metroButton1.Text = "Add new debtor";
			this.metroButton1.UseCustomBackColor = true;
			this.metroButton1.UseCustomForeColor = true;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.UseStyleColors = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// BankersComboBox
			// 
			this.BankersComboBox.FormattingEnabled = true;
			this.BankersComboBox.ItemHeight = 23;
			this.BankersComboBox.Location = new System.Drawing.Point(524, 95);
			this.BankersComboBox.Name = "BankersComboBox";
			this.BankersComboBox.Size = new System.Drawing.Size(187, 29);
			this.BankersComboBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.BankersComboBox.TabIndex = 5;
			this.BankersComboBox.UseSelectable = true;
			this.BankersComboBox.UseStyleColors = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.Location = new System.Drawing.Point(404, 97);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(64, 25);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel3.TabIndex = 16;
			this.metroLabel3.Text = "Banker";
			this.metroLabel3.UseCustomBackColor = true;
			this.metroLabel3.UseStyleColors = true;
			// 
			// EndDateTime
			// 
			this.EndDateTime.Location = new System.Drawing.Point(524, 19);
			this.EndDateTime.MinDate = new System.DateTime(2020, 5, 29, 0, 0, 0, 0);
			this.EndDateTime.MinimumSize = new System.Drawing.Size(0, 29);
			this.EndDateTime.Name = "EndDateTime";
			this.EndDateTime.Size = new System.Drawing.Size(187, 29);
			this.EndDateTime.Style = MetroFramework.MetroColorStyle.Blue;
			this.EndDateTime.TabIndex = 4;
			this.EndDateTime.UseStyleColors = true;
			this.EndDateTime.Value = this.EndDateTime.MinDate;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.Location = new System.Drawing.Point(416, 21);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(41, 25);
			this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel2.TabIndex = 14;
			this.metroLabel2.Text = "End";
			this.metroLabel2.UseCustomBackColor = true;
			this.metroLabel2.UseStyleColors = true;
			// 
			// DebtTextBox
			// 
			// 
			// 
			// 
			this.DebtTextBox.CustomButton.Image = null;
			this.DebtTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
			this.DebtTextBox.CustomButton.Name = "";
			this.DebtTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.DebtTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.DebtTextBox.CustomButton.TabIndex = 1;
			this.DebtTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.DebtTextBox.CustomButton.UseSelectable = true;
			this.DebtTextBox.CustomButton.Visible = false;
			this.DebtTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.DebtTextBox.Lines = new string[0];
			this.DebtTextBox.Location = new System.Drawing.Point(162, 175);
			this.DebtTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.DebtTextBox.MaxLength = 32767;
			this.DebtTextBox.Name = "DebtTextBox";
			this.DebtTextBox.PasswordChar = '\0';
			this.DebtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.DebtTextBox.SelectedText = "";
			this.DebtTextBox.SelectionLength = 0;
			this.DebtTextBox.SelectionStart = 0;
			this.DebtTextBox.ShortcutsEnabled = true;
			this.DebtTextBox.Size = new System.Drawing.Size(187, 29);
			this.DebtTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.DebtTextBox.TabIndex = 3;
			this.DebtTextBox.UseSelectable = true;
			this.DebtTextBox.UseStyleColors = true;
			this.DebtTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.DebtTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.DebtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DebtTextBox_KeyPress);
			// 
			// debt
			// 
			this.debt.AutoSize = true;
			this.debt.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.debt.Location = new System.Drawing.Point(46, 177);
			this.debt.Name = "debt";
			this.debt.Size = new System.Drawing.Size(48, 25);
			this.debt.Style = MetroFramework.MetroColorStyle.Blue;
			this.debt.TabIndex = 10;
			this.debt.Text = "Debt";
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
			// AddDebtor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroPanel1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
			this.Name = "AddDebtor";
			this.Text = "Add Debtor";
			this.Load += new System.EventHandler(this.AddDebtor_Load);
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroTextBox DebtTextBox;
		private MetroFramework.Controls.MetroLabel debt;
		private MetroFramework.Controls.MetroTextBox NameTextBox;
		private MetroFramework.Controls.MetroLabel NameLabel;
		private MetroFramework.Controls.MetroTextBox IBANTextBox;
		private MetroFramework.Controls.MetroLabel IBAM;
		private MetroFramework.Controls.MetroComboBox BankersComboBox;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroDateTime EndDateTime;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroTextBox interestTextBox;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel4;
	}
}