using BLL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Contexts
{
	public class ReservationDbContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// one to many el c mmkn yehgz kza mara w el r l c 1
			modelBuilder.Entity<Reservation>()
						.HasOne(r => r.Customer)
						.WithMany(c => c.Reservations)
						.HasForeignKey(r => r.CustomerId);

			// one to one
			modelBuilder.Entity<Reservation>()
						.HasOne(r => r.Payment)
						.WithOne()
						.HasForeignKey<Reservation>(r => r.PaymentId);

			// one to many
			modelBuilder.Entity<Reservation>()
						.HasOne(r => r.Room)
						.WithMany(rm => rm.Reservations)
						.HasForeignKey(r => r.RoomId);

			// one to many
			modelBuilder.Entity<Reservation>()
						.HasOne(r => r.Service)
						.WithMany(s=>s.Reservations)
						.HasForeignKey(r => r.ServiceId);

			//// one to one
			//modelBuilder.Entity<Reservation>()
			//			.HasOne(r => r.Address)
			//			.WithOne()
			//			.HasForeignKey<Reservation>(r => r.AddressId);

			// Customer -> Address (one-to-one)
			modelBuilder.Entity<Customer>()
				.HasOne(c => c.Address)
				.WithOne(a => a.Customer)
				.HasForeignKey<Address>(a => a.CustomerId);



		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlServer("Server=.;Database=HotelRESERVATIONTask;Trusted_Connection=True;Encrypt=false");
	}
}
