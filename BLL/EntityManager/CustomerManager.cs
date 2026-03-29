using BLL.Entities;
using DLL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.EntityManager
{
	public class CustomerManager
		{
			private readonly ReservationDbContext _context;

			public CustomerManager(ReservationDbContext context)
			{
				_context = context;
			}

			public Customer AddCustomer(Customer customer)
			{
				_context.Customers.Add(customer);
				_context.SaveChanges();
				return customer;
			}

			
			public List<Customer> GetAllCustomers()
			{
				return _context.Customers
					.Include(c => c.Address)
					.ToList();
			}

			
			public Customer? GetCustomerById(int id)
			{
				return _context.Customers
					.Include(c => c.Address)
					.FirstOrDefault(c => c.Id == id);
			}

			
			public Customer? GetCustomerByPhone(string phone)
			{
				return _context.Customers
					.Include(c => c.Address)
					.FirstOrDefault(c => c.PhoneNumber == phone);
			}

			
			public List<Customer> SearchCustomers(string query)
			{
				query = query.ToLower();
				return _context.Customers
					.Include(c => c.Address)
					.Where(c =>
						c.FirstName.ToLower().Contains(query) ||
						c.LastName.ToLower().Contains(query) ||
						c.PhoneNumber.Contains(query) ||
						c.EmailAddress.ToLower().Contains(query))
					.ToList();
			}

			public bool UpdateCustomer(Customer customer)
			{
				var existing = _context.Customers
					.Include(c => c.Address)
					.FirstOrDefault(c => c.Id == customer.Id);

				if (existing == null) return false;

				existing.FirstName = customer.FirstName;
				existing.LastName = customer.LastName;
				existing.BirthDay = customer.BirthDay;
				existing.Gender = customer.Gender;
				existing.PhoneNumber = customer.PhoneNumber;
				existing.EmailAddress = customer.EmailAddress;

				if (customer.Address != null)
				{
					if (existing.Address == null)
						existing.Address = customer.Address;
					else
					{
						existing.Address.StreetAddress = customer.Address.StreetAddress;
						existing.Address.AptSuite = customer.Address.AptSuite;
						existing.Address.City = customer.Address.City;
						existing.Address.State = customer.Address.State;
						existing.Address.ZipCode = customer.Address.ZipCode;
					}
				}

				_context.SaveChanges();
				return true;
			}

			public bool DeleteCustomer(int id)
			{
				var customer = _context.Customers
					.Include(c => c.Address)
					.FirstOrDefault(c => c.Id == id);

				if (customer == null) return false;

				if (customer.Address != null)
					_context.Addresses.Remove(customer.Address);

				_context.Customers.Remove(customer);
				_context.SaveChanges();
				return true;
			}
		}
	}

	//public class CustomerManager
	//{
	//	ReservationDbContext _context = new ReservationDbContext();
	//	public CustomerManager() { }

	//	public List<Customer> GetAllCustomers()
	//	=> _context.Customers.ToList();

	//	public Customer GetCustomerById(int id)
	//	{
	//		try
	//		{
	//			var customer = _context.Customers.Find(id);
	//			if (customer == null)
	//				throw new Exception($"Customer with ID {id} not found.");
	//			return customer;
	//		}
	//		catch (Exception ex)
	//		{
	//			throw new Exception("Failed to find customer: " + ex.Message);
	//		}
	//	}
	//	public void AddCustomer(Customer customer)
	//	{
	//		try
	//		{
	//			if (customer == null)
	//				throw new ArgumentNullException("Customer cannot be null.");

	//			_context.Customers.Add(customer);
	//			_context.SaveChanges();
	//		}
	//		catch (DbUpdateException ex)
	//		{
	//			throw new Exception("Failed to add customer: " + ex.InnerException?.Message);
	//		}
	//		catch (Exception ex)
	//		{
	//			throw new Exception("Unexpected error: " + ex.Message);
	//		}
	//	}
	//	public void UpdateCustomer(Customer customer)
	//	{
	//		try
	//		{
	//			if (customer == null)
	//				throw new ArgumentNullException("Customer cannot be null.");
	//			_context.Customers.Update(customer);
	//			_context.SaveChanges(); }
	//		catch (DbUpdateException ex)
	//		{
	//			throw new Exception("Failed to update customer: " + ex.InnerException?.Message);
	//		}
	//		catch (Exception ex)
	//		{
	//			throw new Exception("Unexpected error: " + ex.Message);
	//		}
	//	}

	//	public void DeleteCustomer(int id)
	//	{
	//		var customer = _context.Customers.Find(id);
	//		if (customer is null) throw new Exception("No Customer With This ID " + id); 
	//		try
	//		{if (customer != null)
	//			{
	//				_context.Customers.Remove(customer);
	//				_context.SaveChanges();
	//			}
	//		}
	//		catch(DbUpdateException ex)
	//		{
	//			throw new Exception("Failed to Delete customer: " + ex.InnerException?.Message);
	//		}
	//		catch (Exception ex)
	//		{
	//			throw new Exception("Unexpected error: " + ex.Message);
	//		}
	//	}
	//}

