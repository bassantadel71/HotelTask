using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BLL.Entities
{
	public class Reservation
	{
		[Key]
		public int Id { get; set; }
		
		public int NumberGuest { get; set; }
		[DataType(DataType.Date)]
		public DateTime ArrivalTime { get; set; }
		[DataType(DataType.Date)]
		public DateTime LeavingTime { get; set; }

		public bool CheckIn { get; set; }
		public bool SupplyStatus { get; set; }

		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }
		public int RoomId { get; set; }
		public virtual Room Room { get; set; }
		public int PaymentId { get; set; }
		public virtual Payment Payment { get; set; }
		public int ServiceId { get; set; }
		public virtual Service Service { get; set; }

		
	}
}
