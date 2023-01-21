﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Database.Models
{
	[Table("transation")]
	public class Transaction
	{
		[Key]
		public Guid Id { get; set; }
		public Guid CustomerId { get; set; }
		public string ProductCode { get; set; }
		public DateTime TransactionDate { get; set; }
		public bool PaymentStatus { get; set; }

		public virtual Customer Customer { get; set; }
		public virtual Product Product { get; set; }
	}
}
