using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Entities
{
	public class Payment
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(10)]
		public required string PaymentType { get; set; }
		[MaxLength(10)]
		public required string CardType { get; set; }
		[MaxLength(50)]
		public required string CardNumber { get; set; }
		[MaxLength(50)]
		public required string CardExp { get; set; }
		[MaxLength(10)]
		public required string CardCvc { get; set; }

		public float TotalBill { get; set; }
	}
}
