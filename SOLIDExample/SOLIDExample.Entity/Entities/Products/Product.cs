using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity.Entities.Products
{
    [Table("Product")]
    public class Product
    {
        public string Name { get; set; }
        public long Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
