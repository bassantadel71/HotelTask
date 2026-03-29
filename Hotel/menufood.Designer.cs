namespace Hotel
{
	partial class menufood
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		//private System.ComponentModel.IContainer components = null;

	
		private System.ComponentModel.IContainer components = null;

		// Control declarations
		private System.Windows.Forms.GroupBox groupFoodSelection;
		private System.Windows.Forms.NumericUpDown numDinnerQty;
		private System.Windows.Forms.NumericUpDown numLunchQty;
		private System.Windows.Forms.NumericUpDown numBreakfastQty;
		private System.Windows.Forms.CheckBox chkDinner;
		private System.Windows.Forms.CheckBox chkLunch;
		private System.Windows.Forms.CheckBox chkBreakfast;
		private System.Windows.Forms.GroupBox groupSpecialNeeds;
		private System.Windows.Forms.CheckBox chkSweetestSurprise;
		private System.Windows.Forms.CheckBox chkTowels;
		private System.Windows.Forms.CheckBox chkCleaning;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblTitle;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.groupFoodSelection = new System.Windows.Forms.GroupBox();
			this.numDinnerQty = new System.Windows.Forms.NumericUpDown();
			this.numLunchQty = new System.Windows.Forms.NumericUpDown();
			this.numBreakfastQty = new System.Windows.Forms.NumericUpDown();
			this.chkDinner = new System.Windows.Forms.CheckBox();
			this.chkLunch = new System.Windows.Forms.CheckBox();
			this.chkBreakfast = new System.Windows.Forms.CheckBox();
			this.groupSpecialNeeds = new System.Windows.Forms.GroupBox();
			this.chkSweetestSurprise = new System.Windows.Forms.CheckBox();
			this.chkTowels = new System.Windows.Forms.CheckBox();
			this.chkCleaning = new System.Windows.Forms.CheckBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();

			this.groupFoodSelection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDinnerQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLunchQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBreakfastQty)).BeginInit();
			this.groupSpecialNeeds.SuspendLayout();
			this.SuspendLayout();

			// groupFoodSelection
			this.groupFoodSelection.Controls.Add(this.numDinnerQty);
			this.groupFoodSelection.Controls.Add(this.numLunchQty);
			this.groupFoodSelection.Controls.Add(this.numBreakfastQty);
			this.groupFoodSelection.Controls.Add(this.chkDinner);
			this.groupFoodSelection.Controls.Add(this.chkLunch);
			this.groupFoodSelection.Controls.Add(this.chkBreakfast);
			this.groupFoodSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupFoodSelection.Location = new System.Drawing.Point(20, 70);
			this.groupFoodSelection.Name = "groupFoodSelection";
			this.groupFoodSelection.Size = new System.Drawing.Size(400, 150);
			this.groupFoodSelection.TabIndex = 0;
			this.groupFoodSelection.TabStop = false;
			this.groupFoodSelection.Text = "Food Selection";

			// numDinnerQty
			this.numDinnerQty.Enabled = false;
			this.numDinnerQty.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.numDinnerQty.Location = new System.Drawing.Point(180, 105);
			this.numDinnerQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numDinnerQty.Name = "numDinnerQty";
			this.numDinnerQty.Size = new System.Drawing.Size(60, 25);
			this.numDinnerQty.TabIndex = 5;
			this.numDinnerQty.Value = new decimal(new int[] { 1, 0, 0, 0 });

			// numLunchQty
			this.numLunchQty.Enabled = false;
			this.numLunchQty.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.numLunchQty.Location = new System.Drawing.Point(180, 70);
			this.numLunchQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numLunchQty.Name = "numLunchQty";
			this.numLunchQty.Size = new System.Drawing.Size(60, 25);
			this.numLunchQty.TabIndex = 4;
			this.numLunchQty.Value = new decimal(new int[] { 1, 0, 0, 0 });

			// numBreakfastQty
			this.numBreakfastQty.Enabled = false;
			this.numBreakfastQty.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.numBreakfastQty.Location = new System.Drawing.Point(180, 35);
			this.numBreakfastQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			this.numBreakfastQty.Name = "numBreakfastQty";
			this.numBreakfastQty.Size = new System.Drawing.Size(60, 25);
			this.numBreakfastQty.TabIndex = 3;
			this.numBreakfastQty.Value = new decimal(new int[] { 1, 0, 0, 0 });

			// chkDinner
			this.chkDinner.AutoSize = true;
			this.chkDinner.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.chkDinner.Location = new System.Drawing.Point(15, 107);
			this.chkDinner.Name = "chkDinner";
			this.chkDinner.Size = new System.Drawing.Size(98, 23);
			this.chkDinner.TabIndex = 2;
			this.chkDinner.Text = "Dinner ($15)";
			this.chkDinner.UseVisualStyleBackColor = true;
			this.chkDinner.CheckedChanged += new System.EventHandler(this.ChkDinner_CheckedChanged);

			// chkLunch
			this.chkLunch.AutoSize = true;
			this.chkLunch.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.chkLunch.Location = new System.Drawing.Point(15, 72);
			this.chkLunch.Name = "chkLunch";
			this.chkLunch.Size = new System.Drawing.Size(92, 23);
			this.chkLunch.TabIndex = 1;
			this.chkLunch.Text = "Lunch ($15)";
			this.chkLunch.UseVisualStyleBackColor = true;
			this.chkLunch.CheckedChanged += new System.EventHandler(this.ChkLunch_CheckedChanged);

			// chkBreakfast
			this.chkBreakfast.AutoSize = true;
			this.chkBreakfast.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.chkBreakfast.Location = new System.Drawing.Point(15, 37);
			this.chkBreakfast.Name = "chkBreakfast";
			this.chkBreakfast.Size = new System.Drawing.Size(90, 23);
			this.chkBreakfast.TabIndex = 0;
			this.chkBreakfast.Text = "Break Fast ($7)";
			this.chkBreakfast.UseVisualStyleBackColor = true;
			this.chkBreakfast.CheckedChanged += new System.EventHandler(this.ChkBreakfast_CheckedChanged);

			// groupSpecialNeeds
			this.groupSpecialNeeds.Controls.Add(this.chkSweetestSurprise);
			this.groupSpecialNeeds.Controls.Add(this.chkTowels);
			this.groupSpecialNeeds.Controls.Add(this.chkCleaning);
			this.groupSpecialNeeds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.groupSpecialNeeds.Location = new System.Drawing.Point(20, 235);
			this.groupSpecialNeeds.Name = "groupSpecialNeeds";
			this.groupSpecialNeeds.Size = new System.Drawing.Size(400, 130);
			this.groupSpecialNeeds.TabIndex = 1;
			this.groupSpecialNeeds.TabStop = false;
			this.groupSpecialNeeds.Text = "Special needs";

			// chkSweetestSurprise
			this.chkSweetestSurprise.AutoSize = true;
			this.chkSweetestSurprise.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.chkSweetestSurprise.Location = new System.Drawing.Point(15, 95);
			this.chkSweetestSurprise.Name = "chkSweetestSurprise";
			this.chkSweetestSurprise.Size = new System.Drawing.Size(129, 23);
			this.chkSweetestSurprise.TabIndex = 2;
			this.chkSweetestSurprise.Text = "Sweetest surprise";
			this.chkSweetestSurprise.UseVisualStyleBackColor = true;

			// chkTowels
			this.chkTowels.AutoSize = true;
			this.chkTowels.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.chkTowels.Location = new System.Drawing.Point(15, 65);
			this.chkTowels.Name = "chkTowels";
			this.chkTowels.Size = new System.Drawing.Size(68, 23);
			this.chkTowels.TabIndex = 1;
			this.chkTowels.Text = "Towels";
			this.chkTowels.UseVisualStyleBackColor = true;

			// chkCleaning
			this.chkCleaning.AutoSize = true;
			this.chkCleaning.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.chkCleaning.Location = new System.Drawing.Point(15, 35);
			this.chkCleaning.Name = "chkCleaning";
			this.chkCleaning.Size = new System.Drawing.Size(79, 23);
			this.chkCleaning.TabIndex = 0;
			this.chkCleaning.Text = "Cleaning";
			this.chkCleaning.UseVisualStyleBackColor = true;

			// btnNext
			this.btnNext.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnNext.ForeColor = System.Drawing.Color.White;
			this.btnNext.Location = new System.Drawing.Point(320, 380);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(100, 40);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);

			// lblTitle
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.lblTitle.Location = new System.Drawing.Point(15, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(190, 37);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Food and Menu";

			// Form1
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(440, 440);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.groupSpecialNeeds);
			this.Controls.Add(this.groupFoodSelection);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu Order Form";
			this.groupFoodSelection.ResumeLayout(false);
			this.groupFoodSelection.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDinnerQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLunchQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBreakfastQty)).EndInit();
			this.groupSpecialNeeds.ResumeLayout(false);
			this.groupSpecialNeeds.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}