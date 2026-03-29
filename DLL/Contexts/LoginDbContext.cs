using BLL.Entities.Manager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Contexts
{
	public class LoginDbContext : DbContext
	{
		public DbSet<FrontendUser> FrontendUsers { get; set; }
		public DbSet<KitchenUser> KitchenUsers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlServer("Server=.;Database=HotelLOGINTask;Trusted_Connection=True;Encrypt=false");
	}
}
