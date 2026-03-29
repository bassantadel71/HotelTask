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
	public class ServiceManager
	{
		private readonly string _connectionString;

		public ServiceManager(string connectionString)
		{
			_connectionString = connectionString;
		}

		private IDbConnection CreateConnection() => new SqlConnection(_connectionString);
		public int AddService(Service service)
		{
			const string sql = @"
        INSERT INTO Services (BreakFast, Lunch, Dinner, Cleaning, Towel, SSurprise, FoodBill)
        OUTPUT INSERTED.Id
        VALUES (@BreakFast, @Lunch, @Dinner, @Cleaning, @Towel, @SSurprise, @FoodBill)";

			using var conn = CreateConnection();
			return conn.ExecuteScalar<int>(sql, service);
		}

		public void UpdateService(Service service)
		{
			const string sql = @"
				UPDATE Services
				SET BreakFast  = @BreakFast,
					Lunch      = @Lunch,
					Dinner     = @Dinner,
					Cleaning   = @Cleaning,
					Towel      = @Towel,
					SSurprise  = @SSurprise,
					FoodBill   = @FoodBill
				WHERE Id = @Id";

			using var conn = CreateConnection();
			int rows = conn.Execute(sql, service);

			if (rows == 0)
				throw new Exception($"Service with id:{service.Id} not found");
		}
		
		public Service GetById(int id)
		{
			const string sql = "SELECT * FROM Services WHERE Id = @Id";

			using var conn = CreateConnection();
			var service = conn.QueryFirstOrDefault<Service>(sql, new { Id = id });

			if (service is null)
				throw new Exception("There is no service with this id");

			return service;
		}

		

		public void DeleteService(int id)
		{
			const string sql = "DELETE FROM Services WHERE Id = @Id";

			using var conn = CreateConnection();
			conn.Execute(sql, new { Id = id });
		}
	}

}
