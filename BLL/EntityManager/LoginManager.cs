using BLL.Entities.Manager;
using DLL.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.EntityManager
{
	public class LoginManager
	{
		LoginDbContext _context = new LoginDbContext();

		public FrontendUser FrontendLogin(string username, string password)
		{
			try
			{
				var user = _context.FrontendUsers
					.FirstOrDefault(u => u.user_name == username && u.pass_word == password);

				if (user == null)
					throw new Exception("Invalid username or password.");

				return user;
			}
			catch (Exception ex)
			{
				throw new Exception("Login failed: " + ex.Message);
			}
		}

		
		public KitchenUser KitchenLogin(string username, string password)
		{
			try
			{
				var user = _context.KitchenUsers
					.FirstOrDefault(u => u.UserName == username && u.Password == password);

				if (user == null)
					throw new Exception("Invalid username or password.");

				return user;
			}
			catch (Exception ex)
			{
				throw new Exception("Login failed: " + ex.Message);
			}
		}
	}
}
