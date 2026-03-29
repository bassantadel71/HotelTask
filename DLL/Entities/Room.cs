using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Entities
{
	public class Room
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(10)]
		public required string RoomType { get; set; }
		[MaxLength(10)]
		public required int RoomFloor { get; set; }
		public required int RoomNumber { get; set; }

		public virtual ICollection<Reservation> Reservations { get; set; }
	}
}
