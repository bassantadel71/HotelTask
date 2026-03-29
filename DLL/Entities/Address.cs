using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Entities
{
	public class Address
	{
		[Key]
		public int Id { get; set; }
		public required string StreetAddress { get; set; }
		[MaxLength(50)]
		public required string AptSuite { get; set; }
		public required string City { get; set; }
		[MaxLength(50)]
		public required string State { get; set; }
		[MaxLength(10)]

		public required string ZipCode { get; set; }
		public int CustomerId { get; set; }
		public Customer? Customer { get; set; }
	}
}
