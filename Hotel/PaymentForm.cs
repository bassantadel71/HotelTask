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
	public partial class PaymentForm : Form
	{
		public Payment CreatedPayment { get; private set; }

		public int PaymentId { get; private set; }

		public float TotalBill { get; private set; }

		private readonly decimal _roomCost;
		private readonly decimal _foodBill;
		private readonly ReservationDbContext _context;

		public PaymentForm(decimal roomCost, decimal foodBill)
		{
			_context = new ReservationDbContext();
			InitializeComponent();
			_roomCost = roomCost;
			_foodBill = foodBill;
			LoadBillSummary();
		}

		private void LoadBillSummary()
		{
			decimal total = _roomCost + _foodBill;
			lblRoomCostVal.Text = $"${_roomCost:F2}";
			lblFoodBillVal.Text = $"${_foodBill:F2}";
			lblTotalVal.Text = $"${total:F2}";
			TotalBill = (float)total;
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (cmbPaymentType.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a payment type (Debit Card or Credit Card).",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtCardNumber.Text))
			{
				MessageBox.Show("Please enter the card number.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtCardExp.Text))
			{
				MessageBox.Show("Please enter the card expiry date (MM/YY).",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtCardCvc.Text))
			{
				MessageBox.Show("Please enter the CVC.",
					"Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string paymentType = cmbPaymentType.SelectedItem.ToString();
			string cardNumber = txtCardNumber.Text.Trim();

			string maskedCard = cardNumber.Length >= 4
				? "**** **** **** " + cardNumber[^4..]
				: cardNumber;

			string summary =
				$"Payment Type : {paymentType}\n" +
				$"Card Number  : {maskedCard}\n" +
				$"Expiry       : {txtCardExp.Text.Trim()}\n" +
				$"\nTotal Bill   : ${TotalBill:F2}\n\nConfirm payment?";

			if (MessageBox.Show(summary, "Confirm Payment",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			var payment = new Payment
			{
				PaymentType = paymentType,
				CardType = paymentType,        
				CardNumber = cardNumber,
				CardExp = txtCardExp.Text.Trim(),
				CardCvc = txtCardCvc.Text.Trim(),
				TotalBill = TotalBill
			};

			
			try
			{
				var manager = new PaymentManager(_context.Database.GetConnectionString());
				int newId = manager.AddPayment(payment);

				CreatedPayment = payment;
				PaymentId = newId;

				MessageBox.Show(
					$"Payment saved! (ID: {newId})\nTotal: ${TotalBill:F2}\n\nYou can now click Submit to finalize the reservation.",
					"Payment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error saving payment:\n{ex.Message}",
					"Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
