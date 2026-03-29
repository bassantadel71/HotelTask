namespace Hotel
{
	partial class Kitchen
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
			tabControl = new TabControl();
			TodoTabPage = new TabPage();
			onTheLineLabel = new Label();
			queueListBox = new ListBox();
			nameLabel = new Label();
			firstNameTextBox = new TextBox();
			lastNameTextBox = new TextBox();
			phoneNLabel = new Label();
			phoneNTextBox = new TextBox();
			roomTypeLabel = new Label();
			roomTypeTextBox = new TextBox();
			floorNLabel = new Label();
			floorNTextBox = new TextBox();
			roomNLabel = new Label();
			roomNTextBox = new TextBox();
			Todo = new GroupBox();
			breakfastQTLabel = new Label();
			breakfastTextBox = new TextBox();
			lunchQTLabel = new Label();
			lunchTextBox = new TextBox();
			dinnerQTLabel = new Label();
			dinnerTextBox = new TextBox();
			cleaningCheckBox = new CheckBox();
			towelCheckBox = new CheckBox();
			supplyCheckBox = new CheckBox();
			surpriseCheckBox = new CheckBox();
			foodSelectionButton = new Button();
			updateButton = new Button();
			overviewTabPage = new TabPage();
			overviewDataGridView = new DataGridView();
			tabControl.SuspendLayout();
			TodoTabPage.SuspendLayout();
			Todo.SuspendLayout();
			overviewTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)overviewDataGridView).BeginInit();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(TodoTabPage);
			tabControl.Controls.Add(overviewTabPage);
			tabControl.Font = new Font("Segoe UI", 9.5F);
			tabControl.Location = new Point(11, 11);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(976, 545);
			tabControl.TabIndex = 0;
			// 
			// TodoTabPage
			// 
			TodoTabPage.BackColor = Color.FromArgb(245, 247, 245);
			TodoTabPage.Controls.Add(onTheLineLabel);
			TodoTabPage.Controls.Add(queueListBox);
			TodoTabPage.Controls.Add(nameLabel);
			TodoTabPage.Controls.Add(firstNameTextBox);
			TodoTabPage.Controls.Add(lastNameTextBox);
			TodoTabPage.Controls.Add(phoneNLabel);
			TodoTabPage.Controls.Add(phoneNTextBox);
			TodoTabPage.Controls.Add(roomTypeLabel);
			TodoTabPage.Controls.Add(roomTypeTextBox);
			TodoTabPage.Controls.Add(floorNLabel);
			TodoTabPage.Controls.Add(floorNTextBox);
			TodoTabPage.Controls.Add(roomNLabel);
			TodoTabPage.Controls.Add(roomNTextBox);
			TodoTabPage.Controls.Add(Todo);
			TodoTabPage.Controls.Add(foodSelectionButton);
			TodoTabPage.Controls.Add(updateButton);
			TodoTabPage.Location = new Point(4, 30);
			TodoTabPage.Name = "TodoTabPage";
			TodoTabPage.Size = new Size(968, 511);
			TodoTabPage.TabIndex = 0;
			TodoTabPage.Text = "TODO*";
			// 
			// onTheLineLabel
			// 
			onTheLineLabel.AutoSize = true;
			onTheLineLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			onTheLineLabel.ForeColor = Color.FromArgb(39, 174, 96);
			onTheLineLabel.Location = new Point(680, 10);
			onTheLineLabel.Name = "onTheLineLabel";
			onTheLineLabel.Size = new Size(98, 23);
			onTheLineLabel.TabIndex = 0;
			onTheLineLabel.Text = "On the line";
			// 
			// queueListBox
			// 
			queueListBox.BorderStyle = BorderStyle.FixedSingle;
			queueListBox.Font = new Font("Segoe UI", 9F);
			queueListBox.Location = new Point(680, 35);
			queueListBox.Name = "queueListBox";
			queueListBox.Size = new Size(270, 322);
			queueListBox.TabIndex = 1;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Segoe UI", 8.5F);
			nameLabel.ForeColor = Color.FromArgb(60, 60, 60);
			nameLabel.Location = new Point(12, 12);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(49, 20);
			nameLabel.TabIndex = 2;
			nameLabel.Text = "Name";
			// 
			// firstNameTextBox
			// 
			firstNameTextBox.BackColor = Color.White;
			firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
			firstNameTextBox.Enabled = false;
			firstNameTextBox.Location = new Point(12, 32);
			firstNameTextBox.Name = "firstNameTextBox";
			firstNameTextBox.PlaceholderText = "First";
			firstNameTextBox.Size = new Size(155, 29);
			firstNameTextBox.TabIndex = 3;
			// 
			// lastNameTextBox
			// 
			lastNameTextBox.BackColor = Color.White;
			lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
			lastNameTextBox.Location = new Point(180, 32);
			lastNameTextBox.Name = "lastNameTextBox";
			lastNameTextBox.PlaceholderText = "Last";
			lastNameTextBox.Size = new Size(155, 29);
			lastNameTextBox.TabIndex = 4;
			// 
			// phoneNLabel
			// 
			phoneNLabel.AutoSize = true;
			phoneNLabel.Font = new Font("Segoe UI", 8.5F);
			phoneNLabel.ForeColor = Color.FromArgb(60, 60, 60);
			phoneNLabel.Location = new Point(12, 72);
			phoneNLabel.Name = "phoneNLabel";
			phoneNLabel.Size = new Size(105, 20);
			phoneNLabel.TabIndex = 5;
			phoneNLabel.Text = "Phone number";
			// 
			// phoneNTextBox
			// 
			phoneNTextBox.BackColor = Color.White;
			phoneNTextBox.BorderStyle = BorderStyle.FixedSingle;
			phoneNTextBox.Enabled = false;
			phoneNTextBox.Location = new Point(12, 92);
			phoneNTextBox.Name = "phoneNTextBox";
			phoneNTextBox.PlaceholderText = "Phone";
			phoneNTextBox.Size = new Size(323, 29);
			phoneNTextBox.TabIndex = 6;
			// 
			// roomTypeLabel
			// 
			roomTypeLabel.AutoSize = true;
			roomTypeLabel.Font = new Font("Segoe UI", 8.5F);
			roomTypeLabel.ForeColor = Color.FromArgb(60, 60, 60);
			roomTypeLabel.Location = new Point(12, 132);
			roomTypeLabel.Name = "roomTypeLabel";
			roomTypeLabel.Size = new Size(82, 20);
			roomTypeLabel.TabIndex = 7;
			roomTypeLabel.Text = "Room type";
			// 
			// roomTypeTextBox
			// 
			roomTypeTextBox.BackColor = Color.White;
			roomTypeTextBox.BorderStyle = BorderStyle.FixedSingle;
			roomTypeTextBox.Enabled = false;
			roomTypeTextBox.Location = new Point(12, 152);
			roomTypeTextBox.Name = "roomTypeTextBox";
			roomTypeTextBox.Size = new Size(155, 29);
			roomTypeTextBox.TabIndex = 8;
			// 
			// floorNLabel
			// 
			floorNLabel.AutoSize = true;
			floorNLabel.Font = new Font("Segoe UI", 8.5F);
			floorNLabel.ForeColor = Color.FromArgb(60, 60, 60);
			floorNLabel.Location = new Point(180, 132);
			floorNLabel.Name = "floorNLabel";
			floorNLabel.Size = new Size(56, 20);
			floorNLabel.TabIndex = 9;
			floorNLabel.Text = "Floor #";
			// 
			// floorNTextBox
			// 
			floorNTextBox.BackColor = Color.White;
			floorNTextBox.BorderStyle = BorderStyle.FixedSingle;
			floorNTextBox.Enabled = false;
			floorNTextBox.Location = new Point(180, 152);
			floorNTextBox.Name = "floorNTextBox";
			floorNTextBox.Size = new Size(75, 29);
			floorNTextBox.TabIndex = 10;
			// 
			// roomNLabel
			// 
			roomNLabel.AutoSize = true;
			roomNLabel.Font = new Font("Segoe UI", 8.5F);
			roomNLabel.ForeColor = Color.FromArgb(60, 60, 60);
			roomNLabel.Location = new Point(268, 132);
			roomNLabel.Name = "roomNLabel";
			roomNLabel.Size = new Size(62, 20);
			roomNLabel.TabIndex = 11;
			roomNLabel.Text = "Room #";
			// 
			// roomNTextBox
			// 
			roomNTextBox.BackColor = Color.White;
			roomNTextBox.BorderStyle = BorderStyle.FixedSingle;
			roomNTextBox.Enabled = false;
			roomNTextBox.Location = new Point(268, 152);
			roomNTextBox.Name = "roomNTextBox";
			roomNTextBox.Size = new Size(67, 29);
			roomNTextBox.TabIndex = 12;
			// 
			// Todo
			// 
			Todo.Controls.Add(breakfastQTLabel);
			Todo.Controls.Add(breakfastTextBox);
			Todo.Controls.Add(lunchQTLabel);
			Todo.Controls.Add(lunchTextBox);
			Todo.Controls.Add(dinnerQTLabel);
			Todo.Controls.Add(dinnerTextBox);
			Todo.Controls.Add(cleaningCheckBox);
			Todo.Controls.Add(towelCheckBox);
			Todo.Controls.Add(supplyCheckBox);
			Todo.Controls.Add(surpriseCheckBox);
			Todo.Font = new Font("Segoe UI", 8.5F);
			Todo.ForeColor = Color.FromArgb(60, 60, 60);
			Todo.Location = new Point(12, 205);
			Todo.Name = "Todo";
			Todo.Size = new Size(640, 200);
			Todo.TabIndex = 13;
			Todo.TabStop = false;
			Todo.Text = "Order Details";
			// 
			// breakfastQTLabel
			// 
			breakfastQTLabel.AutoSize = true;
			breakfastQTLabel.Font = new Font("Segoe UI", 8.5F);
			breakfastQTLabel.Location = new Point(12, 25);
			breakfastQTLabel.Name = "breakfastQTLabel";
			breakfastQTLabel.Size = new Size(70, 20);
			breakfastQTLabel.TabIndex = 0;
			breakfastQTLabel.Text = "Breakfast";
			// 
			// breakfastTextBox
			// 
			breakfastTextBox.BackColor = Color.White;
			breakfastTextBox.BorderStyle = BorderStyle.FixedSingle;
			breakfastTextBox.Enabled = false;
			breakfastTextBox.Location = new Point(12, 45);
			breakfastTextBox.Name = "breakfastTextBox";
			breakfastTextBox.PlaceholderText = "Qty";
			breakfastTextBox.Size = new Size(120, 26);
			breakfastTextBox.TabIndex = 1;
			// 
			// lunchQTLabel
			// 
			lunchQTLabel.AutoSize = true;
			lunchQTLabel.Font = new Font("Segoe UI", 8.5F);
			lunchQTLabel.Location = new Point(150, 25);
			lunchQTLabel.Name = "lunchQTLabel";
			lunchQTLabel.Size = new Size(47, 20);
			lunchQTLabel.TabIndex = 2;
			lunchQTLabel.Text = "Lunch";
			// 
			// lunchTextBox
			// 
			lunchTextBox.BackColor = Color.White;
			lunchTextBox.BorderStyle = BorderStyle.FixedSingle;
			lunchTextBox.Enabled = false;
			lunchTextBox.Location = new Point(150, 45);
			lunchTextBox.Name = "lunchTextBox";
			lunchTextBox.PlaceholderText = "Qty";
			lunchTextBox.Size = new Size(120, 26);
			lunchTextBox.TabIndex = 3;
			// 
			// dinnerQTLabel
			// 
			dinnerQTLabel.AutoSize = true;
			dinnerQTLabel.Font = new Font("Segoe UI", 8.5F);
			dinnerQTLabel.Location = new Point(290, 25);
			dinnerQTLabel.Name = "dinnerQTLabel";
			dinnerQTLabel.Size = new Size(53, 20);
			dinnerQTLabel.TabIndex = 4;
			dinnerQTLabel.Text = "Dinner";
			// 
			// dinnerTextBox
			// 
			dinnerTextBox.BackColor = Color.White;
			dinnerTextBox.BorderStyle = BorderStyle.FixedSingle;
			dinnerTextBox.Enabled = false;
			dinnerTextBox.Location = new Point(290, 45);
			dinnerTextBox.Name = "dinnerTextBox";
			dinnerTextBox.PlaceholderText = "Qty";
			dinnerTextBox.Size = new Size(120, 26);
			dinnerTextBox.TabIndex = 5;
			// 
			// cleaningCheckBox
			// 
			cleaningCheckBox.AutoSize = true;
			cleaningCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			cleaningCheckBox.Location = new Point(12, 90);
			cleaningCheckBox.Name = "cleaningCheckBox";
			cleaningCheckBox.Size = new Size(89, 24);
			cleaningCheckBox.TabIndex = 6;
			cleaningCheckBox.Text = "Cleaning";
			// 
			// towelCheckBox
			// 
			towelCheckBox.AutoSize = true;
			towelCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			towelCheckBox.Location = new Point(12, 115);
			towelCheckBox.Name = "towelCheckBox";
			towelCheckBox.Size = new Size(70, 24);
			towelCheckBox.TabIndex = 7;
			towelCheckBox.Text = "Towel";
			// 
			// supplyCheckBox
			// 
			supplyCheckBox.AutoSize = true;
			supplyCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			supplyCheckBox.Location = new Point(12, 140);
			supplyCheckBox.Name = "supplyCheckBox";
			supplyCheckBox.Size = new Size(76, 24);
			supplyCheckBox.TabIndex = 8;
			supplyCheckBox.Text = "Supply";
			// 
			// surpriseCheckBox
			// 
			surpriseCheckBox.AutoSize = true;
			surpriseCheckBox.ForeColor = Color.FromArgb(60, 60, 60);
			surpriseCheckBox.Location = new Point(150, 90);
			surpriseCheckBox.Name = "surpriseCheckBox";
			surpriseCheckBox.Size = new Size(147, 24);
			surpriseCheckBox.TabIndex = 9;
			surpriseCheckBox.Text = "Sweetest Surprise";
			// 
			// foodSelectionButton
			// 
			foodSelectionButton.BackColor = Color.White;
			foodSelectionButton.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
			foodSelectionButton.FlatStyle = FlatStyle.Flat;
			foodSelectionButton.Font = new Font("Segoe UI", 9.5F);
			foodSelectionButton.ForeColor = Color.Lime;
			foodSelectionButton.Location = new Point(680, 390);
			foodSelectionButton.Name = "foodSelectionButton";
			foodSelectionButton.Size = new Size(270, 38);
			foodSelectionButton.TabIndex = 14;
			foodSelectionButton.Text = "Food Selection";
			foodSelectionButton.UseVisualStyleBackColor = false;
			// 
			// updateButton
			// 
			updateButton.BackColor = Color.FromArgb(0, 192, 0);
			updateButton.FlatAppearance.BorderColor = Color.FromArgb(39, 174, 96);
			updateButton.FlatStyle = FlatStyle.Flat;
			updateButton.Font = new Font("Segoe UI", 9.5F);
			updateButton.ForeColor = Color.White;
			updateButton.Location = new Point(680, 440);
			updateButton.Name = "updateButton";
			updateButton.Size = new Size(270, 38);
			updateButton.TabIndex = 15;
			updateButton.Text = "Update changes";
			updateButton.UseVisualStyleBackColor = false;
			// 
			// overviewTabPage
			// 
			overviewTabPage.BackColor = Color.FromArgb(245, 247, 245);
			overviewTabPage.Controls.Add(overviewDataGridView);
			overviewTabPage.Location = new Point(4, 30);
			overviewTabPage.Name = "overviewTabPage";
			overviewTabPage.Size = new Size(968, 511);
			overviewTabPage.TabIndex = 1;
			overviewTabPage.Text = "Overview";
			// 
			// overviewDataGridView
			// 
			overviewDataGridView.AllowUserToAddRows = false;
			overviewDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			overviewDataGridView.BackgroundColor = Color.White;
			overviewDataGridView.BorderStyle = BorderStyle.None;
			overviewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			overviewDataGridView.Location = new Point(0, 12);
			overviewDataGridView.Name = "overviewDataGridView";
			overviewDataGridView.ReadOnly = true;
			overviewDataGridView.RowHeadersVisible = false;
			overviewDataGridView.RowHeadersWidth = 51;
			overviewDataGridView.Size = new Size(968, 480);
			overviewDataGridView.TabIndex = 0;
			// 
			// Kitchen
			// 
			BackColor = Color.FromArgb(245, 247, 245);
			ClientSize = new Size(1000, 570);
			Controls.Add(tabControl);
			Font = new Font("Segoe UI", 9F);
			Name = "Kitchen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Room Service";
			tabControl.ResumeLayout(false);
			TodoTabPage.ResumeLayout(false);
			TodoTabPage.PerformLayout();
			Todo.ResumeLayout(false);
			Todo.PerformLayout();
			overviewTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)overviewDataGridView).EndInit();
			ResumeLayout(false);
		}

		#region Fields
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage TodoTabPage;
		private System.Windows.Forms.Label onTheLineLabel;
		private System.Windows.Forms.ListBox queueListBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label phoneNLabel;
		private System.Windows.Forms.TextBox phoneNTextBox;
		private System.Windows.Forms.Label roomTypeLabel;
		private System.Windows.Forms.TextBox roomTypeTextBox;
		private System.Windows.Forms.Label floorNLabel;
		private System.Windows.Forms.TextBox floorNTextBox;
		private System.Windows.Forms.Label roomNLabel;
		private System.Windows.Forms.TextBox roomNTextBox;
		private System.Windows.Forms.GroupBox Todo;
		private System.Windows.Forms.Label breakfastQTLabel;
		private System.Windows.Forms.TextBox breakfastTextBox;
		private System.Windows.Forms.Label lunchQTLabel;
		private System.Windows.Forms.TextBox lunchTextBox;
		private System.Windows.Forms.Label dinnerQTLabel;
		private System.Windows.Forms.TextBox dinnerTextBox;
		private System.Windows.Forms.CheckBox cleaningCheckBox;
		private System.Windows.Forms.CheckBox towelCheckBox;
		private System.Windows.Forms.CheckBox supplyCheckBox;
		private System.Windows.Forms.CheckBox surpriseCheckBox;
		private System.Windows.Forms.Button foodSelectionButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TabPage overviewTabPage;
		private System.Windows.Forms.DataGridView overviewDataGridView;
		#endregion
	}
}
