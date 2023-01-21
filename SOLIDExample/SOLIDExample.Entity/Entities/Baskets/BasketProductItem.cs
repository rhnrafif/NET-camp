
using SOLIDExample.Entity.Entities.Products;
using SOLIDExample.Entity.SeedWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity.Entities.Basket
{
    [Table("BasketProductItem")]
    public class BasketProductItem : EntityBase
    {
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public BasketProductItem()
        {

        }
        public BasketProductItem(Product product)
        {
            Product = product;
            Quantity = 1;
        }
    }
}
