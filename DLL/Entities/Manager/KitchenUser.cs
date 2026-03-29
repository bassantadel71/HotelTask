using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Entities.Manager
{
	public class KitchenUser
	{
		[Key]
		[MaxLength(50)]
		public required string UserName { get; set; }
		[MaxLength(50)]
		public required string Password { get; set; }
	}
}
