using BLL.Entities;
using DLL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


using System.Linq;

namespace BLL.EntityManager
{
	public class ReservationManager
	{
		private readonly ReservationDbContext _context;

		public ReservationManager(ReservationDbContext context)
		{
			_context = context;
		}

		public Reservation AddReservation(Reservation reservation)
		{
			_context.Reservations.Add(reservation);
			_context.SaveChanges();
			return reservation;
		}

		public List<Reservation> GetAllReservations()
		{
			return _context.Reservations
				.Include(r => r.Customer)
				.Include(r => r.Room)
				.Include(r => r.Payment)
				.Include(r => r.Service)
				.ToList();
		}

		public Reservation? GetReservationById(int id)
		{
			return _context.Reservations
				.Include(r => r.Customer)
					.ThenInclude(c => c!.Address)
				.Include(r => r.Room)
				.Include(r => r.Payment)
				.Include(r => r.Service)
				.FirstOrDefault(r => r.Id == id);
		}

		public List<Reservation> GetReservationsByCustomer(int customerId)
		{
			return _context.Reservations
				.Include(r => r.Customer)
				.Include(r => r.Room)
				.Include(r => r.Payment)
				.Include(r => r.Service)
				.Where(r => r.CustomerId == customerId)
				.ToList();
		}

		public List<Reservation> SearchReservations(string query)
		{
			query = query.ToLower();
			return _context.Reservations
				.Include(r => r.Customer)
				.Include(r => r.Room)
				.Include(r => r.Payment)
				.Include(r => r.Service)
				.Where(r =>
					r.Customer!.FirstName.ToLower().Contains(query) ||
					r.Customer!.LastName.ToLower().Contains(query) ||
					r.Customer!.PhoneNumber.Contains(query) ||
					r.Id.ToString().Contains(query))
				.ToList();
		}

		public List<string> GetReservationDisplayList()
		{
			return _context.Reservations
				.Include(r => r.Customer)
				.Select(r => $"[{r.Id}]  {r.Customer!.FirstName} {r.Customer.LastName}  |  {r.Customer.PhoneNumber}")
				.ToList();
		}

		public int ExtractIdFromDisplay(string displayText)
		{
			if (string.IsNullOrEmpty(displayText)) return -1;
			var start = displayText.IndexOf('[') + 1;
			var end = displayText.IndexOf(']');
			if (start < 1 || end < 0) return -1;
			return int.TryParse(displayText.Substring(start, end - start), out int id) ? id : -1;
		}

		public bool UpdateReservation(Reservation updated)
		{
			var existing = _context.Reservations
				.Include(r => r.Customer)
					.ThenInclude(c => c!.Address)
				.Include(r => r.Room)
				.FirstOrDefault(r => r.Id == updated.Id);

			if (existing == null) return false;

			existing.NumberGuest = updated.NumberGuest;
			existing.ArrivalTime = updated.ArrivalTime;
			existing.LeavingTime = updated.LeavingTime;
			existing.CheckIn = updated.CheckIn;
			existing.SupplyStatus = updated.SupplyStatus;
			existing.RoomId = updated.RoomId;

			if (updated.Customer != null && existing.Customer != null)
			{
				existing.Customer.FirstName = updated.Customer.FirstName;
				existing.Customer.LastName = updated.Customer.LastName;
				existing.Customer.BirthDay = updated.Customer.BirthDay;
				existing.Customer.Gender = updated.Customer.Gender;
				existing.Customer.PhoneNumber = updated.Customer.PhoneNumber;
				existing.Customer.EmailAddress = updated.Customer.EmailAddress;

				if (updated.Customer.Address != null && existing.Customer.Address != null)
				{
					existing.Customer.Address.StreetAddress = updated.Customer.Address.StreetAddress;
					existing.Customer.Address.AptSuite = updated.Customer.Address.AptSuite;
					existing.Customer.Address.City = updated.Customer.Address.City;
					existing.Customer.Address.State = updated.Customer.Address.State;
					existing.Customer.Address.ZipCode = updated.Customer.Address.ZipCode;
				}
			}

			_context.SaveChanges();
			return true;
		}

		public bool SetCheckIn(int reservationId, bool checkIn)
		{
			var res = _context.Reservations.FirstOrDefault(r => r.Id == reservationId);
			if (res == null) return false;
			res.CheckIn = checkIn;
			_context.SaveChanges();
			return true;
		}

