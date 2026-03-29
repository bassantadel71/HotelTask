namespace Hotel
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtPassword = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btnSignIn = new Button();
			txtUserName = new TextBox();
			btnLicense = new Button();
			SuspendLayout();
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(288, 228);
			txtPassword.Margin = new Padding(4, 5, 4, 5);
			txtPassword.Multiline = true;
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.PlaceholderText = "Password";
			txtPassword.Size = new Size(272, 45);
			txtPassword.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(145, 139);
			label1.Name = "label1";
			label1.Size = new Size(78, 20);
			label1.TabIndex = 2;
			label1.Text = "UserName";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(153, 242);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// btnSignIn
			// 
			btnSignIn.Location = new Point(288, 341);
			btnSignIn.Name = "btnSignIn";
			btnSignIn.Size = new Size(271, 46);
			btnSignIn.TabIndex = 4;
			btnSignIn.Text = "Sign In";
			btnSignIn.UseVisualStyleBackColor = true;
			btnSignIn.Click += btnSignIn_Click;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(287, 123);
			txtUserName.Margin = new Padding(4, 5, 4, 5);
			txtUserName.Multiline = true;
			txtUserName.Name = "txtUserName";
			txtUserName.PlaceholderText = "User Name";
			txtUserName.Size = new Size(272, 45);
			txtUserName.TabIndex = 1;
			// 
			// btnLicense
			// 
			btnLicense.Location = new Point(705, 419);
			btnLicense.Name = "btnLicense";
			btnLicense.Size = new Size(94, 29);
			btnLicense.TabIndex = 5;
			btnLicense.Text = "Licenses";
			btnLicense.UseVisualStyleBackColor = true;
			btnLicense.Click += btnLicense_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnLicense);
			Controls.Add(txtUserName);
			Controls.Add(btnSignIn);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtPassword);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox txtPassword;
		private Label label1;
		private Label label2;
		private Button btnSignIn;
		private TextBox txtUserName;
		private Button btnLicense;
	}
}
