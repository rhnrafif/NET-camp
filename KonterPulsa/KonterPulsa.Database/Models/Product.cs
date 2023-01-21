using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Database.Models
{
	[Table("product")]
	public class Product
	{
		[Key]
		public string ProductCode { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get;set; }
		public float Price { get; set; }
		public bool IsDeleted { get; set; }
	}
}
