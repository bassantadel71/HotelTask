using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem.UI
{
	partial class Frontend
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			resPanel = new TabControl();
			reservationPage = new TabPage();
			leftMPanel = new Panel();
			label6 = new Label();
			label5 = new Label();
			nameLabel = new Label();
			firstNameTextBox = new TextBox();
			lastNameTextBox = new TextBox();
			birthdayLabel = new Label();
			monthComboBox = new ComboBox();
			dayComboBox = new ComboBox();
			yearTextBox = new TextBox();
			genderLabel = new Label();
			genderComboBox = new ComboBox();
			phoneNumberLabel = new Label();
			phoneNumberTextBox = new TextBox();
			emailLabel = new Label();
			emailTextBox = new TextBox();
			addressLabel = new Label();
			addressTextBox = new TextBox();
			aptTextBox = new TextBox();
			cityTextBox = new TextBox();
			stateComboBox = new ComboBox();
			zipTextBox = new TextBox();
			middlePanel = new Panel();
			label4 = new Label();
			label3 = new Label();
			label1 = new Label();
			label2 = new Label();
			choiceLabel = new Label();
			qtGuestComboBox = new ComboBox();
			roomTypeComboBox = new ComboBox();
			floorComboBox = new ComboBox();
			roomNComboBox = new ComboBox();
			entryLabel = new Label();
			entryDatePicker = new DateTimePicker();
			departureLabel = new Label();
			depDatePicker = new DateTimePicker();
			foodMenuButton = new Button();
			checkinCheckBox = new CheckBox();
			smsCheckBox = new CheckBox();
			foodSupplyCheckBox = new CheckBox();
			finalizeButton = new Button();
			submitButton = new Button();
			rightMPanel = new Panel();
			label7 = new Label();
			resEditComboBox = new ComboBox();
			updateButton = new Button();
			deleteButton = new Button();
			editButton = new Button();
			newButton = new Button();
			searchPage = new TabPage();
			searchErrorLabel = new Label();
			searchDataGridView = new DataGridView();
			searchButton = new Button();
			searchTextBox = new TextBox();
			advViewPage = new TabPage();
			resTotalDataGridView = new DataGridView();
			roomPage = new TabPage();
			occupiedLabel = new Label();
			occupiedHeaderLabel = new Label();
			roomOccupiedListBox = new ListBox();
			reservedLabel = new Label();
			reservedHeaderLabel = new Label();
			roomReservedListBox = new ListBox();
			resPanel.SuspendLayout();
			reservationPage.SuspendLayout();
			leftMPanel.SuspendLayout();
			middlePanel.SuspendLayout();
			rightMPanel.SuspendLayout();
			searchPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
			advViewPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
			roomPage.SuspendLayout();
			SuspendLayout();
			// 
			// resPanel
			// 
			resPanel.Controls.Add(reservationPage);
			resPanel.Controls.Add(searchPage);
			resPanel.Controls.Add(advViewPage);
			resPanel.Controls.Add(roomPage);
			resPanel.Font = new Font("Segoe UI", 10F);
			resPanel.Location = new Point(11, 14);
			resPanel.Margin = new Padding(3, 4, 3, 4);
			resPanel.Name = "resPanel";
			resPanel.SelectedIndex = 0;
			resPanel.Size = new Size(1312, 775);
			resPanel.TabIndex = 0;
			// 
			// reservationPage
			// 
			reservationPage.BackColor = Color.WhiteSmoke;
			reservationPage.Controls.Add(leftMPanel);
			reservationPage.Controls.Add(middlePanel);
			reservationPage.Controls.Add(rightMPanel);
			reservationPage.Location = new Point(4, 32);
			reservationPage.Margin = new Padding(3, 4, 3, 4);
			reservationPage.Name = "reservationPage";
			reservationPage.Padding = new Padding(3, 4, 3, 4);
			reservationPage.Size = new Size(1304, 739);
			reservationPage.TabIndex = 0;
			reservationPage.Text = "Reservation";
			// 
			// leftMPanel
			// 
			leftMPanel.BackColor = Color.FromArgb(225, 225, 225);
			leftMPanel.Controls.Add(label6);
			leftMPanel.Controls.Add(label5);
			leftMPanel.Controls.Add(nameLabel);
			leftMPanel.Controls.Add(firstNameTextBox);
			leftMPanel.Controls.Add(lastNameTextBox);
			leftMPanel.Controls.Add(birthdayLabel);
			leftMPanel.Controls.Add(monthComboBox);
			leftMPanel.Controls.Add(dayComboBox);
			leftMPanel.Controls.Add(yearTextBox);
			leftMPanel.Controls.Add(genderLabel);
			leftMPanel.Controls.Add(genderComboBox);
			leftMPanel.Controls.Add(phoneNumberLabel);
			leftMPanel.Controls.Add(phoneNumberTextBox);
			leftMPanel.Controls.Add(emailLabel);
			leftMPanel.Controls.Add(emailTextBox);
			leftMPanel.Controls.Add(addressLabel);
			leftMPanel.Controls.Add(addressTextBox);
			leftMPanel.Controls.Add(aptTextBox);
			leftMPanel.Controls.Add(cityTextBox);
			leftMPanel.Controls.Add(stateComboBox);
			leftMPanel.Controls.Add(zipTextBox);
			leftMPanel.Location = new Point(6, 8);
			leftMPanel.Margin = new Padding(3, 4, 3, 4);
			leftMPanel.Name = "leftMPanel";
			leftMPanel.Size = new Size(460, 715);
			leftMPanel.TabIndex = 0;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label6.Location = new Point(188, 128);
			label6.Name = "label6";
			label6.Size = new Size(36, 20);
			label6.TabIndex = 18;
			label6.Text = "Day";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label5.Location = new Point(20, 128);
			label5.Name = "label5";
			label5.Size = new Size(56, 20);
			label5.TabIndex = 17;
			label5.Text = "Month";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			nameLabel.Location = new Point(19, 15);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(51, 20);
			nameLabel.TabIndex = 0;
			nameLabel.Text = "Name";
			// 
			// firstNameTextBox
			// 
			firstNameTextBox.Location = new Point(20, 45);
			firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
			firstNameTextBox.Name = "firstNameTextBox";
			firstNameTextBox.PlaceholderText = "First";
			firstNameTextBox.Size = new Size(207, 30);
			firstNameTextBox.TabIndex = 1;
			// 
			// lastNameTextBox
			// 
			lastNameTextBox.Location = new Point(235, 45);
			lastNameTextBox.Margin = new Padding(3, 4, 3, 4);
			lastNameTextBox.Name = "lastNameTextBox";
			lastNameTextBox.PlaceholderText = "Last";
			lastNameTextBox.Size = new Size(207, 30);
			lastNameTextBox.TabIndex = 2;
			// 
			// birthdayLabel
			// 
			birthdayLabel.AutoSize = true;
			birthdayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			birthdayLabel.Location = new Point(19, 100);
			birthdayLabel.Name = "birthdayLabel";
			birthdayLabel.Size = new Size(69, 20);
			birthdayLabel.TabIndex = 3;
			birthdayLabel.Text = "Birthday";
			// 
			// monthComboBox
			// 
			monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
			monthComboBox.Location = new Point(20, 152);
			monthComboBox.Margin = new Padding(3, 4, 3, 4);
			monthComboBox.Name = "monthComboBox";
			monthComboBox.Size = new Size(159, 31);
			monthComboBox.TabIndex = 3;
			// 
			// dayComboBox
			// 
			dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			dayComboBox.Location = new Point(188, 152);
			dayComboBox.Margin = new Padding(3, 4, 3, 4);
			dayComboBox.Name = "dayComboBox";
			dayComboBox.Size = new Size(109, 31);
			dayComboBox.TabIndex = 4;
			// 
			// yearTextBox
			// 
			yearTextBox.Location = new Point(307, 152);
			yearTextBox.Margin = new Padding(3, 4, 3, 4);
			yearTextBox.Name = "yearTextBox";
			yearTextBox.PlaceholderText = "Year";
			yearTextBox.Size = new Size(135, 30);
			yearTextBox.TabIndex = 5;
			// 
			// genderLabel
			// 
			genderLabel.AutoSize = true;
			genderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			genderLabel.Location = new Point(19, 202);
			genderLabel.Name = "genderLabel";
			genderLabel.Size = new Size(60, 20);
			genderLabel.TabIndex = 6;
			genderLabel.Text = "Gender";
			// 
			// genderComboBox
			// 
			genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			genderComboBox.Items.AddRange(new object[] { "Female ", "Male" });
			genderComboBox.Location = new Point(20, 232);
			genderComboBox.Margin = new Padding(3, 4, 3, 4);
			genderComboBox.Name = "genderComboBox";
			genderComboBox.Size = new Size(419, 31);
			genderComboBox.TabIndex = 6;
			// 
			// phoneNumberLabel
			// 
			phoneNumberLabel.AutoSize = true;
			phoneNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			phoneNumberLabel.Location = new Point(19, 286);
			phoneNumberLabel.Name = "phoneNumberLabel";
			phoneNumberLabel.Size = new Size(115, 20);
			phoneNumberLabel.TabIndex = 7;
			phoneNumberLabel.Text = "Phone Number";
			// 
			// phoneNumberTextBox
			// 
			phoneNumberTextBox.Location = new Point(20, 316);
			phoneNumberTextBox.Margin = new Padding(3, 4, 3, 4);
			phoneNumberTextBox.Name = "phoneNumberTextBox";
			phoneNumberTextBox.PlaceholderText = "(999) 999-999";
			phoneNumberTextBox.Size = new Size(419, 30);
			phoneNumberTextBox.TabIndex = 7;
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			emailLabel.Location = new Point(19, 372);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(108, 20);
			emailLabel.TabIndex = 8;
			emailLabel.Text = "Email Address";
			// 
			// emailTextBox
			// 
			emailTextBox.Location = new Point(20, 402);
			emailTextBox.Margin = new Padding(3, 4, 3, 4);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.PlaceholderText = "first.last@example.com";
			emailTextBox.Size = new Size(419, 30);
			emailTextBox.TabIndex = 8;
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			addressLabel.Location = new Point(19, 456);
			addressLabel.Name = "addressLabel";
			addressLabel.Size = new Size(102, 20);
			addressLabel.TabIndex = 9;
			addressLabel.Text = "Your Address";
			// 
			// addressTextBox
			// 
			addressTextBox.Location = new Point(20, 486);
			addressTextBox.Margin = new Padding(3, 4, 3, 4);
			addressTextBox.Name = "addressTextBox";
			addressTextBox.PlaceholderText = "Street address";
			addressTextBox.Size = new Size(419, 30);
			addressTextBox.TabIndex = 9;
			// 
			// aptTextBox
			// 
			aptTextBox.Location = new Point(20, 539);
			aptTextBox.Margin = new Padding(3, 4, 3, 4);
			aptTextBox.Name = "aptTextBox";
			aptTextBox.PlaceholderText = "Apt./Suite";
			aptTextBox.Size = new Size(201, 30);
			aptTextBox.TabIndex = 10;
			// 
			// cityTextBox
			// 
			cityTextBox.Location = new Point(230, 539);
			cityTextBox.Margin = new Padding(3, 4, 3, 4);
			cityTextBox.Name = "cityTextBox";
			cityTextBox.PlaceholderText = "City";
			cityTextBox.Size = new Size(209, 30);
			cityTextBox.TabIndex = 11;
			// 
			// stateComboBox
			// 
			stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			stateComboBox.Location = new Point(20, 595);
			stateComboBox.Margin = new Padding(3, 4, 3, 4);
			stateComboBox.Name = "stateComboBox";
			stateComboBox.Size = new Size(199, 31);
			stateComboBox.TabIndex = 12;
			// 
			// zipTextBox
			// 
			zipTextBox.Location = new Point(230, 595);
			zipTextBox.Margin = new Padding(3, 4, 3, 4);
			zipTextBox.Name = "zipTextBox";
			zipTextBox.PlaceholderText = "Zip code";
			zipTextBox.Size = new Size(209, 30);
			zipTextBox.TabIndex = 13;
			// 
			// middlePanel
			// 
			middlePanel.BackColor = Color.FromArgb(225, 225, 225);
			middlePanel.Controls.Add(label4);
			middlePanel.Controls.Add(label3);
			middlePanel.Controls.Add(label1);
			middlePanel.Controls.Add(label2);
			middlePanel.Controls.Add(choiceLabel);
			middlePanel.Controls.Add(qtGuestComboBox);
			middlePanel.Controls.Add(roomTypeComboBox);
			middlePanel.Controls.Add(floorComboBox);
			middlePanel.Controls.Add(roomNComboBox);
			middlePanel.Controls.Add(entryLabel);
			middlePanel.Controls.Add(entryDatePicker);
			middlePanel.Controls.Add(departureLabel);
			middlePanel.Controls.Add(depDatePicker);
			middlePanel.Controls.Add(foodMenuButton);
			middlePanel.Controls.Add(checkinCheckBox);
			middlePanel.Controls.Add(smsCheckBox);
			middlePanel.Controls.Add(foodSupplyCheckBox);
			middlePanel.Controls.Add(finalizeButton);
			middlePanel.Controls.Add(submitButton);
			middlePanel.Location = new Point(476, 8);
			middlePanel.Margin = new Padding(3, 4, 3, 4);
			middlePanel.Name = "middlePanel";
			middlePanel.Size = new Size(460, 715);
			middlePanel.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.Location = new Point(231, 114);
			label4.Name = "label4";
			label4.Size = new Size(113, 20);
			label4.TabIndex = 16;
			label4.Text = "Room Number";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.Location = new Point(21, 114);
			label3.Name = "label3";
			label3.Size = new Size(45, 20);
			label3.TabIndex = 15;
			label3.Text = "Floor";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(231, 42);
			label1.Name = "label1";
			label1.Size = new Size(88, 20);
			label1.TabIndex = 14;
			label1.Text = "Room Type";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(21, 42);
			label2.Name = "label2";
			label2.Size = new Size(48, 20);
			label2.TabIndex = 13;
			label2.Text = "guest";
			// 
			// choiceLabel
			// 
			choiceLabel.AutoSize = true;
			choiceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			choiceLabel.Location = new Point(21, 15);
			choiceLabel.Name = "choiceLabel";
			choiceLabel.Size = new Size(98, 20);
			choiceLabel.TabIndex = 0;
			choiceLabel.Text = "Your Choices";
			// 
			// qtGuestComboBox
			// 
			qtGuestComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			qtGuestComboBox.Location = new Point(21, 66);
			qtGuestComboBox.Margin = new Padding(3, 4, 3, 4);
			qtGuestComboBox.Name = "qtGuestComboBox";
			qtGuestComboBox.Size = new Size(200, 31);
			qtGuestComboBox.TabIndex = 0;
			// 
			// roomTypeComboBox
			// 
			roomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			roomTypeComboBox.Location = new Point(231, 66);
			roomTypeComboBox.Margin = new Padding(3, 4, 3, 4);
			roomTypeComboBox.Name = "roomTypeComboBox";
			roomTypeComboBox.Size = new Size(209, 31);
			roomTypeComboBox.TabIndex = 1;
			// 
			// floorComboBox
			// 
			floorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			floorComboBox.Location = new Point(21, 138);
			floorComboBox.Margin = new Padding(3, 4, 3, 4);
			floorComboBox.Name = "floorComboBox";
			floorComboBox.Size = new Size(200, 31);
			floorComboBox.TabIndex = 2;
			floorComboBox.SelectedIndexChanged += floorComboBox_SelectedIndexChanged;
			// 
			// roomNComboBox
			// 
			roomNComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			roomNComboBox.Location = new Point(231, 138);
			roomNComboBox.Margin = new Padding(3, 4, 3, 4);
			roomNComboBox.Name = "roomNComboBox";
			roomNComboBox.Size = new Size(209, 31);
			roomNComboBox.TabIndex = 3;
			// 
			// entryLabel
			// 
			entryLabel.AutoSize = true;
			entryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			entryLabel.Location = new Point(21, 198);
			entryLabel.Name = "entryLabel";
			entryLabel.Size = new Size(84, 20);
			entryLabel.TabIndex = 4;
			entryLabel.Text = "Entry Date";
			// 
			// entryDatePicker
			// 
			entryDatePicker.CustomFormat = "MM-dd-yyyy";
			entryDatePicker.Format = DateTimePickerFormat.Custom;
			entryDatePicker.Location = new Point(21, 227);
			entryDatePicker.Margin = new Padding(3, 4, 3, 4);
			entryDatePicker.Name = "entryDatePicker";
			entryDatePicker.Size = new Size(419, 30);
			entryDatePicker.TabIndex = 4;
			// 
			// departureLabel
			// 
			departureLabel.AutoSize = true;
			departureLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			departureLabel.Location = new Point(21, 279);
			departureLabel.Name = "departureLabel";
			departureLabel.Size = new Size(117, 20);
			departureLabel.TabIndex = 5;
			departureLabel.Text = "Departure Date";
			// 
			// depDatePicker
			// 
			depDatePicker.CustomFormat = "MM-dd-yyyy";
			depDatePicker.Format = DateTimePickerFormat.Custom;
			depDatePicker.Location = new Point(21, 308);
			depDatePicker.Margin = new Padding(3, 4, 3, 4);
			depDatePicker.Name = "depDatePicker";
			depDatePicker.Size = new Size(419, 30);
			depDatePicker.TabIndex = 5;
			// 
			// foodMenuButton
			// 
			foodMenuButton.BackColor = Color.FromArgb(0, 160, 80);
			foodMenuButton.FlatStyle = FlatStyle.Flat;
			foodMenuButton.Font = new Font("Segoe UI", 10F);
			foodMenuButton.ForeColor = Color.White;
			foodMenuButton.Location = new Point(21, 350);
			foodMenuButton.Margin = new Padding(3, 4, 3, 4);
			foodMenuButton.Name = "foodMenuButton";
			foodMenuButton.Size = new Size(419, 52);
			foodMenuButton.TabIndex = 6;
			foodMenuButton.Text = "Food and Menu";
			foodMenuButton.UseVisualStyleBackColor = false;
			foodMenuButton.Click += foodMenuButton_Click;
			// 
			// checkinCheckBox
			// 
			checkinCheckBox.AutoSize = true;
			checkinCheckBox.Location = new Point(21, 431);
			checkinCheckBox.Margin = new Padding(3, 4, 3, 4);
			checkinCheckBox.Name = "checkinCheckBox";
			checkinCheckBox.Size = new Size(105, 27);
			checkinCheckBox.TabIndex = 7;
			checkinCheckBox.Text = "Check in?";
			checkinCheckBox.CheckedChanged += checkinCheckBox_CheckedChanged;
			// 
			// smsCheckBox
			// 
			smsCheckBox.AutoSize = true;
			smsCheckBox.Location = new Point(140, 431);
			smsCheckBox.Margin = new Padding(3, 4, 3, 4);
			smsCheckBox.Name = "smsCheckBox";
			smsCheckBox.Size = new Size(116, 27);
			smsCheckBox.TabIndex = 8;
			smsCheckBox.Text = "Send SMS?";
			// 
			// foodSupplyCheckBox
			// 
			foodSupplyCheckBox.AutoSize = true;
			foodSupplyCheckBox.Location = new Point(259, 431);
			foodSupplyCheckBox.Margin = new Padding(3, 4, 3, 4);
			foodSupplyCheckBox.Name = "foodSupplyCheckBox";
			foodSupplyCheckBox.Size = new Size(187, 27);
			foodSupplyCheckBox.TabIndex = 9;
			foodSupplyCheckBox.Text = "Food/Supply Status?";
			foodSupplyCheckBox.CheckedChanged += foodSupplyCheckBox_CheckedChanged;
			// 
			// finalizeButton
			// 
			finalizeButton.BackColor = Color.FromArgb(0, 160, 80);
			finalizeButton.FlatStyle = FlatStyle.Flat;
			finalizeButton.Font = new Font("Segoe UI", 10F);
			finalizeButton.ForeColor = Color.White;
			finalizeButton.Location = new Point(21, 494);
			finalizeButton.Margin = new Padding(3, 4, 3, 4);
			finalizeButton.Name = "finalizeButton";
			finalizeButton.Size = new Size(419, 50);
			finalizeButton.TabIndex = 10;
			finalizeButton.Text = "Finalize Bill";
			finalizeButton.UseVisualStyleBackColor = false;
			finalizeButton.Click += finalizeButton_Click;
			// 
			// submitButton
			// 
			submitButton.BackColor = Color.FromArgb(0, 130, 60);
			submitButton.FlatStyle = FlatStyle.Flat;
			submitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			submitButton.ForeColor = Color.White;
			submitButton.Location = new Point(21, 560);
			submitButton.Margin = new Padding(3, 4, 3, 4);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(419, 55);
			submitButton.TabIndex = 11;
			submitButton.Text = "Submit";
			submitButton.UseVisualStyleBackColor = false;
			submitButton.Click += submitButton_Click;
			// 
			// rightMPanel
			// 
			rightMPanel.BackColor = Color.FromArgb(225, 225, 225);
			rightMPanel.Controls.Add(label7);
			rightMPanel.Controls.Add(resEditComboBox);
			rightMPanel.Controls.Add(updateButton);
			rightMPanel.Controls.Add(deleteButton);
			rightMPanel.Controls.Add(editButton);
			rightMPanel.Controls.Add(newButton);
			rightMPanel.Location = new Point(946, 8);
			rightMPanel.Margin = new Padding(3, 4, 3, 4);
			rightMPanel.Name = "rightMPanel";
			rightMPanel.Size = new Size(353, 715);
			rightMPanel.TabIndex = 2;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label7.Location = new Point(13, 15);
			label7.Name = "label7";
			label7.Size = new Size(100, 20);
			label7.TabIndex = 17;
			label7.Text = "Reservations";
			// 
			// resEditComboBox
			// 
			resEditComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			resEditComboBox.Location = new Point(13, 50);
			resEditComboBox.Margin = new Padding(3, 4, 3, 4);
			resEditComboBox.Name = "resEditComboBox";
			resEditComboBox.Size = new Size(327, 31);
			resEditComboBox.TabIndex = 0;
			resEditComboBox.Visible = false;
			resEditComboBox.SelectedIndexChanged += resEditButton_SelectedIndexChanged;
			// 
			// updateButton
			// 
			updateButton.BackColor = Color.FromArgb(0, 160, 80);
			updateButton.Enabled = false;
			updateButton.FlatStyle = FlatStyle.Flat;
			updateButton.Font = new Font("Segoe UI", 10F);
			updateButton.ForeColor = Color.White;
			updateButton.Location = new Point(13, 378);
			updateButton.Margin = new Padding(3, 4, 3, 4);
			updateButton.Name = "updateButton";
			updateButton.Size = new Size(327, 52);
			updateButton.TabIndex = 1;
			updateButton.Text = "Update";
			updateButton.UseVisualStyleBackColor = false;
			updateButton.Visible = false;
			updateButton.Click += updateButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.BackColor = Color.Red;
			deleteButton.FlatStyle = FlatStyle.Flat;
			deleteButton.Font = new Font("Segoe UI", 10F);
			deleteButton.ForeColor = Color.White;
			deleteButton.Location = new Point(13, 442);
			deleteButton.Margin = new Padding(3, 4, 3, 4);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(327, 52);
			deleteButton.TabIndex = 2;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = false;
			deleteButton.Visible = false;
			deleteButton.Click += deleteButton_Click;
			// 
			// editButton
			// 
			editButton.BackColor = Color.FromArgb(0, 160, 80);
			editButton.FlatStyle = FlatStyle.Flat;
			editButton.Font = new Font("Segoe UI", 10F);
			editButton.ForeColor = Color.White;
			editButton.Location = new Point(13, 515);
			editButton.Margin = new Padding(3, 4, 3, 4);
			editButton.Name = "editButton";
			editButton.Size = new Size(327, 50);
			editButton.TabIndex = 3;
			editButton.Text = "Edit Existing Reservation";
			editButton.UseVisualStyleBackColor = false;
			editButton.Click += editButton_Click;
			// 
			// newButton
			// 
			newButton.BackColor = Color.FromArgb(0, 130, 60);
			newButton.FlatStyle = FlatStyle.Flat;
			newButton.Font = new Font("Segoe UI", 10F);
			newButton.ForeColor = Color.White;
			newButton.Location = new Point(13, 578);
			newButton.Margin = new Padding(3, 4, 3, 4);
			newButton.Name = "newButton";
			newButton.Size = new Size(327, 50);
			newButton.TabIndex = 4;
			newButton.Text = "New Reservation";
			newButton.UseVisualStyleBackColor = false;
			newButton.Click += newButton_Click;
			// 
			// searchPage
			// 
			searchPage.BackColor = Color.WhiteSmoke;
			searchPage.Controls.Add(searchErrorLabel);
			searchPage.Controls.Add(searchDataGridView);
			searchPage.Controls.Add(searchButton);
			searchPage.Controls.Add(searchTextBox);
			searchPage.Location = new Point(4, 32);
			searchPage.Margin = new Padding(3, 4, 3, 4);
			searchPage.Name = "searchPage";
			searchPage.Padding = new Padding(3, 4, 3, 4);
			searchPage.Size = new Size(1304, 739);
			searchPage.TabIndex = 1;
			searchPage.Text = "Universal Search";
			// 
			// searchErrorLabel
			// 
			searchErrorLabel.AutoSize = true;
			searchErrorLabel.Font = new Font("Segoe UI", 12F);
			searchErrorLabel.ForeColor = Color.Gray;
			searchErrorLabel.Location = new Point(360, 62);
			searchErrorLabel.Name = "searchErrorLabel";
			searchErrorLabel.Size = new Size(161, 28);
			searchErrorLabel.TabIndex = 0;
			searchErrorLabel.Text = "No results found.";
			searchErrorLabel.Visible = false;
			// 
			// searchDataGridView
			// 
			searchDataGridView.AllowUserToAddRows = false;
			searchDataGridView.AllowUserToDeleteRows = false;
			searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			searchDataGridView.Location = new Point(91, 62);
			searchDataGridView.Margin = new Padding(3, 4, 3, 4);
			searchDataGridView.Name = "searchDataGridView";
			searchDataGridView.ReadOnly = true;
			searchDataGridView.RowHeadersWidth = 51;
			searchDataGridView.Size = new Size(1100, 244);
			searchDataGridView.TabIndex = 2;
			searchDataGridView.Visible = false;
			// 
			// searchButton
			// 
			searchButton.BackColor = Color.FromArgb(0, 160, 80);
			searchButton.FlatStyle = FlatStyle.Flat;
			searchButton.ForeColor = Color.White;
			searchButton.Location = new Point(970, 322);
			searchButton.Margin = new Padding(3, 4, 3, 4);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(100, 39);
			searchButton.TabIndex = 1;
			searchButton.Text = "Search";
			searchButton.UseVisualStyleBackColor = false;
			searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchTextBox
			// 
			searchTextBox.Location = new Point(100, 325);
			searchTextBox.Margin = new Padding(3, 4, 3, 4);
			searchTextBox.Name = "searchTextBox";
			searchTextBox.PlaceholderText = "Search by name, phone or ID...";
			searchTextBox.Size = new Size(860, 30);
			searchTextBox.TabIndex = 0;
			searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
			// 
			// advViewPage
			// 
			advViewPage.AutoScroll = true;
			advViewPage.BackColor = Color.WhiteSmoke;
			advViewPage.Controls.Add(resTotalDataGridView);
			advViewPage.Location = new Point(4, 32);
			advViewPage.Margin = new Padding(3, 4, 3, 4);
			advViewPage.Name = "advViewPage";
			advViewPage.Padding = new Padding(3, 4, 3, 4);
			advViewPage.Size = new Size(1304, 739);
			advViewPage.TabIndex = 2;
			advViewPage.Text = "Reservation Adv. View";
			// 
			// resTotalDataGridView
			// 
			resTotalDataGridView.AllowUserToAddRows = false;
			resTotalDataGridView.AllowUserToDeleteRows = false;
			resTotalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			resTotalDataGridView.Location = new Point(0, 5);
			resTotalDataGridView.Margin = new Padding(3, 4, 3, 4);
			resTotalDataGridView.Name = "resTotalDataGridView";
			resTotalDataGridView.ReadOnly = true;
			resTotalDataGridView.RowHeadersWidth = 51;
			resTotalDataGridView.Size = new Size(1301, 719);
			resTotalDataGridView.TabIndex = 0;
			// 
			// roomPage
			// 
			roomPage.BackColor = Color.WhiteSmoke;
			roomPage.Controls.Add(occupiedLabel);
			roomPage.Controls.Add(occupiedHeaderLabel);
			roomPage.Controls.Add(roomOccupiedListBox);
			roomPage.Controls.Add(reservedLabel);
			roomPage.Controls.Add(reservedHeaderLabel);
			roomPage.Controls.Add(roomReservedListBox);
			roomPage.Location = new Point(4, 32);
			roomPage.Margin = new Padding(3, 4, 3, 4);
			roomPage.Name = "roomPage";
			roomPage.Padding = new Padding(3, 4, 3, 4);
			roomPage.Size = new Size(1304, 739);
			roomPage.TabIndex = 3;
			roomPage.Text = "Room Availability";
			// 
			// occupiedLabel
			// 
			occupiedLabel.AutoSize = true;
			occupiedLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			occupiedLabel.Location = new Point(4, 10);
			occupiedLabel.Name = "occupiedLabel";
			occupiedLabel.Size = new Size(85, 23);
			occupiedLabel.TabIndex = 0;
			occupiedLabel.Text = "Occupied";
			// 
			// occupiedHeaderLabel
			// 
			occupiedHeaderLabel.AutoSize = true;
			occupiedHeaderLabel.Font = new Font("Segoe UI", 9F);
			occupiedHeaderLabel.ForeColor = Color.DimGray;
			occupiedHeaderLabel.Location = new Point(4, 45);
			occupiedHeaderLabel.Name = "occupiedHeaderLabel";
			occupiedHeaderLabel.Size = new Size(351, 20);
			occupiedHeaderLabel.TabIndex = 1;
			occupiedHeaderLabel.Text = "Room#  |  Type   |   ID#   |       Name        |    Phone #";
			// 
			// roomOccupiedListBox
			// 
			roomOccupiedListBox.BackColor = Color.FromArgb(224, 224, 224);
			roomOccupiedListBox.BorderStyle = BorderStyle.None;
			roomOccupiedListBox.Font = new Font("Courier New", 9F);
			roomOccupiedListBox.FormattingEnabled = true;
			roomOccupiedListBox.HorizontalScrollbar = true;
			roomOccupiedListBox.IntegralHeight = false;
			roomOccupiedListBox.Location = new Point(4, 78);
			roomOccupiedListBox.Margin = new Padding(3, 4, 3, 4);
			roomOccupiedListBox.Name = "roomOccupiedListBox";
			roomOccupiedListBox.Size = new Size(600, 638);
			roomOccupiedListBox.TabIndex = 0;
			// 
			// reservedLabel
			// 
			reservedLabel.AutoSize = true;
			reservedLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			reservedLabel.Location = new Point(614, 10);
			reservedLabel.Name = "reservedLabel";
			reservedLabel.Size = new Size(83, 23);
			reservedLabel.TabIndex = 2;
			reservedLabel.Text = "Reserved";
			// 
			// reservedHeaderLabel
			// 
			reservedHeaderLabel.AutoSize = true;
			reservedHeaderLabel.Font = new Font("Segoe UI", 9F);
			reservedHeaderLabel.ForeColor = Color.DimGray;
			reservedHeaderLabel.Location = new Point(614, 45);
			reservedHeaderLabel.Name = "reservedHeaderLabel";
			reservedHeaderLabel.Size = new Size(515, 20);
			reservedHeaderLabel.TabIndex = 3;
			reservedHeaderLabel.Text = "Room#  |  Type   |   ID#   |       Name        |    Phone #    |    Entry    |  Departure";
			// 
			// roomReservedListBox
			// 
			roomReservedListBox.BackColor = Color.FromArgb(224, 224, 224);
			roomReservedListBox.BorderStyle = BorderStyle.None;
			roomReservedListBox.Font = new Font("Courier New", 9F);
			roomReservedListBox.FormattingEnabled = true;
			roomReservedListBox.HorizontalScrollbar = true;
			roomReservedListBox.IntegralHeight = false;
			roomReservedListBox.Location = new Point(614, 78);
			roomReservedListBox.Margin = new Padding(3, 4, 3, 4);
			roomReservedListBox.Name = "roomReservedListBox";
			roomReservedListBox.Size = new Size(683, 638);
			roomReservedListBox.TabIndex = 1;
			// 
			// Frontend
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1340, 812);
			Controls.Add(resPanel);
			Font = new Font("Segoe UI", 9F);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Frontend";
			Text = "Hotel Management System";
			Load += Frontend_Load_1;
			resPanel.ResumeLayout(false);
			reservationPage.ResumeLayout(false);
			leftMPanel.ResumeLayout(false);
			leftMPanel.PerformLayout();
			middlePanel.ResumeLayout(false);
			middlePanel.PerformLayout();
			rightMPanel.ResumeLayout(false);
			rightMPanel.PerformLayout();
			searchPage.ResumeLayout(false);
			searchPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
			advViewPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
			roomPage.ResumeLayout(false);
			roomPage.PerformLayout();
			ResumeLayout(false);
		}

		// ── Field declarations ──────────────────────────────────────────────
		private TabControl resPanel;
		private TabPage reservationPage, searchPage, advViewPage, roomPage;
		private Panel leftMPanel, middlePanel, rightMPanel;

		// left panel
		private Label nameLabel, birthdayLabel, genderLabel, phoneNumberLabel;
		private Label emailLabel, addressLabel;
		private TextBox firstNameTextBox, lastNameTextBox, yearTextBox;
		private TextBox phoneNumberTextBox, emailTextBox;
		private TextBox addressTextBox, aptTextBox, cityTextBox, zipTextBox;
		private ComboBox monthComboBox, dayComboBox, genderComboBox, stateComboBox;

		// middle panel
		private Label choiceLabel, entryLabel, departureLabel;
		private ComboBox qtGuestComboBox, roomTypeComboBox, floorComboBox, roomNComboBox;
		private DateTimePicker entryDatePicker, depDatePicker;
		private Button foodMenuButton, finalizeButton, submitButton;
		private CheckBox checkinCheckBox, smsCheckBox, foodSupplyCheckBox;

		// right panel
		private ComboBox resEditComboBox;
		private Button updateButton, deleteButton, editButton, newButton;

		// search tab
		private TextBox searchTextBox;
		private Button searchButton;
		private Label searchErrorLabel;
		private DataGridView searchDataGridView;

		// adv view tab
		private DataGridView resTotalDataGridView;

		// room tab
		private Label occupiedLabel, occupiedHeaderLabel;
		private Label reservedLabel, reservedHeaderLabel;
		private ListBox roomOccupiedListBox, roomReservedListBox;
		private Label label1;
		private Label label2;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label7;
	}
}
