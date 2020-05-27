namespace Banking.Presentation
{
	partial class LogIn
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
			this.LogInButton = new MetroFramework.Controls.MetroButton();
			this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
			this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
			this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
			this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
			this.metroPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.metroPanel1.Controls.Add(this.LogInButton);
			this.metroPanel1.Controls.Add(this.PasswordTextBox);
			this.metroPanel1.Controls.Add(this.PasswordLabel);
			this.metroPanel1.Controls.Add(this.UsernameTextBox);
			this.metroPanel1.Controls.Add(this.UsernameLabel);
			this.metroPanel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(103, 114);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Padding = new System.Windows.Forms.Padding(20);
			this.metroPanel1.Size = new System.Drawing.Size(594, 263);
			this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.UseCustomBackColor = true;
			this.metroPanel1.UseStyleColors = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// LogInButton
			// 
			this.LogInButton.Enabled = false;
			this.LogInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
			this.LogInButton.Highlight = true;
			this.LogInButton.Location = new System.Drawing.Point(239, 200);
			this.LogInButton.Name = "LogInButton";
			this.LogInButton.Size = new System.Drawing.Size(113, 38);
			this.LogInButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.LogInButton.TabIndex = 6;
			this.LogInButton.Text = "Log In";
			this.LogInButton.UseCustomForeColor = true;
			this.LogInButton.UseSelectable = true;
			this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
			// 
			// PasswordTextBox
			// 
			// 
			// 
			// 
			this.PasswordTextBox.CustomButton.Image = null;
			this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(121, 1);
			this.PasswordTextBox.CustomButton.Name = "";
			this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.PasswordTextBox.CustomButton.TabIndex = 1;
			this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.PasswordTextBox.CustomButton.UseSelectable = true;
			this.PasswordTextBox.CustomButton.Visible = false;
			this.PasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.PasswordTextBox.Lines = new string[0];
			this.PasswordTextBox.Location = new System.Drawing.Point(295, 123);
			this.PasswordTextBox.MaxLength = 32767;
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '\0';
			this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.PasswordTextBox.SelectedText = "";
			this.PasswordTextBox.SelectionLength = 0;
			this.PasswordTextBox.SelectionStart = 0;
			this.PasswordTextBox.ShortcutsEnabled = true;
			this.PasswordTextBox.Size = new System.Drawing.Size(143, 23);
			this.PasswordTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.PasswordTextBox.TabIndex = 5;
			this.PasswordTextBox.UseSelectable = true;
			this.PasswordTextBox.UseStyleColors = true;
			this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.PasswordLabel.Location = new System.Drawing.Point(141, 122);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(82, 25);
			this.PasswordLabel.Style = MetroFramework.MetroColorStyle.Blue;
			this.PasswordLabel.TabIndex = 4;
			this.PasswordLabel.Text = "Password";
			this.PasswordLabel.UseStyleColors = true;
			// 
			// UsernameTextBox
			// 
			// 
			// 
			// 
			this.UsernameTextBox.CustomButton.Image = null;
			this.UsernameTextBox.CustomButton.Location = new System.Drawing.Point(121, 1);
			this.UsernameTextBox.CustomButton.Name = "";
			this.UsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.UsernameTextBox.CustomButton.TabIndex = 1;
			this.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.UsernameTextBox.CustomButton.UseSelectable = true;
			this.UsernameTextBox.CustomButton.Visible = false;
			this.UsernameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.UsernameTextBox.Lines = new string[0];
			this.UsernameTextBox.Location = new System.Drawing.Point(295, 55);
			this.UsernameTextBox.MaxLength = 32767;
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.PasswordChar = '\0';
			this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.UsernameTextBox.SelectedText = "";
			this.UsernameTextBox.SelectionLength = 0;
			this.UsernameTextBox.SelectionStart = 0;
			this.UsernameTextBox.ShortcutsEnabled = true;
			this.UsernameTextBox.Size = new System.Drawing.Size(143, 23);
			this.UsernameTextBox.Style = MetroFramework.MetroColorStyle.Blue;
			this.UsernameTextBox.TabIndex = 3;
			this.UsernameTextBox.UseSelectable = true;
			this.UsernameTextBox.UseStyleColors = true;
			this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.UsernameLabel.Location = new System.Drawing.Point(138, 54);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(89, 25);
			this.UsernameLabel.Style = MetroFramework.MetroColorStyle.Blue;
			this.UsernameLabel.TabIndex = 2;
			this.UsernameLabel.Text = "Username";
			this.UsernameLabel.UseStyleColors = true;
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroPanel1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "LogIn";
			this.Padding = new System.Windows.Forms.Padding(100, 150, 100, 70);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			this.Text = "Log In";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroButton LogInButton;
		private MetroFramework.Controls.MetroTextBox PasswordTextBox;
		private MetroFramework.Controls.MetroLabel PasswordLabel;
		private MetroFramework.Controls.MetroTextBox UsernameTextBox;
		private MetroFramework.Controls.MetroLabel UsernameLabel;
	}
}

