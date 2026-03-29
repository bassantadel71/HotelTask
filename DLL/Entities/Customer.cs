using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Entities
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(50)]
		public required string FirstName { get; set; }

		[ MaxLength(50)]
		public required string LastName { get; set; }
		[DataType (DataType.DateTime)]
		public DateTime BirthDay { get; set; }
		[MaxLength (50)]
		public required string Gender { get; set; }

		[MaxLength (50)]
		[Phone]
		public required string PhoneNumber { get; set; }

		[MaxLength (50)]
		[EmailAddress]
		public required string EmailAddress { get; set; }

		public virtual ICollection<Reservation> Reservations { get; set; }
		public Address? Address { get; set; }
	}
}
