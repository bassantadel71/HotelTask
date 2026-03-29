using BLL.Entities;
using DLL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.EntityManager
{
	public class ServiceManager
	{
		private ReservationDbContext _context = new ReservationDbContext();
		public int AddService(Service service)
		{
			
			_context.Services.Add(service);
			_context.SaveChanges();          
			return service.Id;
			
		}

		public Service GetById(int id)
		{
			 var s = _context.Services.Find(id);
			if (s is null) throw new Exception("there is no service with this id");

			return s;
			
		}

		public void UpdateService(Service service)
		{
			
			_context.Entry(service).State = EntityState.Modified;
			_context.SaveChanges();
			
		}

		public void DeleteService(int id)
		{
			
			var svc = _context.Services.Find(id);
			if (svc != null)
			{
				_context.Services.Remove(svc);
				_context.SaveChanges();
			}
			
		}
	}

}
