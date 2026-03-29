using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Entities.Manager
{
	public class FrontendUser
	{
		[Key]
		[MaxLength (50)]
		public required string user_name { get; set; }
		[MaxLength(50)]
		public required string pass_word { get; set; }
	}
}
