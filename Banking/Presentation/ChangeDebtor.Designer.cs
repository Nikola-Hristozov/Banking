namespace Banking.Presentation
{
	partial class ChangeDebtor
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
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
			this.EndDateTime = new MetroFramework.Controls.MetroDateTime();
			this.interestTextBox = new MetroFramework.Controls.MetroTextBox();
			this.debtTextBox = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.IBANTextBox = new MetroFramework.Controls.MetroTextBox();
			this.Changed = new MetroFramework.Controls.MetroLabel();
			this.metroPanel1.SuspendLayout();
			this.metroPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.metroPanel1.Controls.Add(this.metroButton3);
			this.metroPanel1.Controls.Add(this.metroButton2);
			this.metroPanel1.Controls.Add(this.metroPanel2);
			this.metroPanel1.Controls.Add(this.metroButton1);
			this.metroPanel1.Controls.Add(this.IBANTextBox);
			this.metroPanel1.Controls.Add(this.Changed);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(20, 70);
			this.metroPanel1.Margin = new System.Windows.Forms.Padding(10);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(760, 364);
			this.metroPanel1.TabIndex = 2;
			this.metroPanel1.UseCustomBackColor = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// metroButton3
			// 
			this.metroButton3.Enabled = false;
			this.metroButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
			this.metroButton3.Highlight = true;
			this.metroButton3.Location = new System.Drawing.Point(284, 282);
			this.metroButton3.Margin = new System.Windows.Forms.Padding(30);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(187, 52);
			this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton3.TabIndex = 6;
			this.metroButton3.Text = "Delete";
			this.metroButton3.UseCustomForeColor = true;
			this.metroButton3.UseSelectable = true;
			this.metroButton3.UseStyleColors = true;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
			this.metroButton2.Highlight = true;
			this.metroButton2.Location = new System.Drawing.Point(300, 70);
			this.metroButton2.Margin = new System.Windows.Forms.Padding(30);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(154, 34);
			this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton2.TabIndex = 2;
			this.metroButton2.Text = "Load";
			this.metroButton2.UseCustomForeColor = true;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.UseStyleColors = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroPanel2
			// 
			this.metroPanel2.Controls.Add(this.EndDateTime);
			this.metroPanel2.Controls.Add(this.interestTextBox);
			this.metroPanel2.Controls.Add(this.debtTextBox);
			this.metroPanel2.Controls.Add(this.metroLabel3);
			this.metroPanel2.Controls.Add(this.metroLabel2);
			this.metroPanel2.Controls.Add(this.metroLabel1);
			this.metroPanel2.HorizontalScrollbarBarColor = true;
			this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel2.HorizontalScrollbarSize = 10;
			this.metroPanel2.Location = new System.Drawing.Point(30, 118);
			this.metroPanel2.Margin = new System.Windows.Forms.Padding(30);
			this.metroPanel2.Name = "metroPanel2";
			this.metroPanel2.Size = new System.Drawing.Size(694, 122);
			this.metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroPanel2.TabIndex = 19;
			this.metroPanel2.UseStyleColors = true;
			this.metroPanel2.VerticalScrollbarBarColor = true;
			this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel2.VerticalScrollbarSize = 10;
			// 
			// EndDateTime
			// 
			this.EndDateTime.Enabled = false;
			this.EndDateTime.Location = new System.Drawing.Point(254, 55);
			this.EndDateTime.MinimumSize = new System.Drawing.Size(0, 29);
			this.EndDateTime.Name = "EndDateTime";
			this.EndDateTime.Size = new System.Drawing.Size(200, 29);
			this.EndDateTime.Style = MetroFramework.MetroColorStyle.Blue;
			this.EndDateTime.TabIndex = 4;
			this.EndDateTime.UseStyleColors = true;
			// 
			// interestTextBox
			// 
			// 
			// 
			// 
			this.interestTextBox.CustomButton.Image = null;
			this.interestTextBox.CustomButton.Location = new System.Drawing.Point(82, 1);
			this.interestTextBox.CustomButton.Name = "";
			this.interestTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.interestTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.interestTextBox.CustomButton.TabIndex = 1;
			this.interestTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.interestTextBox.CustomButton.UseSelectable = true;
			this.interestTextBox.CustomButton.Visible = false;
			this.interestTextBox.Enabled = false;
			this.interestTextBox.Lines = new string[0];
			this.interestTextBox.Location = new System.Drawing.Point(564, 55);
			this.interestTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.interestTextBox.MaxLength = 32767;
			this.interestTextBox.Name = "interestTextBox";
			this.interestTextBox.PasswordChar = '\0';
			this.interestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.interestTextBox.SelectedText = "";
			this.interestTextBox.SelectionLength = 0;
			this.interestTextBox.SelectionStart = 0;
			this.interestTextBox.ShortcutsEnabled = true;
			this.interestTextBox.Size = new System.Drawing.Size(110, 29);
			this.interestTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.interestTextBox.TabIndex = 5;
			this.interestTextBox.UseSelectable = true;
			this.interestTextBox.UseStyleColors = true;
			this.interestTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.interestTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.interestTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestTextBox_KeyPress);
			// 
			// debtTextBox
			// 
			// 
			// 
			// 
			this.debtTextBox.CustomButton.Image = null;
			this.debtTextBox.CustomButton.Location = new System.Drawing.Point(82, 1);
			this.debtTextBox.CustomButton.Name = "";
			this.debtTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.debtTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.debtTextBox.CustomButton.TabIndex = 1;
			this.debtTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.debtTextBox.CustomButton.UseSelectable = true;
			this.debtTextBox.CustomButton.Visible = false;
			this.debtTextBox.Enabled = false;
			this.debtTextBox.Lines = new string[0];
			this.debtTextBox.Location = new System.Drawing.Point(20, 55);
			this.debtTextBox.Margin = new System.Windows.Forms.Padding(20);
			this.debtTextBox.MaxLength = 32767;
			this.debtTextBox.Name = "debtTextBox";
			this.debtTextBox.PasswordChar = '\0';
			this.debtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.debtTextBox.SelectedText = "";
			this.debtTextBox.SelectionLength = 0;
			this.debtTextBox.SelectionStart = 0;
			this.debtTextBox.ShortcutsEnabled = true;
			this.debtTextBox.Size = new System.Drawing.Size(110, 29);
			this.debtTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.debtTextBox.TabIndex = 3;
			this.debtTextBox.UseSelectable = true;
			this.debtTextBox.UseStyleColors = true;
			this.debtTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.debtTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.debtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.debtTextBox_KeyPress);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(594, 16);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(51, 19);
			this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel3.TabIndex = 4;
			this.metroLabel3.Text = "Interest";
			this.metroLabel3.UseStyleColors = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(316, 16);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(62, 19);
			this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "End Date";
			this.metroLabel2.UseStyleColors = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(57, 16);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(37, 19);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Debt";
			this.metroLabel1.UseStyleColors = true;
			// 
			// metroButton1
			// 
			this.metroButton1.Enabled = false;
			this.metroButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
			this.metroButton1.Highlight = true;
			this.metroButton1.Location = new System.Drawing.Point(524, 282);
			this.metroButton1.Margin = new System.Windows.Forms.Padding(30);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(187, 52);
			this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroButton1.TabIndex = 7;
			this.metroButton1.Text = "Save Changes";
			this.metroButton1.UseCustomForeColor = true;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.UseStyleColors = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
			this.IBANTextBox.Location = new System.Drawing.Point(370, 20);
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
			// 
			// Changed
			// 
			this.Changed.AutoSize = true;
			this.Changed.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.Changed.Location = new System.Drawing.Point(225, 22);
			this.Changed.Name = "Changed";
			this.Changed.Size = new System.Drawing.Size(122, 25);
			this.Changed.Style = MetroFramework.MetroColorStyle.Blue;
			this.Changed.TabIndex = 6;
			this.Changed.Text = "Name or IBAN";
			this.Changed.UseCustomBackColor = true;
			this.Changed.UseStyleColors = true;
			// 
			// ChangeDebtor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroPanel1);
			this.Name = "ChangeDebtor";
			this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 20);
			this.Text = "ChangeDebtor";
			this.Load += new System.EventHandler(this.ChangeDebtor_Load);
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.metroPanel2.ResumeLayout(false);
			this.metroPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroTextBox IBANTextBox;
		private MetroFramework.Controls.MetroLabel Changed;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroPanel metroPanel2;
		private MetroFramework.Controls.MetroTextBox interestTextBox;
		private MetroFramework.Controls.MetroTextBox debtTextBox;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroDateTime EndDateTime;
	}
}