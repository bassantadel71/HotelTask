using BLL.Entities;
using BLL.EntityManager;
using DLL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem.UI
{
	public partial class Frontend : Form
	{
		// ── Managers ──────────────────────────────────────────────────────
		private readonly ReservationDbContext _context;
		private readonly CustomerManager _customerManager;
		private readonly RoomManager _roomManager;
		private readonly ReservationManager _reservationManager;
		private int _serviceId = 0;
		private decimal _foodBill = 0m;
		private Service _service = null;
		private int _paymentId = 0;
		private float _totalBill = 0f;
		private Payment _payment = null;

		// ── State ─────────────────────────────────────────────────────────
		private Reservation? _currentReservation;
		private bool _isEditMode = false;

		// ── Constructor ───────────────────────────────────────────────────
		public Frontend()
		{
			InitializeComponent();

			_context = new ReservationDbContext();
			_customerManager = new CustomerManager(_context);
			_roomManager = new RoomManager(_context.Database.GetConnectionString());
			_reservationManager = new ReservationManager(_context);
		}

		// ══════════════════════════════════════════════════════════════════
		//  FORM LOAD
		// ══════════════════════════════════════════════════════════════════
		private void Frontend_Load_1(object sender, EventArgs e)
		{
			_context.Database.EnsureCreated();

			PopulateStaticComboBoxes();
			LoadReservationComboBox();
			LoadAllReservationsGrid();
			LoadRoomAvailability();

			SetNewReservationMode();
		}

		// ══════════════════════════════════════════════════════════════════
		//  POPULATE STATIC COMBOBOXES
		// ══════════════════════════════════════════════════════════════════
		private void PopulateStaticComboBoxes()
		{
			// Months
			monthComboBox.Items.Clear();
			monthComboBox.Items.AddRange(new object[]
			{ "January","February","March","April","May","June",
			  "July","August","September","October","November","December" });

			// Days
			dayComboBox.Items.Clear();
			for (int d = 1; d <= 31; d++)
				dayComboBox.Items.Add(d.ToString("00"));

			// Gender
			genderComboBox.Items.Clear();
			genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });

			// States
			stateComboBox.Items.Clear();
			stateComboBox.Items.AddRange(new object[]
			{ "Alabama","Alaska","Arizona","Arkansas","California","Colorado",
			  "Connecticut","Delaware","Florida","Georgia","Hawaii","Idaho",
			  "Illinois","Indiana","Iowa","Kansas","Kentucky","Louisiana",
			  "Maine","Maryland","Massachusetts","Michigan","Minnesota",
			  "Mississippi","Missouri","Montana","Nebraska","Nevada",
			  "New Hampshire","New Jersey","New Mexico","New York",
			  "North Carolina","North Dakota","Ohio","Oklahoma","Oregon",
			  "Pennsylvania","Rhode Island","South Carolina","South Dakota",
			  "Tennessee","Texas","Utah","Vermont","Virginia","Washington",
			  "West Virginia","Wisconsin","Wyoming" });

			// Guests
			qtGuestComboBox.Items.Clear();
			for (int g = 1; g <= 10; g++)
				qtGuestComboBox.Items.Add(g.ToString());

			// Room types
			roomTypeComboBox.Items.Clear();
			roomTypeComboBox.Items.AddRange(new object[]
			{ "Single", "Double", "Twin", "Duplex", "Suite" });

			// Floors
			floorComboBox.Items.Clear();
			for (int f = 1; f <= 5; f++)
				floorComboBox.Items.Add(f.ToString());

			// Date pickers default
			entryDatePicker.Value = DateTime.Today;
			depDatePicker.Value = DateTime.Today.AddDays(1);
			entryDatePicker.MinDate = DateTime.Today;
			depDatePicker.MinDate = DateTime.Today.AddDays(1);
		}

		// ══════════════════════════════════════════════════════════════════
		//  ROOM COMBOBOX — filter by floor
		// ══════════════════════════════════════════════════════════════════
		private void floorComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			roomNComboBox.Items.Clear();
			roomNComboBox.Text = "0";
			if (!int.TryParse(floorComboBox.SelectedItem?.ToString(), out int floor)) return;

			var rooms = _roomManager.GetRoomsByFloor(floor);
			foreach (var r in rooms)
				roomNComboBox.Items.Add(r.RoomNumber.ToString());

			if (roomNComboBox.Items.Count == 0)
			{
				for (int i = 1; i <= 10; i++)
					roomNComboBox.Items.Add($"{floor}{i:00}");
			}
		}

		// ══════════════════════════════════════════════════════════════════
		//  NEW RESERVATION MODE
		// ══════════════════════════════════════════════════════════════════
		private void SetNewReservationMode()
		{
			_isEditMode = false;
			_currentReservation = null;

			ClearAllFields();

			// Show Submit, hide edit controls
			submitButton.Visible = true;
			submitButton.Text = "Submit";
			updateButton.Visible = false;
			updateButton.Enabled = false;
			deleteButton.Visible = false;
			deleteButton.Enabled = false;

			// Hide and reset the reservation picker
			resEditComboBox.Visible = false;
			resEditComboBox.SelectedIndex = -1;
		}

		private void newButton_Click(object sender, EventArgs e) => SetNewReservationMode();

		// ══════════════════════════════════════════════════════════════════
		//  EDIT MODE
		// ══════════════════════════════════════════════════════════════════
		private void editButton_Click(object sender, EventArgs e)
		{
			_isEditMode = true;
			_currentReservation = null;

			LoadReservationComboBox();

			// Show the combobox so the user can pick a reservation
			resEditComboBox.Visible = true;
			resEditComboBox.SelectedIndex = -1;

			// Show edit action buttons, hide submit
			submitButton.Visible = false;
			updateButton.Visible = true;
			updateButton.Enabled = false;   // disabled until a reservation is selected
			deleteButton.Visible = true;
			deleteButton.Enabled = false;   // disabled until a reservation is selected

			ClearAllFields();
		}

		private void LoadReservationComboBox()
		{
			resEditComboBox.Items.Clear();
			var list = _reservationManager.GetReservationDisplayList();
			foreach (var item in list)
				resEditComboBox.Items.Add(item);
		}

		private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = resEditComboBox.SelectedItem?.ToString();
			if (selected == null) return;

			int id = _reservationManager.ExtractIdFromDisplay(selected);
			if (id < 0) return;

			var res = _reservationManager.GetReservationById(id);
			if (res == null) return;

			_currentReservation = res;
			PopulateFieldsFromReservation(res);

			// Now that a reservation is loaded, enable Update and Delete
			updateButton.Enabled = true;
			deleteButton.Enabled = true;
		}

		private void PopulateFieldsFromReservation(Reservation res)
		{
			var c = res.Customer;
			if (c != null)
			{
				firstNameTextBox.Text = c.FirstName;
				lastNameTextBox.Text = c.LastName;
				phoneNumberTextBox.Text = c.PhoneNumber;
				emailTextBox.Text = c.EmailAddress;

				genderComboBox.SelectedItem = c.Gender;

				if (c.Address != null)
				{
					addressLabel.Text = c.Address.StreetAddress;
					aptTextBox.Text = c.Address.AptSuite;
					cityTextBox.Text = c.Address.City;
					stateComboBox.SelectedItem = c.Address.State;
					zipTextBox.Text = c.Address.ZipCode;
				}
			}

			qtGuestComboBox.SelectedItem = res.NumberGuest.ToString();
			entryDatePicker.Value = res.ArrivalTime;
			depDatePicker.Value = res.LeavingTime;
			checkinCheckBox.Checked = res.CheckIn;
			foodSupplyCheckBox.Checked = res.SupplyStatus;

			if (res.Room != null)
			{
				floorComboBox.SelectedItem = res.Room.RoomFloor.ToString();
				roomTypeComboBox.SelectedItem = res.Room.RoomType;
				roomNComboBox.SelectedItem = res.Room.RoomNumber.ToString();
			}
		}

		// ══════════════════════════════════════════════════════════════════
		//  SUBMIT — create new reservation
		// ══════════════════════════════════════════════════════════════════
		private void submitButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
				string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				MessageBox.Show("Please fill in the guest name.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (foodSupplyCheckBox.Checked && _serviceId == 0)
			{
				MessageBox.Show("Please open the Food Menu and select at least one meal.",
					"Food Service Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (_paymentId == 0)
			{
				MessageBox.Show("Please complete the payment step before submitting.",
					"Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!ValidateInputs()) return;

			try
			{
				var customer = BuildCustomerFromFields();
				_customerManager.AddCustomer(customer);

				var room = GetOrCreateRoom();
				if (room == null)
				{
					MessageBox.Show("Could not resolve the selected room.", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var reservation = new Reservation
				{
					CustomerId = customer.Id,
					RoomId = room.Id,
					NumberGuest = int.Parse(qtGuestComboBox.SelectedItem!.ToString()!),
					ArrivalTime = entryDatePicker.Value.Date,
					LeavingTime = depDatePicker.Value.Date,
					CheckIn = checkinCheckBox.Checked,
					SupplyStatus = foodSupplyCheckBox.Checked,
					ServiceId = _serviceId,
					PaymentId = _paymentId,
				};

				_reservationManager.AddReservation(reservation);

				MessageBox.Show(
					$"Reservation submitted successfully!\n\n" +
					$"Service ID : {(_serviceId > 0 ? _serviceId.ToString() : "None")}\n" +
					$"Payment ID : {_paymentId}\n" +
					$"Total Bill : ${_totalBill:F2}",
					"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				ResetForm();
				LoadReservationComboBox();
				LoadAllReservationsGrid();
				LoadRoomAvailability();
				SetNewReservationMode();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving reservation:\n{ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// ══════════════════════════════════════════════════════════════════
		//  UPDATE
		// ══════════════════════════════════════════════════════════════════
		private void updateButton_Click(object sender, EventArgs e)
		{
			if (_currentReservation == null)
			{
				MessageBox.Show("Please select a reservation to edit first.",
					"No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!ValidateInputs()) return;

			try
			{
				var room = GetOrCreateRoom();
				if (room == null) return;

				// ── Build an updated Reservation with scalar values only ───────
				// We pass updated field values into UpdateReservation which then
				// copies them onto the ALREADY-TRACKED entity — never swapping
				// the Customer object (which causes the tracking conflict).
				var updatedValues = new Reservation
				{
					Id = _currentReservation.Id,
					NumberGuest = int.Parse(qtGuestComboBox.SelectedItem!.ToString()!),
					ArrivalTime = entryDatePicker.Value.Date,
					LeavingTime = depDatePicker.Value.Date,
					CheckIn = checkinCheckBox.Checked,
					SupplyStatus = foodSupplyCheckBox.Checked,
					RoomId = room.Id,

					// Pass updated customer fields as a plain object —
					// ReservationManager copies the scalar fields, never attaches this object
					Customer = new BLL.Entities.Customer
					{
						FirstName = firstNameTextBox.Text.Trim(),
						LastName = lastNameTextBox.Text.Trim(),
						PhoneNumber = phoneNumberTextBox.Text.Trim(),
						EmailAddress = emailTextBox.Text.Trim(),
						Gender = genderComboBox.SelectedItem?.ToString() ?? "",
						BirthDay = DateTime.Now,
						Address = new BLL.Entities.Address
						{
							StreetAddress = addressTextBox.Text.Trim(),
							AptSuite = aptTextBox.Text.Trim(),
							City = cityTextBox.Text.Trim(),
							State = stateComboBox.SelectedItem?.ToString() ?? "",
							ZipCode = zipTextBox.Text.Trim()
						}
					}
				};

				_reservationManager.UpdateReservation(updatedValues);

				MessageBox.Show("Reservation updated successfully!",
					"Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

				LoadReservationComboBox();
				LoadAllReservationsGrid();
				LoadRoomAvailability();
				SetNewReservationMode();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating reservation:\n{ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// ══════════════════════════════════════════════════════════════════
		//  DELETE
		// ══════════════════════════════════════════════════════════════════
		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (_currentReservation == null)
			{
				MessageBox.Show("Please select a reservation to delete.",
					"No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var confirm = MessageBox.Show(
				$"Are you sure you want to delete Reservation #{_currentReservation.Id}?",
				"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (confirm != DialogResult.Yes) return;

			_reservationManager.DeleteReservation(_currentReservation.Id);

			MessageBox.Show("Reservation deleted.", "Deleted",
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			LoadReservationComboBox();
			LoadAllReservationsGrid();
			LoadRoomAvailability();
			SetNewReservationMode();
		}

		// ══════════════════════════════════════════════════════════════════
		//  PAYMENT BUTTON
		// ══════════════════════════════════════════════════════════════════
		private void finalizeButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
				string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				MessageBox.Show("Please fill in the guest name before proceeding to payment.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (foodSupplyCheckBox.Checked && _serviceId == 0)
			{
				MessageBox.Show("Please open the Food Menu and complete your food selection first.",
					"Food Service Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			decimal roomCost = CalculateRoomCost();

			_paymentId = 0;
			_payment = null;
			ResetPaymentButton();

			using (var payForm = new Hotel.PaymentForm(roomCost, _foodBill))
			{
				if (payForm.ShowDialog(this) == DialogResult.OK)
				{
					_paymentId = payForm.PaymentId;
					_totalBill = payForm.TotalBill;
					_payment = payForm.CreatedPayment;

					finalizeButton.Text = $"Payment ✓  (${_totalBill:F2})";
					finalizeButton.BackColor = Color.FromArgb(39, 174, 96);
				}
			}
		}

		private decimal CalculateRoomCost()
		{
			// TODO: wire up to your room price table
			return 0m;
		}

		// ══════════════════════════════════════════════════════════════════
		//  FOOD MENU BUTTON
		// ══════════════════════════════════════════════════════════════════
		private void foodMenuButton_Click(object sender, EventArgs e)
		{
			_serviceId = 0;
			_foodBill = 0m;
			_service = null;
			ResetFoodMenuButton();
			ResetPaymentButton();

			using (var foodForm = new Hotel.menufood())
			{
				if (foodForm.ShowDialog(this) == DialogResult.OK)
				{
					_serviceId = foodForm.ServiceId;
					_foodBill = foodForm.FoodBill;
					_service = foodForm.CreatedService;

					foodMenuButton.Text = $"Food Menu ✓ (${_foodBill})";
					foodMenuButton.BackColor = Color.FromArgb(39, 174, 96);
				}
			}
		}

		// ══════════════════════════════════════════════════════════════════
		//  SEARCH TAB  ← FIXED
		// ══════════════════════════════════════════════════════════════════
		private void searchButton_Click(object sender, EventArgs e)
		{
			string query = searchTextBox.Text.Trim();

			// Clear previous results
			searchDataGridView.DataSource = null;
			searchDataGridView.Visible = false;
			searchErrorLabel.Visible = false;

			if (string.IsNullOrEmpty(query))
			{
				searchErrorLabel.Text = "Please enter a name, phone number, or reservation ID to search.";
				searchErrorLabel.Visible = true;
				return;
			}

			// Search across first name, last name, phone number, and reservation ID
			var results = _context.Reservations
				.Where(r =>
					r.Customer.FirstName.Contains(query) ||
					r.Customer.LastName.Contains(query) ||
					r.Customer.PhoneNumber.Contains(query) ||
					r.Id.ToString() == query)
				.Select(r => new
				{
					ID = r.Id,
					FirstName = r.Customer.FirstName,
					LastName = r.Customer.LastName,
					Phone = r.Customer.PhoneNumber,
					RoomNumber = r.Room.RoomNumber,
					RoomType = r.Room.RoomType,
					Arrival = r.ArrivalTime,
					Departure = r.LeavingTime,
					CheckedIn = r.CheckIn ? "Yes" : "No",
					Guests = r.NumberGuest
				})
				.ToList();

			if (results.Count == 0)
			{
				searchErrorLabel.Text = $"No reservations found for \"{query}\".";
				searchErrorLabel.Visible = true;
				return;
			}

			searchDataGridView.DataSource = results;
			searchDataGridView.Visible = true;

			// Auto-size columns for readability
			searchDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}

		// Allow pressing Enter in the search box to trigger search
		private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				searchButton_Click(sender, e);
				e.Handled = true;          // mark the event as handled
				e.SuppressKeyPress = true; // prevent the ding sound on Enter
			}
		}

		// ══════════════════════════════════════════════════════════════════
		//  ADV. VIEW TAB
		// ══════════════════════════════════════════════════════════════════
		private void LoadAllReservationsGrid()
		{
			var all = _reservationManager.GetAllReservations();

			var table = all.Select(r => new
			{
				ID = r.Id,
				FirstName = r.Customer?.FirstName ?? "",
				LastName = r.Customer?.LastName ?? "",
				Phone = r.Customer?.PhoneNumber ?? "",
				Email = r.Customer?.EmailAddress ?? "",
				RoomNumber = r.Room?.RoomNumber,
				Floor = r.Room?.RoomFloor,
				RoomType = r.Room?.RoomType ?? "",
				Arrival = r.ArrivalTime.ToString("MM/dd/yyyy"),
				Departure = r.LeavingTime.ToString("MM/dd/yyyy"),
				CheckIn = r.CheckIn ? "Yes" : "No",
				Supply = r.SupplyStatus ? "Yes" : "No",
				Guests = r.NumberGuest
			}).ToList();

			resTotalDataGridView.DataSource = table;
		}

		// ══════════════════════════════════════════════════════════════════
		//  ROOM AVAILABILITY TAB
		//
		//  OCCUPIED  = CheckIn is true  → guest is physically in the room NOW
		//  RESERVED  = CheckIn is false, departure is in the future
		//              → room is booked but guest hasn't arrived yet
		// ══════════════════════════════════════════════════════════════════
		private void LoadRoomAvailability()
		{
			roomOccupiedListBox.Items.Clear();
			roomReservedListBox.Items.Clear();

			var occupied = _context.Reservations
				.Where(r => r.CheckIn)
				.Select(r => new
				{
					r.Room!.RoomNumber,
					RoomType = r.Room.RoomType,
					ResId = r.Id,
					Name = r.Customer!.FirstName + " " + r.Customer.LastName,
					Phone = r.Customer.PhoneNumber
				}).ToList();

			foreach (var o in occupied)
				roomOccupiedListBox.Items.Add(
					$"{o.RoomNumber,5}  {o.RoomType,-8}  #{o.ResId,-5}  {o.Name,-20}  {o.Phone}");

			var now = DateTime.Now;
			var reserved = _context.Reservations
				.Where(r => !r.CheckIn && r.LeavingTime > now)
				.Select(r => new
				{
					r.Room!.RoomNumber,
					RoomType = r.Room.RoomType,
					ResId = r.Id,
					Name = r.Customer!.FirstName + " " + r.Customer.LastName,
					Phone = r.Customer.PhoneNumber,
					Arrival = r.ArrivalTime,
					Departure = r.LeavingTime
				}).ToList();

			foreach (var rv in reserved)
				roomReservedListBox.Items.Add(
					$"{rv.RoomNumber,5}  {rv.RoomType,-8}  #{rv.ResId,-5}  {rv.Name,-20}  {rv.Phone,-14}" +
					$"  {rv.Arrival:MM/dd/yy}  →  {rv.Departure:MM/dd/yy}");
		}

		// ══════════════════════════════════════════════════════════════════
		//  HELPERS
		// ══════════════════════════════════════════════════════════════════
		private Customer BuildCustomerFromFields()
		{
			var address = new Address
			{
				StreetAddress = addressLabel.Text.Trim(),
				AptSuite = aptTextBox.Text.Trim(),
				City = cityTextBox.Text.Trim(),
				State = stateComboBox.SelectedItem?.ToString() ?? "",
				ZipCode = zipTextBox.Text.Trim()
			};

			return new Customer
			{
				FirstName = firstNameTextBox.Text.Trim(),
				LastName = lastNameTextBox.Text.Trim(),
				BirthDay = DateTime.Now,
				Gender = genderComboBox.SelectedItem?.ToString() ?? "",
				PhoneNumber = phoneNumberTextBox.Text.Trim(),
				EmailAddress = emailTextBox.Text.Trim(),
				Address = address
			};
		}

		private Room? GetOrCreateRoom()
		{
			if (!int.TryParse(floorComboBox.SelectedItem?.ToString(), out int floor)) return null;
			if (!int.TryParse(roomNComboBox.SelectedItem?.ToString(), out int roomNum)) return null;
			string roomType = roomTypeComboBox.SelectedItem?.ToString() ?? "Single";

			var room = _context.Rooms.FirstOrDefault(r =>
				r.RoomNumber == roomNum && r.RoomFloor == floor);

			if (room != null) return room;

			room = new Room
			{
				RoomNumber = roomNum,
				RoomFloor = floor,
				RoomType = roomType
			};
			_roomManager.AddRoom(room);
			return room;
		}

		private bool ValidateInputs()
		{
			if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
				string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				MessageBox.Show("First and Last name are required.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
			{
				MessageBox.Show("Phone number is required.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (qtGuestComboBox.SelectedIndex < 0)
			{
				MessageBox.Show("Please select number of guests.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (floorComboBox.SelectedIndex < 0 || roomNComboBox.SelectedIndex < 0)
			{
				MessageBox.Show("Please select floor and room number.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (depDatePicker.Value.Date <= entryDatePicker.Value.Date)
			{
				MessageBox.Show("Departure date must be after arrival date.", "Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void ClearAllFields()
		{
			firstNameTextBox.Text = "";
			lastNameTextBox.Text = "";
			monthComboBox.SelectedIndex = -1;
			dayComboBox.SelectedIndex = -1;
			yearTextBox.Text = "";
			genderComboBox.SelectedIndex = -1;
			phoneNumberTextBox.Text = "";
			emailTextBox.Text = "";
			addressLabel.Text = "";
			aptTextBox.Text = "";
			cityTextBox.Text = "";
			stateComboBox.SelectedIndex = -1;
			zipTextBox.Text = "";
			qtGuestComboBox.SelectedIndex = -1;
			roomTypeComboBox.SelectedIndex = -1;
			floorComboBox.SelectedIndex = -1;
			roomNComboBox.Items.Clear();
			entryDatePicker.Value = DateTime.Today;
			depDatePicker.Value = DateTime.Today.AddDays(1);
			checkinCheckBox.Checked = false;
			smsCheckBox.Checked = false;
			foodSupplyCheckBox.Checked = false;
		}

		private void ResetFoodMenuButton()
		{
			foodMenuButton.Text = "Food Menu";
			foodMenuButton.BackColor = Color.FromArgb(52, 152, 219);
		}

		private void ResetPaymentButton()
		{
			_paymentId = 0;
			_totalBill = 0f;
			_payment = null;
			finalizeButton.Text = "Payment";
			finalizeButton.BackColor = Color.FromArgb(52, 152, 219);
		}

		private void ResetForm()
		{
			_serviceId = 0;
			_foodBill = 0m;
			_service = null;
			_paymentId = 0;
			_totalBill = 0f;
			_payment = null;
			ResetFoodMenuButton();
			ResetPaymentButton();
			ClearAllFields();
		}

		private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentReservation != null && _isEditMode)
				_reservationManager.SetCheckIn(_currentReservation.Id, checkinCheckBox.Checked);
		}

		private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentReservation != null && _isEditMode)
				_reservationManager.SetSupplyStatus(_currentReservation.Id, foodSupplyCheckBox.Checked);
		}

		private void phoneNumberTextBox_Leave(object sender, EventArgs e) { }

		private void frontend_FormClosing(object sender, FormClosingEventArgs e)
		{
			_context.Dispose();
		}
	}
}
