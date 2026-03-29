namespace Hotel
{
	partial class FoodMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			foodPanel = new Panel();
			foodTitleLabel = new Label();
			breakfastCheckBox = new CheckBox();
			breakfastPicture = new PictureBox();
			breakfastQTY = new TextBox();
			lunchCheckBox = new CheckBox();
			lunchPicture = new PictureBox();
			lunchQTY = new TextBox();
			dinnerCheckBox = new CheckBox();
			dinnerPicture = new PictureBox();
			dinnerQTY = new TextBox();
			needPanel = new Panel();
			needTitleLabel = new Label();
			cleaningCheckBox = new CheckBox();
			towelsCheckBox = new CheckBox();
			surpriseCheckBox = new CheckBox();
			nextButton = new Button();
			foodPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)lunchPicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)dinnerPicture).BeginInit();
			needPanel.SuspendLayout();
			SuspendLayout();
			// 
			// foodPanel
			// 
			foodPanel.BackColor = Color.White;
			foodPanel.BorderStyle = BorderStyle.FixedSingle;
			foodPanel.Controls.Add(foodTitleLabel);
			foodPanel.Controls.Add(breakfastCheckBox);
			foodPanel.Controls.Add(breakfastPicture);
			foodPanel.Controls.Add(breakfastQTY);
			foodPanel.Controls.Add(lunchCheckBox);
			foodPanel.Controls.Add(lunchPicture);
			foodPanel.Controls.Add(lunchQTY);
			foodPanel.Controls.Add(dinnerCheckBox);
			foodPanel.Controls.Add(dinnerPicture);
			foodPanel.Controls.Add(dinnerQTY);
			foodPanel.Location = new Point(14, 14);
			foodPanel.Name = "foodPanel";
			foodPanel.Size = new Size(336, 390);
			foodPanel.TabIndex = 0;
			// 
			// foodTitleLabel
			// 
			foodTitleLabel.AutoSize = true;
			foodTitleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			foodTitleLabel.ForeColor = Color.FromArgb(60, 60, 60);
			foodTitleLabel.Location = new Point(10, 10);
			foodTitleLabel.Name = "foodTitleLabel";
			foodTitleLabel.Size = new Size(144, 25);
			foodTitleLabel.TabIndex = 0;
			foodTitleLabel.Text = "Food Selection";
			// 
			// breakfastCheckBox
			// 
			breakfastCheckBox.AutoSize = true;
			breakfastCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			breakfastCheckBox.Location = new Point(10, 42);
			breakfastCheckBox.Name = "breakfastCheckBox";
			breakfastCheckBox.Size = new Size(131, 24);
			breakfastCheckBox.TabIndex = 1;
			breakfastCheckBox.Text = "Break Fast  ($7)";
			// 
			// breakfastPicture
			// 
			breakfastPicture.BackColor = Color.FromArgb(192, 255, 192);
			breakfastPicture.ErrorImage = null;
			breakfastPicture.Location = new Point(10, 68);
			breakfastPicture.Name = "breakfastPicture";
			breakfastPicture.Size = new Size(140, 80);
			breakfastPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			breakfastPicture.TabIndex = 2;
			breakfastPicture.TabStop = false;
			// 
			// breakfastQTY
			// 
			breakfastQTY.BorderStyle = BorderStyle.FixedSingle;
			breakfastQTY.Enabled = false;
			breakfastQTY.Location = new Point(10, 155);
			breakfastQTY.Name = "breakfastQTY";
			breakfastQTY.PlaceholderText = "Quantity ?";
			breakfastQTY.Size = new Size(140, 27);
			breakfastQTY.TabIndex = 3;
			// 
			// lunchCheckBox
			// 
			lunchCheckBox.AutoSize = true;
			lunchCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			lunchCheckBox.Location = new Point(170, 43);
			lunchCheckBox.Name = "lunchCheckBox";
			lunchCheckBox.Size = new Size(111, 24);
			lunchCheckBox.TabIndex = 4;
			lunchCheckBox.Text = "Lunch  ($12)";
			// 
			// lunchPicture
			// 
			lunchPicture.BackColor = Color.FromArgb(192, 255, 192);
			lunchPicture.ErrorImage = null;
			lunchPicture.Location = new Point(170, 68);
			lunchPicture.Name = "lunchPicture";
			lunchPicture.Size = new Size(140, 80);
			lunchPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			lunchPicture.TabIndex = 5;
			lunchPicture.TabStop = false;
			// 
			// lunchQTY
			// 
			lunchQTY.BorderStyle = BorderStyle.FixedSingle;
			lunchQTY.Enabled = false;
			lunchQTY.Location = new Point(170, 155);
			lunchQTY.Name = "lunchQTY";
			lunchQTY.PlaceholderText = "Quantity ?";
			lunchQTY.Size = new Size(140, 27);
			lunchQTY.TabIndex = 6;
			// 
			// dinnerCheckBox
			// 
			dinnerCheckBox.AutoSize = true;
			dinnerCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			dinnerCheckBox.Location = new Point(10, 197);
			dinnerCheckBox.Name = "dinnerCheckBox";
			dinnerCheckBox.Size = new Size(117, 24);
			dinnerCheckBox.TabIndex = 7;
			dinnerCheckBox.Text = "Dinner  ($18)";
			// 
			// dinnerPicture
			// 
			dinnerPicture.BackColor = Color.FromArgb(192, 255, 192);
			dinnerPicture.ErrorImage = null;
			dinnerPicture.Location = new Point(10, 223);
			dinnerPicture.Name = "dinnerPicture";
			dinnerPicture.Size = new Size(140, 80);
			dinnerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			dinnerPicture.TabIndex = 8;
			dinnerPicture.TabStop = false;
			// 
			// dinnerQTY
			// 
			dinnerQTY.BorderStyle = BorderStyle.FixedSingle;
			dinnerQTY.Enabled = false;
			dinnerQTY.Location = new Point(10, 310);
			dinnerQTY.Name = "dinnerQTY";
			dinnerQTY.PlaceholderText = "Quantity ?";
			dinnerQTY.Size = new Size(140, 27);
			dinnerQTY.TabIndex = 9;
			// 
			// needPanel
			// 
			needPanel.BackColor = Color.White;
			needPanel.BorderStyle = BorderStyle.FixedSingle;
			needPanel.Controls.Add(needTitleLabel);
			needPanel.Controls.Add(cleaningCheckBox);
			needPanel.Controls.Add(towelsCheckBox);
			needPanel.Controls.Add(surpriseCheckBox);
			needPanel.Location = new Point(362, 14);
			needPanel.Name = "needPanel";
			needPanel.Size = new Size(164, 340);
			needPanel.TabIndex = 1;
			// 
			// needTitleLabel
			// 
			needTitleLabel.AutoSize = true;
			needTitleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			needTitleLabel.ForeColor = Color.FromArgb(60, 60, 60);
			needTitleLabel.Location = new Point(10, 10);
			needTitleLabel.Name = "needTitleLabel";
			needTitleLabel.Size = new Size(131, 25);
			needTitleLabel.TabIndex = 0;
			needTitleLabel.Text = "Special needs";
			// 
			// cleaningCheckBox
			// 
			cleaningCheckBox.AutoSize = true;
			cleaningCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			cleaningCheckBox.Location = new Point(18, 55);
			cleaningCheckBox.Name = "cleaningCheckBox";
			cleaningCheckBox.Size = new Size(89, 24);
			cleaningCheckBox.TabIndex = 1;
			cleaningCheckBox.Text = "Cleaning";
			// 
			// towelsCheckBox
			// 
			towelsCheckBox.AutoSize = true;
			towelsCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			towelsCheckBox.Location = new Point(18, 90);
			towelsCheckBox.Name = "towelsCheckBox";
			towelsCheckBox.Size = new Size(76, 24);
			towelsCheckBox.TabIndex = 2;
			towelsCheckBox.Text = "Towels";
			// 
			// surpriseCheckBox
			// 
			surpriseCheckBox.AutoSize = true;
			surpriseCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			surpriseCheckBox.Location = new Point(18, 125);
			surpriseCheckBox.Name = "surpriseCheckBox";
			surpriseCheckBox.Size = new Size(145, 24);
			surpriseCheckBox.TabIndex = 3;
			surpriseCheckBox.Text = "Sweetest surprise";
			// 
			// nextButton
			// 
			nextButton.BackColor = Color.FromArgb(0, 192, 0);
			nextButton.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
			nextButton.FlatStyle = FlatStyle.Flat;
			nextButton.Font = new Font("Segoe UI", 9.5F);
			nextButton.ForeColor = Color.White;
			nextButton.Location = new Point(362, 366);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(164, 38);
			nextButton.TabIndex = 2;
			nextButton.Text = "Next";
			nextButton.UseVisualStyleBackColor = false;
			// 
			// FoodMenu
			// 
			BackColor = Color.FromArgb(245, 247, 245);
			ClientSize = new Size(540, 460);
			Controls.Add(foodPanel);
			Controls.Add(needPanel);
			Controls.Add(nextButton);
			Font = new Font("Segoe UI", 9F);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "FoodMenu";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Food and Menu";
			foodPanel.ResumeLayout(false);
			foodPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
			((System.ComponentModel.ISupportInitialize)lunchPicture).EndInit();
			((System.ComponentModel.ISupportInitialize)dinnerPicture).EndInit();
			needPanel.ResumeLayout(false);
			needPanel.PerformLayout();
			ResumeLayout(false);
		}

		#region Fields
		private System.Windows.Forms.Panel foodPanel;
		private System.Windows.Forms.Label foodTitleLabel;
		public System.Windows.Forms.CheckBox breakfastCheckBox;
		private System.Windows.Forms.PictureBox breakfastPicture;
		public System.Windows.Forms.TextBox breakfastQTY;
		public System.Windows.Forms.CheckBox lunchCheckBox;
		private System.Windows.Forms.PictureBox lunchPicture;
		public System.Windows.Forms.TextBox lunchQTY;
		public System.Windows.Forms.CheckBox dinnerCheckBox;
		private System.Windows.Forms.PictureBox dinnerPicture;
		public System.Windows.Forms.TextBox dinnerQTY;
		public System.Windows.Forms.Panel needPanel;
		private System.Windows.Forms.Label needTitleLabel;
		public System.Windows.Forms.CheckBox cleaningCheckBox;
		public System.Windows.Forms.CheckBox towelsCheckBox;
		public System.Windows.Forms.CheckBox surpriseCheckBox;
		public System.Windows.Forms.Button nextButton;
		#endregion
	}
}
