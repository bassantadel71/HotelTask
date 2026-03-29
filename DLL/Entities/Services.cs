using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Entities
{
	public class Service
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int BreakFast { get; set; }
		[Required]
		public int Lunch { get; set; }
		public int Dinner { get; set; }
		[Required]
		public bool Cleaning { get; set; }
		[Required]
		public bool Towel { get; set; }
		[Required]
		public bool SSurprise { get; set; }
		[Required]
		public int FoodBill { get; set; }
		public virtual ICollection<Reservation> Reservations { get; set; }
	}
}
