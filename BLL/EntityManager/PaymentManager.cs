using BLL.Entities;
using Dapper;
using DLL.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL.EntityManager
{
	public class PaymentManager
	{
		private readonly string _connectionString;

		public PaymentManager(string connectionString)
		{
			_connectionString = connectionString;
		}

		private IDbConnection CreateConnection() => new SqlConnection(_connectionString);
		public int AddPayment(Payment payment)
		{
			const string sql = @"
        INSERT INTO Payments (PaymentType, CardType, CardNumber, CardExp, CardCvc, TotalBill)
        OUTPUT INSERTED.Id
        VALUES (@PaymentType, @CardType, @CardNumber, @CardExp, @CardCvc, @TotalBill)";

			using var conn = CreateConnection();
			return conn.ExecuteScalar<int>(sql, payment);
		}

		public void UpdatePayment(Payment payment)
		{
			const string sql = @"
					UPDATE Payments
					SET PaymentType = @PaymentType,
						CardType    = @CardType,
						CardNumber  = @CardNumber,
						CardExp     = @CardExp,
						CardCvc     = @CardCvc,
						TotalBill   = @TotalBill
					WHERE Id = @Id";

			using var conn = CreateConnection();
			int rows = conn.Execute(sql, payment);

			if (rows == 0)
				throw new Exception($"Payment with id:{payment.Id} not found");
		}
		

		public Payment GetById(int id)
		{
			const string sql = "SELECT * FROM Payments WHERE Id = @Id";

			using var conn = CreateConnection();
			var payment = conn.QueryFirstOrDefault<Payment>(sql, new { Id = id });

			if (payment is null)
				throw new Exception($"Payment with id:{id} not found");

			return payment;
		}


		public void DeletePayment(int id)
		{
			const string sql = "DELETE FROM Payments WHERE Id = @Id";

			using var conn = CreateConnection();
			conn.Execute(sql, new { Id = id });
		}

		#region ef
		//private ReservationDbContext _context = new ReservationDbContext();
		//public int AddPayment(Payment payment)
		//{
		//	_context.Payments.Add(payment);
		//	_context.SaveChanges();
		//	return payment.Id;

		//}
		//public Payment GetById(int id)
		//{
		//	var p = _context.Payments.Find(id);
		//	if (p == null) throw new Exception($"Payment with id:{id} not found");

		//	return p;

		//}


		//public void UpdatePayment(Payment payment)
		//{

		//	_context.Entry(payment).State = EntityState.Modified;
		//	_context.SaveChanges();

		//}


		//public void DeletePayment(int id)
		//{
		//	var p = _context.Payments.Find(id);
		//	if (p != null)
		//	{
		//		_context.Payments.Remove(p);
		//		_context.SaveChanges();
		//	}

		//} 
		#endregion
	}
}