		public bool SetSupplyStatus(int reservationId, bool supplyStatus)
		{
			var res = _context.Reservations.FirstOrDefault(r => r.Id == reservationId);
			if (res == null) return false;
			res.SupplyStatus = supplyStatus;
			_context.SaveChanges();
			return true;
		}

		public bool DeleteReservation(int id)
		{
			var reservation = _context.Reservations.Find(id);
			if (reservation == null) return false;

			_context.Entry(reservation).Reference(r => r.Service).Load();
			_context.Entry(reservation).Reference(r => r.Payment).Load();

			if (reservation.Service != null)
				_context.Services.Remove(reservation.Service);

			if (reservation.Payment != null)
				_context.Payments.Remove(reservation.Payment);

			_context.Reservations.Remove(reservation);
			_context.SaveChanges();
			return true;
		}

		public float CalculateTotalBill(int reservationId)
		{
			var res = _context.Reservations
				.Include(r => r.Room)
				.Include(r => r.Service)
				.FirstOrDefault(r => r.Id == reservationId);

			if (res == null) return 0f;

			float nightlyRate = res.Room?.RoomType switch
			{
				"Single" => 80f,
				"Double" => 120f,
				"Twin" => 110f,
				"Duplex" => 200f,
				"Suite" => 350f,
				_ => 100f
			};

			int nights = Math.Max(1, (res.LeavingTime - res.ArrivalTime).Days);
			float roomCost = nightlyRate * nights;
			float foodCost = (float)(res.Service?.FoodBill ?? 0m);

			return roomCost + foodCost;
		}

		public bool SavePayment(int reservationId, Payment payment)
		{
			var res = _context.Reservations.FirstOrDefault(r => r.Id == reservationId);
			if (res == null) return false;

			payment.TotalBill = CalculateTotalBill(reservationId);
			_context.Payments.Add(payment);
			_context.SaveChanges();

			res.PaymentId = payment.Id;
			_context.SaveChanges();
			return true;
		}
	}
}


//public class ReservationManager
//{
//	ReservationDbContext _context { get; set; }
//	public List<Reservation> GetAllReservations()
//	{
//		try
//		{
//			return _context.Reservations
//				.Include(r => r.Customer)
//				.Include(r => r.Room)
//				.Include(r => r.Payment)
//				.Include(r => r.Service)
//				//.Include(r => r.Address)
//				.ToList();
//		}
//		catch (Exception ex)
//		{
//			throw new Exception("Failed to retrieve reservations: " + ex.Message);
//		}
//	}

//	public void AddReservation(Reservation reservation)
//	{
//		try
//		{
//			if (reservation == null)
//				throw new ArgumentNullException("Reservation cannot be null.");

//			_context.Reservations.Add(reservation);
//			_context.SaveChanges();
//		}
//		catch (DbUpdateException ex)
//		{
//			throw new Exception("DB error while adding reservation: " + ex.InnerException?.Message);
//		}
//		catch (Exception ex)
//		{
//			throw new Exception("Failed to add reservation: " + ex.Message);
//		}
//	}

//	public void UpdateReservation(Reservation reservation)
//	{
//		try
//		{
//			if (reservation == null)
//				throw new ArgumentNullException("Reservation cannot be null.");

//			_context.Reservations.Update(reservation);
//			_context.SaveChanges();
//		}
//		catch (DbUpdateConcurrencyException ex)
//		{
//			throw new Exception("Concurrency error while updating reservation: " + ex.Message);
//		}
//		catch (DbUpdateException ex)
//		{
//			throw new Exception("DB error while updating reservation: " + ex.InnerException?.Message);
//		}
//		catch (Exception ex)
//		{
//			throw new Exception("Failed to update reservation: " + ex.Message);
//		}
//	}

//	public void DeleteReservation(int id)
//	{
//		try
//		{
//			var res = _context.Reservations.Find(id);
//			if (res == null)
//				throw new Exception($"Reservation with ID {id} not found.");

//			_context.Reservations.Remove(res);
//			_context.SaveChanges();
//		}
//		catch (DbUpdateException ex)
//		{
//			throw new Exception("DB error while deleting reservation: " + ex.InnerException?.Message);
//		}
//		catch (Exception ex)
//		{
//			throw new Exception("Failed to delete reservation: " + ex.Message);
//		}
//	}
//}

