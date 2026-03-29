using BLL.Entities;
using DLL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.EntityManager
{
	public class RoomManager
	{
		private readonly ReservationDbContext _context;

		public RoomManager(ReservationDbContext context)
		{
			_context = context;
		}

		public Room AddRoom(Room room)
		{
			_context.Rooms.Add(room);
			_context.SaveChanges();
			return room;
		}

		public List<Room> GetAllRooms()
		{
			return _context.Rooms.ToList();
		}

		public Room? GetRoomById(int id)
		{
			return _context.Rooms.FirstOrDefault(r => r.Id == id);
		}

		public Room? GetRoomByNumber(int roomNumber)
		{
			return _context.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
		}

		
		public List<Room> GetRoomsByFloor(int floor)
		{
			return _context.Rooms
				.Where(r => r.RoomFloor == floor)
				.ToList();
		}

		
		public List<Room> GetAvailableRooms(DateTime arrival, DateTime departure)
		{
			var reservedRoomIds = _context.Reservations
				.Where(res =>
					res.ArrivalTime < departure &&
					res.LeavingTime > arrival)
				.Select(res => res.RoomId)
				.ToList();

			return _context.Rooms
				.Where(r => !reservedRoomIds.Contains(r.Id))
				.ToList();
		}

		public List<Room> GetOccupiedRooms()
		{
			var occupiedRoomIds = _context.Reservations
				.Where(res => res.CheckIn == true)
				.Select(res => res.RoomId)
				.ToList();

			return _context.Rooms
				.Where(r => occupiedRoomIds.Contains(r.Id))
				.ToList();
		}

		public List<Room> GetReservedRooms()
		{
			var now = DateTime.Now;
			var reservedRoomIds = _context.Reservations
				.Where(res => res.CheckIn == false && res.LeavingTime > now)
				.Select(res => res.RoomId)
				.ToList();

			return _context.Rooms
				.Where(r => reservedRoomIds.Contains(r.Id))
				.ToList();
		}

		public bool UpdateRoom(Room room)
		{
			var existing = _context.Rooms.FirstOrDefault(r => r.Id == room.Id);
			if (existing == null) return false;

			existing.RoomType = room.RoomType;
			existing.RoomFloor = room.RoomFloor;
			existing.RoomNumber = room.RoomNumber;

			_context.SaveChanges();
			return true;
		}

		public bool DeleteRoom(int id)
		{
			var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
			if (room == null) return false;

			_context.Rooms.Remove(room);
			_context.SaveChanges();
			return true;
		}
	}
}
