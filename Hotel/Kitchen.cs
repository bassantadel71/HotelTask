using BLL.Entities;
using DLL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Hotel
{
	public partial class Kitchen : Form
	{
	
		private readonly ReservationDbContext _context;

		private Reservation? _selectedReservation;

		private const string KitchenUsername = "kitchen";
		private const string KitchenPassword = "1234";

		public Kitchen()
		{
			InitializeComponent();

			_context = new ReservationDbContext();

			queueListBox.SelectedIndexChanged += QueueListBox_SelectedIndexChanged;
			foodSelectionButton.Click += FoodSelectionButton_Click;
			updateButton.Click += UpdateButton_Click;
			this.Load += Kitchen_Load;
		}

		private void Kitchen_Load(object sender, EventArgs e)
		{

			_context.Database.EnsureCreated();
			LoadQueue();
			LoadOverview();
			ClearDetails();
		}

		
		private void LoadQueue()
		{
			queueListBox.Items.Clear();

			var orders = _context.Reservations
				.Include(r=>r.Customer)
				.Where(r=>r.Customer !=null)
				.Include(r => r.Room)
				.Include(r => r.Service)
				.Where(r => r.SupplyStatus && r.Service != null)
				.OrderBy(r => r.ArrivalTime)
				.ToList();

			foreach (var r in orders)
			{
				string name = $"{r.Customer?.FirstName} {r.Customer?.LastName}";
				string room = $"Room {r.Room?.RoomNumber} (Floor {r.Room?.RoomFloor})";
				string meals = BuildMealSummary(r.Service!);
				queueListBox.Items.Add($"[#{r.Id}]  {name}  —  {room}  |  {meals}");
			}

			queueListBox.Tag = orders;
		}

		private void QueueListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (queueListBox.SelectedIndex < 0) return;

			var orders = queueListBox.Tag as System.Collections.Generic.List<Reservation>;
			if (orders == null || queueListBox.SelectedIndex >= orders.Count) return;

			_selectedReservation = orders[queueListBox.SelectedIndex];
			PopulateDetails(_selectedReservation);
		}

		private void PopulateDetails(Reservation res)
		{
			firstNameTextBox.Text = res.Customer?.FirstName ?? "";
			lastNameTextBox.Text = res.Customer?.LastName ?? "";
			phoneNTextBox.Text = res.Customer?.PhoneNumber ?? "";
			roomTypeTextBox.Text = res.Room?.RoomType ?? "";
			floorNTextBox.Text = res.Room?.RoomFloor.ToString() ?? "";
			roomNTextBox.Text = res.Room?.RoomNumber.ToString() ?? "";

	
			var svc = res.Service;
			if (svc != null)
			{
				breakfastTextBox.Text = svc.BreakFast > 0 ? svc.BreakFast.ToString() : "";
				lunchTextBox.Text = svc.Lunch > 0 ? svc.Lunch.ToString() : "";
				dinnerTextBox.Text = svc.Dinner > 0 ? svc.Dinner.ToString() : "";
				cleaningCheckBox.Checked = svc.Cleaning;
				towelCheckBox.Checked = svc.Towel;
				supplyCheckBox.Checked = svc.SSurprise; 
				surpriseCheckBox.Checked = svc.SSurprise;
			}
			else
			{
				ClearDetails();
			}
		}

		private void ClearDetails()
		{
			firstNameTextBox.Text = "";
			lastNameTextBox.Text = "";
			phoneNTextBox.Text = "";
			roomTypeTextBox.Text = "";
			floorNTextBox.Text = "";
			roomNTextBox.Text = "";
			breakfastTextBox.Text = "";
			lunchTextBox.Text = "";
			dinnerTextBox.Text = "";
			cleaningCheckBox.Checked = false;
			towelCheckBox.Checked = false;
			supplyCheckBox.Checked = false;
			surpriseCheckBox.Checked = false;
			_selectedReservation = null;
		}

		
		private void FoodSelectionButton_Click(object sender, EventArgs e)
		{
			if (_selectedReservation == null)
			{
				MessageBox.Show("Please select an order from the queue first.",
					"No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using var foodForm = new menufood();
			foodForm.ShowDialog(this);

			
			LoadQueue();
			LoadOverview();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			if (_selectedReservation == null)
			{
				MessageBox.Show("Please select an order from the queue first.",
					"No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var confirm = MessageBox.Show(
				$"Mark order for {firstNameTextBox.Text} {lastNameTextBox.Text} " +
				$"(Room {roomNTextBox.Text}) as fulfilled and remove from queue?",
				"Confirm Fulfillment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (confirm != DialogResult.Yes) return;

			try
			{
				var res = _context.Reservations.Find(_selectedReservation.Id);
				if (res != null)
				{
					res.SupplyStatus = false;
					_context.SaveChanges();
				}

				MessageBox.Show("Order marked as fulfilled!", "Done",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

				ClearDetails();
				LoadQueue();
				LoadOverview();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating order:\n{ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadOverview()
		{
			var all = _context.Reservations
				.Include(r => r.Customer)
				.Include(r => r.Room)
				.Include(r => r.Service)
				.Where(r => r.Service != null)
				.OrderByDescending(r => r.Id)
				.ToList();

			var table = all.Select(r => new
			{
				ID = r.Id,
				FirstName = r.Customer?.FirstName ?? "",
				LastName = r.Customer?.LastName ?? "",
				Phone = r.Customer?.PhoneNumber ?? "",
				Room = r.Room?.RoomNumber,
				Floor = r.Room?.RoomFloor,
				RoomType = r.Room?.RoomType ?? "",
				Breakfast = r.Service?.BreakFast ?? 0,
				Lunch = r.Service?.Lunch ?? 0,
				Dinner = r.Service?.Dinner ?? 0,
				Cleaning = r.Service?.Cleaning == true ? "Yes" : "No",
				Towel = r.Service?.Towel == true ? "Yes" : "No",
				Surprise = r.Service?.SSurprise == true ? "Yes" : "No",
				FoodBill = $"${r.Service?.FoodBill ?? 0}",
				Status = r.SupplyStatus ? "⏳ Pending" : "✅ Fulfilled"
			}).ToList();

			overviewDataGridView.DataSource = table;
			overviewDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}

		private string BuildMealSummary(Service svc)
		{
			var parts = new System.Collections.Generic.List<string>();
			if (svc.BreakFast > 0) parts.Add($"B×{svc.BreakFast}");
			if (svc.Lunch > 0) parts.Add($"L×{svc.Lunch}");
			if (svc.Dinner > 0) parts.Add($"D×{svc.Dinner}");
			if (svc.Cleaning) parts.Add("Cleaning");
			if (svc.Towel) parts.Add("Towel");
			if (svc.SSurprise) parts.Add("Surprise");
			return parts.Count > 0 ? string.Join(", ", parts) : "No items";
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			_context.Dispose();
			base.OnFormClosed(e);
		}
	}
}
