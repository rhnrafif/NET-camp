using SOLIDExample.Entity.Entities.Products;
using SOLIDExample.Entity.SeedWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity.Orders
{
    [Table("OrderProductItem")]
    public class OrderProductItem : EntityBase
    {
        public virtual Product Product { get; set; }
        public long Price { get; }
        public int Quantity { get; }
        public OrderProductItem()
        {

        }
        public OrderProductItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public OrderProductItem(Product product, long price, int quantity)
        {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }
    }
}
