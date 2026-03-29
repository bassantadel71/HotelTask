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
	public class RoomManager
	{
		private readonly string _connectionString;

		public RoomManager(string connectionString)
		{
			_connectionString = connectionString;
		}

		private IDbConnection CreateConnection() => new SqlConnection(_connectionString);

		private readonly ReservationDbContext _context;

		public RoomManager(ReservationDbContext context)
		{
			_context = context;
		}

		public Room AddRoom(Room room)
		{
			const string sql = @"
                INSERT INTO Rooms (RoomNumber, RoomFloor, RoomType)
                OUTPUT INSERTED.Id
                VALUES (@RoomNumber, @RoomFloor, @RoomType)";

			using var conn = CreateConnection();
			room.Id = conn.ExecuteScalar<int>(sql, room);
			return room;
		}
		public List<Room> GetAllRooms()
		{
			const string sql = "SELECT * FROM Rooms";

			using var conn = CreateConnection();
			return conn.Query<Room>(sql).AsList();
		}

		public Room? GetRoomById(int id)
		{
			const string sql = "SELECT * FROM Rooms WHERE Id = @Id";

			using var conn = CreateConnection();
			return conn.QueryFirstOrDefault<Room>(sql, new { Id = id });
		}

		public Room? GetRoomByNumber(int roomNumber)
		{
			const string sql = "SELECT * FROM Rooms WHERE RoomNumber = @RoomNumber";

			using var conn = CreateConnection();
			return conn.QueryFirstOrDefault<Room>(sql, new { RoomNumber = roomNumber });
		}

		public List<Room> GetRoomsByFloor(int floor)
		{
			const string sql = "SELECT * FROM Rooms WHERE RoomFloor = @Floor";

			using var conn = CreateConnection();
			return conn.Query<Room>(sql, new { Floor = floor }).AsList();
		}

		public List<Room> GetAvailableRooms(DateTime arrival, DateTime departure)
		{
			const string sql = @"
                SELECT * FROM Rooms
                WHERE Id NOT IN (
                    SELECT RoomId FROM Reservations
                    WHERE ArrivalTime < @Departure
                      AND LeavingTime > @Arrival
                )";

			using var conn = CreateConnection();
			return conn.Query<Room>(sql, new { Arrival = arrival, Departure = departure }).AsList();
		}

		public List<Room> GetOccupiedRooms()
		{
			const string sql = @"
                SELECT * FROM Rooms
                WHERE Id IN (
                    SELECT RoomId FROM Reservations
                    WHERE CheckIn = 1
                )";

			using var conn = CreateConnection();
			return conn.Query<Room>(sql).AsList();
		}

		public List<Room> GetReservedRooms()
		{
			const string sql = @"
                SELECT * FROM Rooms
                WHERE Id IN (
                    SELECT RoomId FROM Reservations
                    WHERE CheckIn = 0
                      AND LeavingTime > @Now
                )";

			using var conn = CreateConnection();
			return conn.Query<Room>(sql, new { Now = DateTime.Now }).AsList();
		}

		public bool UpdateRoom(Room room)
		{
			const string sql = @"
                UPDATE Rooms
                SET RoomType   = @RoomType,
                    RoomFloor  = @RoomFloor,
                    RoomNumber = @RoomNumber
                WHERE Id = @Id";

			using var conn = CreateConnection();
			return conn.Execute(sql, room) > 0;
		}

		public bool DeleteRoom(int id)
		{
			const string sql = "DELETE FROM Rooms WHERE Id = @Id";

			using var conn = CreateConnection();
			return conn.Execute(sql, new { Id = id }) > 0;
		}

		#region ef core
		//public Room AddRoom(Room room)
		//{
		//	_context.Rooms.Add(room);
		//	_context.SaveChanges();
		//	return room;
		//}

		//public List<Room> GetAllRooms()
		//{
		//	return _context.Rooms.ToList();
		//}

		//public Room? GetRoomById(int id)
		//{
		//	return _context.Rooms.FirstOrDefault(r => r.Id == id);
		//}

		//public Room? GetRoomByNumber(int roomNumber)
		//{
		//	return _context.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
		//}


		//public List<Room> GetRoomsByFloor(int floor)
		//{
		//	return _context.Rooms
		//		.Where(r => r.RoomFloor == floor)
		//		.ToList();
		//}


		//public List<Room> GetAvailableRooms(DateTime arrival, DateTime departure)
		//{
		//	var reservedRoomIds = _context.Reservations
		//		.Where(res =>
		//			res.ArrivalTime < departure &&
		//			res.LeavingTime > arrival)
		//		.Select(res => res.RoomId)
		//		.ToList();

		//	return _context.Rooms
		//		.Where(r => !reservedRoomIds.Contains(r.Id))
		//		.ToList();
		//}

		//public List<Room> GetOccupiedRooms()
		//{
		//	var occupiedRoomIds = _context.Reservations
		//		.Where(res => res.CheckIn == true)
		//		.Select(res => res.RoomId)
		//		.ToList();

		//	return _context.Rooms
		//		.Where(r => occupiedRoomIds.Contains(r.Id))
		//		.ToList();
		//}

		//public List<Room> GetReservedRooms()
		//{
		//	var now = DateTime.Now;
		//	var reservedRoomIds = _context.Reservations
		//		.Where(res => res.CheckIn == false && res.LeavingTime > now)
		//		.Select(res => res.RoomId)
		//		.ToList();

		//	return _context.Rooms
		//		.Where(r => reservedRoomIds.Contains(r.Id))
		//		.ToList();
		//}

		//public bool UpdateRoom(Room room)
		//{
		//	var existing = _context.Rooms.FirstOrDefault(r => r.Id == room.Id);
		//	if (existing == null) return false;

		//	existing.RoomType = room.RoomType;
		//	existing.RoomFloor = room.RoomFloor;
		//	existing.RoomNumber = room.RoomNumber;

		//	_context.SaveChanges();
		//	return true;
		//}

		//public bool DeleteRoom(int id)
		//{
		//	var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
		//	if (room == null) return false;

		//	_context.Rooms.Remove(room);
		//	_context.SaveChanges();
		//	return true;
		//}
		#endregion
	}
}
