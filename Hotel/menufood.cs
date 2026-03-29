using BLL.Entities;
using BLL.EntityManager;
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
	public partial class menufood : Form
	{
		private readonly ReservationDbContext _context;

		public Service CreatedService { get; private set; }

		public int ServiceId { get; private set; }

		public decimal FoodBill { get; private set; }

		public menufood()
		{
			_context = new ReservationDbContext();
			InitializeComponent();
		}
	
		private void ChkBreakfast_CheckedChanged(object sender, EventArgs e)
		{
			numBreakfastQty.Enabled = chkBreakfast.Checked;
			if (!chkBreakfast.Checked) numBreakfastQty.Value = 1;
		}

		private void ChkLunch_CheckedChanged(object sender, EventArgs e)
		{
			numLunchQty.Enabled = chkLunch.Checked;
			if (!chkLunch.Checked) numLunchQty.Value = 1;
		}

		private void ChkDinner_CheckedChanged(object sender, EventArgs e)
		{
			numDinnerQty.Enabled = chkDinner.Checked;
			if (!chkDinner.Checked) numDinnerQty.Value = 1;
		}

		
		private void BtnNext_Click(object sender, EventArgs e)
		{
			
			if (!chkBreakfast.Checked && !chkLunch.Checked && !chkDinner.Checked)
			{
				MessageBox.Show("Please select at least one meal.", "Selection Required",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

		
			int breakfastQty = chkBreakfast.Checked ? (int)numBreakfastQty.Value : 0;
			int lunchQty = chkLunch.Checked ? (int)numLunchQty.Value : 0;
			int dinnerQty = chkDinner.Checked ? (int)numDinnerQty.Value : 0;

			
			decimal total = (breakfastQty * 7m) + (lunchQty * 15m) + (dinnerQty * 15m);

			
			string summary = "===== ORDER SUMMARY =====\n\nFood Items:\n";
			if (breakfastQty > 0) summary += $"  • Breakfast: {breakfastQty} x $7  = ${breakfastQty * 7m}\n";
			if (lunchQty > 0) summary += $"  • Lunch:     {lunchQty} x $15 = ${lunchQty * 15m}\n";
			if (dinnerQty > 0) summary += $"  • Dinner:    {dinnerQty} x $15 = ${dinnerQty * 15m}\n";
			summary += $"\nFood Subtotal: ${total}\n";

			summary += "\nSpecial Needs:\n";
			if (chkCleaning.Checked) summary += "  • Cleaning\n";
			if (chkTowels.Checked) summary += "  • Towels\n";
			if (chkSweetestSurprise.Checked) summary += "  • Sweetest Surprise\n";
			if (!chkCleaning.Checked && !chkTowels.Checked && !chkSweetestSurprise.Checked)
				summary += "  • None\n";

			summary += $"\n\nTotal Food Bill: ${total}\n\nProceed and save service?";

			DialogResult confirm = MessageBox.Show(summary, "Confirm Order",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (confirm != DialogResult.Yes)
				return;

			var service = new Service
			{
				BreakFast = breakfastQty,
				Lunch = lunchQty,
				Dinner = dinnerQty,
				Cleaning = chkCleaning.Checked,
				Towel = chkTowels.Checked,
				SSurprise = chkSweetestSurprise.Checked,
				FoodBill = (int)total         
			};

			
			try
			{
				var manager = new ServiceManager(_context.Database.GetConnectionString());
				int newId = manager.AddService(service);   

				
				CreatedService = service;
				ServiceId = newId;
				FoodBill = total;

				MessageBox.Show($"Service saved! (ID: {newId})\nFood Bill: ${total}",
					"Service Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving service:\n{ex.Message}", "Database Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
