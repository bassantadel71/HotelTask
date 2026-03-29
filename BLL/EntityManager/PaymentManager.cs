using BLL.Entities;
using DLL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.EntityManager
{
	public class PaymentManager
	{
		private ReservationDbContext _context = new ReservationDbContext();
		public int AddPayment(Payment payment)
		{
			_context.Payments.Add(payment);
			_context.SaveChanges();       
			return payment.Id;
			
		}
		public Payment GetById(int id)
		{
			var p = _context.Payments.Find(id);
			if (p == null) throw new Exception($"Payment with id:{id} not found");

			return p;
			
		}

		
		public void UpdatePayment(Payment payment)
		{
			
			_context.Entry(payment).State = EntityState.Modified;
			_context.SaveChanges();
			
		}

		
		public void DeletePayment(int id)
		{
			var p = _context.Payments.Find(id);
			if (p != null)
			{
				_context.Payments.Remove(p);
				_context.SaveChanges();
			}
			
		}
	}
}
