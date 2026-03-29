namespace Hotel
{
	partial class PaymentForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.grpBill = new System.Windows.Forms.GroupBox();
			this.lblRoomCost = new System.Windows.Forms.Label();
			this.lblRoomCostVal = new System.Windows.Forms.Label();
			this.lblFoodBill = new System.Windows.Forms.Label();
			this.lblFoodBillVal = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblTotalVal = new System.Windows.Forms.Label();
			this.grpPayment = new System.Windows.Forms.GroupBox();
			this.lblPaymentType = new System.Windows.Forms.Label();
			this.cmbPaymentType = new System.Windows.Forms.ComboBox();
			this.lblCardNumber = new System.Windows.Forms.Label();
			this.txtCardNumber = new System.Windows.Forms.TextBox();
			this.lblCardExp = new System.Windows.Forms.Label();
			this.txtCardExp = new System.Windows.Forms.TextBox();
			this.lblCardCvc = new System.Windows.Forms.Label();
			this.txtCardCvc = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();

			this.grpBill.SuspendLayout();
			this.grpPayment.SuspendLayout();
			this.SuspendLayout();

			// ── lblTitle ─────────────────────────────────────────────────────
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
			this.lblTitle.Location = new System.Drawing.Point(18, 18);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Text = "Payment";

			// ── grpBill ──────────────────────────────────────────────────────
			this.grpBill.Controls.Add(this.lblRoomCost);
			this.grpBill.Controls.Add(this.lblRoomCostVal);
			this.grpBill.Controls.Add(this.lblFoodBill);
			this.grpBill.Controls.Add(this.lblFoodBillVal);
			this.grpBill.Controls.Add(this.lblTotal);
			this.grpBill.Controls.Add(this.lblTotalVal);
			this.grpBill.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.grpBill.Location = new System.Drawing.Point(18, 60);
			this.grpBill.Name = "grpBill";
			this.grpBill.Size = new System.Drawing.Size(400, 125);
			this.grpBill.TabStop = false;
			this.grpBill.Text = "Bill Summary";

			this.lblRoomCost.AutoSize = true;
			this.lblRoomCost.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblRoomCost.Location = new System.Drawing.Point(15, 32);
			this.lblRoomCost.Name = "lblRoomCost";
			this.lblRoomCost.Text = "Room Cost:";

			this.lblRoomCostVal.AutoSize = true;
			this.lblRoomCostVal.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblRoomCostVal.Location = new System.Drawing.Point(220, 32);
			this.lblRoomCostVal.Name = "lblRoomCostVal";
			this.lblRoomCostVal.Text = "$0.00";

			this.lblFoodBill.AutoSize = true;
			this.lblFoodBill.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblFoodBill.Location = new System.Drawing.Point(15, 60);
			this.lblFoodBill.Name = "lblFoodBill";
			this.lblFoodBill.Text = "Food Bill:";

			this.lblFoodBillVal.AutoSize = true;
			this.lblFoodBillVal.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblFoodBillVal.Location = new System.Drawing.Point(220, 60);
			this.lblFoodBillVal.Name = "lblFoodBillVal";
			this.lblFoodBillVal.Text = "$0.00";

			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
			this.lblTotal.Location = new System.Drawing.Point(15, 90);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Text = "Total:";

			this.lblTotalVal.AutoSize = true;
			this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
			this.lblTotalVal.Location = new System.Drawing.Point(220, 90);
			this.lblTotalVal.Name = "lblTotalVal";
			this.lblTotalVal.Text = "$0.00";

			// ── grpPayment ───────────────────────────────────────────────────
			this.grpPayment.Controls.Add(this.lblPaymentType);
			this.grpPayment.Controls.Add(this.cmbPaymentType);
			this.grpPayment.Controls.Add(this.lblCardNumber);
			this.grpPayment.Controls.Add(this.txtCardNumber);
			this.grpPayment.Controls.Add(this.lblCardExp);
			this.grpPayment.Controls.Add(this.txtCardExp);
			this.grpPayment.Controls.Add(this.lblCardCvc);
			this.grpPayment.Controls.Add(this.txtCardCvc);
			this.grpPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.grpPayment.Location = new System.Drawing.Point(18, 200);
			this.grpPayment.Name = "grpPayment";
			this.grpPayment.Size = new System.Drawing.Size(400, 230);
			this.grpPayment.TabStop = false;
			this.grpPayment.Text = "Card Details";

			this.lblPaymentType.AutoSize = true;
			this.lblPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblPaymentType.Location = new System.Drawing.Point(15, 32);
			this.lblPaymentType.Name = "lblPaymentType";
			this.lblPaymentType.Text = "Payment Type:";

			this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cmbPaymentType.Items.AddRange(new object[] { "Debit Card", "Credit Card" });
			this.cmbPaymentType.Location = new System.Drawing.Point(15, 55);
			this.cmbPaymentType.Name = "cmbPaymentType";
			this.cmbPaymentType.Size = new System.Drawing.Size(200, 28);
			this.cmbPaymentType.TabIndex = 0;

			this.lblCardNumber.AutoSize = true;
			this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblCardNumber.Location = new System.Drawing.Point(15, 95);
			this.lblCardNumber.Name = "lblCardNumber";
			this.lblCardNumber.Text = "Card Number:";

			this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCardNumber.Location = new System.Drawing.Point(15, 118);
			this.txtCardNumber.MaxLength = 50;
			this.txtCardNumber.Name = "txtCardNumber";
			this.txtCardNumber.PlaceholderText = "1234 5678 9012 3456";
			this.txtCardNumber.Size = new System.Drawing.Size(370, 28);
			this.txtCardNumber.TabIndex = 1;

			this.lblCardExp.AutoSize = true;
			this.lblCardExp.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblCardExp.Location = new System.Drawing.Point(15, 158);
			this.lblCardExp.Name = "lblCardExp";
			this.lblCardExp.Text = "Expiry (MM/YY):";

			this.txtCardExp.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCardExp.Location = new System.Drawing.Point(15, 180);
			this.txtCardExp.MaxLength = 10;
			this.txtCardExp.Name = "txtCardExp";
			this.txtCardExp.PlaceholderText = "MM/YY";
			this.txtCardExp.Size = new System.Drawing.Size(120, 28);
			this.txtCardExp.TabIndex = 2;

			this.lblCardCvc.AutoSize = true;
			this.lblCardCvc.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblCardCvc.Location = new System.Drawing.Point(220, 158);
			this.lblCardCvc.Name = "lblCardCvc";
			this.lblCardCvc.Text = "CVC:";

			this.txtCardCvc.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtCardCvc.Location = new System.Drawing.Point(220, 180);
			this.txtCardCvc.MaxLength = 10;
			this.txtCardCvc.Name = "txtCardCvc";
			this.txtCardCvc.PlaceholderText = "123";
			this.txtCardCvc.Size = new System.Drawing.Size(80, 28);
			this.txtCardCvc.TabIndex = 3;
			this.txtCardCvc.UseSystemPasswordChar = true;

			// ── btnConfirm ───────────────────────────────────────────────────
			this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.btnConfirm.ForeColor = System.Drawing.Color.White;
			this.btnConfirm.Location = new System.Drawing.Point(218, 450);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 40);
			this.btnConfirm.TabIndex = 4;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);

			// ── btnCancel ────────────────────────────────────────────────────
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(88, 450);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 40);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

			// ── Form ─────────────────────────────────────────────────────────
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(440, 510);  // fixed, never changes
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.grpBill);
			this.Controls.Add(this.grpPayment);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PaymentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payment";

			this.grpBill.ResumeLayout(false);
			this.grpBill.PerformLayout();
			this.grpPayment.ResumeLayout(false);
			this.grpPayment.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// ── Control declarations ──────────────────────────────────────────────
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.GroupBox grpBill;
		private System.Windows.Forms.Label lblRoomCost, lblRoomCostVal;
		private System.Windows.Forms.Label lblFoodBill, lblFoodBillVal;
		private System.Windows.Forms.Label lblTotal, lblTotalVal;
		private System.Windows.Forms.GroupBox grpPayment;
		private System.Windows.Forms.Label lblPaymentType;
		private System.Windows.Forms.ComboBox cmbPaymentType;
		private System.Windows.Forms.Label lblCardNumber;
		private System.Windows.Forms.TextBox txtCardNumber;
		private System.Windows.Forms.Label lblCardExp;
		private System.Windows.Forms.TextBox txtCardExp;
		private System.Windows.Forms.Label lblCardCvc;
		private System.Windows.Forms.TextBox txtCardCvc;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
	}
}
