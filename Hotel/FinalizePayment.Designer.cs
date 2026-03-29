namespace Hotel
{
	partial class FinalizePayment
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		//private System.ComponentModel.IContainer components = null;

		
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			reservationLabel = new Label();
			priceLabel = new Label();
			foodBillLabel = new Label();
			foodBillAmount = new Label();
			currentBillLabel = new Label();
			currentBillAmount = new Label();
			taxLabel = new Label();
			taxAmount = new Label();
			totalLabel = new Label();
			totalAmount = new Label();
			divider = new Label();
			paymentLabel = new Label();
			paymentComboBox = new ComboBox();
			cardNumberTextBox = new TextBox();
			expLabel = new Label();
			monthComboBox = new ComboBox();
			slashLabel = new Label();
			yearComboBox = new ComboBox();
			cvcComboBox = new TextBox();
			cardTypeLabel = new Label();
			cardTypeView = new Label();
			nextButton = new Button();
			SuspendLayout();
			// 
			// reservationLabel
			// 
			reservationLabel.AutoSize = true;
			reservationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			reservationLabel.ForeColor = Color.FromArgb(60, 60, 60);
			reservationLabel.Location = new Point(14, 16);
			reservationLabel.Name = "reservationLabel";
			reservationLabel.Size = new Size(93, 20);
			reservationLabel.TabIndex = 0;
			reservationLabel.Text = "Reservation";
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			priceLabel.ForeColor = Color.FromArgb(60, 60, 60);
			priceLabel.Location = new Point(370, 16);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new Size(43, 20);
			priceLabel.TabIndex = 1;
			priceLabel.Text = "Price";
			// 
			// foodBillLabel
			// 
			foodBillLabel.AutoSize = true;
			foodBillLabel.Font = new Font("Segoe UI", 8.5F);
			foodBillLabel.ForeColor = Color.FromArgb(60, 60, 60);
			foodBillLabel.Location = new Point(14, 42);
			foodBillLabel.Name = "foodBillLabel";
			foodBillLabel.Size = new Size(68, 20);
			foodBillLabel.TabIndex = 2;
			foodBillLabel.Text = "Food bill";
			// 
			// foodBillAmount
			// 
			foodBillAmount.AutoSize = true;
			foodBillAmount.Font = new Font("Segoe UI", 8.5F);
			foodBillAmount.ForeColor = Color.FromArgb(60, 60, 60);
			foodBillAmount.Location = new Point(356, 42);
			foodBillAmount.Name = "foodBillAmount";
			foodBillAmount.Size = new Size(44, 20);
			foodBillAmount.TabIndex = 3;
			foodBillAmount.Text = "$0.00";
			// 
			// currentBillLabel
			// 
			currentBillLabel.AutoSize = true;
			currentBillLabel.Font = new Font("Segoe UI", 8.5F);
			currentBillLabel.ForeColor = Color.FromArgb(60, 60, 60);
			currentBillLabel.Location = new Point(14, 64);
			currentBillLabel.Name = "currentBillLabel";
			currentBillLabel.Size = new Size(82, 20);
			currentBillLabel.TabIndex = 4;
			currentBillLabel.Text = "Current bill";
			// 
			// currentBillAmount
			// 
			currentBillAmount.AutoSize = true;
			currentBillAmount.Font = new Font("Segoe UI", 8.5F);
			currentBillAmount.ForeColor = Color.FromArgb(60, 60, 60);
			currentBillAmount.Location = new Point(356, 64);
			currentBillAmount.Name = "currentBillAmount";
			currentBillAmount.Size = new Size(44, 20);
			currentBillAmount.TabIndex = 5;
			currentBillAmount.Text = "$0.00";
			// 
			// taxLabel
			// 
			taxLabel.AutoSize = true;
			taxLabel.Font = new Font("Segoe UI", 8.5F);
			taxLabel.ForeColor = Color.FromArgb(60, 60, 60);
			taxLabel.Location = new Point(14, 86);
			taxLabel.Name = "taxLabel";
			taxLabel.Size = new Size(30, 20);
			taxLabel.TabIndex = 6;
			taxLabel.Text = "Tax";
			// 
			// taxAmount
			// 
			taxAmount.AutoSize = true;
			taxAmount.Font = new Font("Segoe UI", 8.5F);
			taxAmount.ForeColor = Color.FromArgb(60, 60, 60);
			taxAmount.Location = new Point(356, 86);
			taxAmount.Name = "taxAmount";
			taxAmount.Size = new Size(44, 20);
			taxAmount.TabIndex = 7;
			taxAmount.Text = "$0.00";
			// 
			// totalLabel
			// 
			totalLabel.AutoSize = true;
			totalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			totalLabel.ForeColor = Color.FromArgb(39, 174, 96);
			totalLabel.Location = new Point(14, 114);
			totalLabel.Name = "totalLabel";
			totalLabel.Size = new Size(44, 20);
			totalLabel.TabIndex = 9;
			totalLabel.Text = "Total";
			// 
			// totalAmount
			// 
			totalAmount.AutoSize = true;
			totalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			totalAmount.ForeColor = Color.FromArgb(39, 174, 96);
			totalAmount.Location = new Point(356, 114);
			totalAmount.Name = "totalAmount";
			totalAmount.Size = new Size(49, 20);
			totalAmount.TabIndex = 10;
			totalAmount.Text = "$0.00";
			// 
			// divider
			// 
			divider.BorderStyle = BorderStyle.Fixed3D;
			divider.Location = new Point(14, 108);
			divider.Name = "divider";
			divider.Size = new Size(406, 2);
			divider.TabIndex = 8;
			// 
			// paymentLabel
			// 
			paymentLabel.AutoSize = true;
			paymentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			paymentLabel.ForeColor = Color.FromArgb(60, 60, 60);
			paymentLabel.Location = new Point(14, 146);
			paymentLabel.Name = "paymentLabel";
			paymentLabel.Size = new Size(71, 20);
			paymentLabel.TabIndex = 11;
			paymentLabel.Text = "Payment";
			// 
			// paymentComboBox
			// 
			paymentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			paymentComboBox.Items.AddRange(new object[] { "Credit", "Debit" });
			paymentComboBox.Location = new Point(14, 166);
			paymentComboBox.Name = "paymentComboBox";
			paymentComboBox.Size = new Size(128, 28);
			paymentComboBox.TabIndex = 12;
			// 
			// cardNumberTextBox
			// 
			cardNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
			cardNumberTextBox.Location = new Point(156, 166);
			cardNumberTextBox.Name = "cardNumberTextBox";
			cardNumberTextBox.PlaceholderText = "9999 - 9999 - 9999 - 9999";
			cardNumberTextBox.Size = new Size(264, 27);
			cardNumberTextBox.TabIndex = 13;
			// 
			// expLabel
			// 
			expLabel.AutoSize = true;
			expLabel.Font = new Font("Segoe UI", 8.5F);
			expLabel.ForeColor = Color.FromArgb(60, 60, 60);
			expLabel.Location = new Point(14, 206);
			expLabel.Name = "expLabel";
			expLabel.Size = new Size(83, 20);
			expLabel.TabIndex = 14;
			expLabel.Text = "Expiry date";
			// 
			// monthComboBox
			// 
			monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			monthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
			monthComboBox.Location = new Point(14, 224);
			monthComboBox.Name = "monthComboBox";
			monthComboBox.Size = new Size(65, 28);
			monthComboBox.TabIndex = 15;
			// 
			// slashLabel
			// 
			slashLabel.AutoSize = true;
			slashLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			slashLabel.ForeColor = Color.FromArgb(60, 60, 60);
			slashLabel.Location = new Point(84, 228);
			slashLabel.Name = "slashLabel";
			slashLabel.Size = new Size(16, 20);
			slashLabel.TabIndex = 16;
			slashLabel.Text = "/";
			// 
			// yearComboBox
			// 
			yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			yearComboBox.Items.AddRange(new object[] { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35" });
			yearComboBox.Location = new Point(98, 224);
			yearComboBox.Name = "yearComboBox";
			yearComboBox.Size = new Size(55, 28);
			yearComboBox.TabIndex = 17;
			// 
			// cvcComboBox
			// 
			cvcComboBox.BorderStyle = BorderStyle.FixedSingle;
			cvcComboBox.Location = new Point(168, 224);
			cvcComboBox.Name = "cvcComboBox";
			cvcComboBox.PlaceholderText = "CVC";
			cvcComboBox.Size = new Size(55, 27);
			cvcComboBox.TabIndex = 18;
			// 
			// cardTypeLabel
			// 
			cardTypeLabel.AutoSize = true;
			cardTypeLabel.Font = new Font("Segoe UI", 8.5F);
			cardTypeLabel.ForeColor = Color.FromArgb(60, 60, 60);
			cardTypeLabel.Location = new Point(240, 228);
			cardTypeLabel.Name = "cardTypeLabel";
			cardTypeLabel.Size = new Size(80, 20);
			cardTypeLabel.TabIndex = 19;
			cardTypeLabel.Text = "Card type :";
			// 
			// cardTypeView
			// 
			cardTypeView.AutoSize = true;
			cardTypeView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			cardTypeView.ForeColor = Color.FromArgb(39, 174, 96);
			cardTypeView.Location = new Point(320, 228);
			cardTypeView.Name = "cardTypeView";
			cardTypeView.Size = new Size(76, 20);
			cardTypeView.TabIndex = 20;
			cardTypeView.Text = "Unknown";
			// 
			// nextButton
			// 
			nextButton.BackColor = Color.LimeGreen;
			nextButton.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
			nextButton.FlatStyle = FlatStyle.Flat;
			nextButton.Font = new Font("Segoe UI", 9.5F);
			nextButton.ForeColor = Color.White;
			nextButton.Location = new Point(330, 254);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(90, 34);
			nextButton.TabIndex = 21;
			nextButton.Text = "Next";
			nextButton.UseVisualStyleBackColor = false;
			// 
			// FinalizePayment
			// 
			BackColor = Color.FromArgb(245, 247, 245);
			ClientSize = new Size(440, 300);
			Controls.Add(reservationLabel);
			Controls.Add(priceLabel);
			Controls.Add(foodBillLabel);
			Controls.Add(foodBillAmount);
			Controls.Add(currentBillLabel);
			Controls.Add(currentBillAmount);
			Controls.Add(taxLabel);
			Controls.Add(taxAmount);
			Controls.Add(divider);
			Controls.Add(totalLabel);
			Controls.Add(totalAmount);
			Controls.Add(paymentLabel);
			Controls.Add(paymentComboBox);
			Controls.Add(cardNumberTextBox);
			Controls.Add(expLabel);
			Controls.Add(monthComboBox);
			Controls.Add(slashLabel);
			Controls.Add(yearComboBox);
			Controls.Add(cvcComboBox);
			Controls.Add(cardTypeLabel);
			Controls.Add(cardTypeView);
			Controls.Add(nextButton);
			Font = new Font("Segoe UI", 9F);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FinalizePayment";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Finalize Payment";
			ResumeLayout(false);
			PerformLayout();


		}

		#region Fields
		private System.Windows.Forms.Label reservationLabel;
		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.Label foodBillLabel;
		public System.Windows.Forms.Label foodBillAmount;
		private System.Windows.Forms.Label currentBillLabel;
		public System.Windows.Forms.Label currentBillAmount;
		private System.Windows.Forms.Label taxLabel;
		public System.Windows.Forms.Label taxAmount;
		private System.Windows.Forms.Label totalLabel;
		public System.Windows.Forms.Label totalAmount;
		private System.Windows.Forms.Label divider;
		private System.Windows.Forms.Label paymentLabel;
		public System.Windows.Forms.ComboBox paymentComboBox;
		public System.Windows.Forms.TextBox cardNumberTextBox;
		private System.Windows.Forms.Label expLabel;
		public System.Windows.Forms.ComboBox monthComboBox;
		private System.Windows.Forms.Label slashLabel;
		public System.Windows.Forms.ComboBox yearComboBox;
		public System.Windows.Forms.TextBox cvcComboBox;
		private System.Windows.Forms.Label cardTypeLabel;
		public System.Windows.Forms.Label cardTypeView;
		private System.Windows.Forms.Button nextButton;
		#endregion
	}
}
