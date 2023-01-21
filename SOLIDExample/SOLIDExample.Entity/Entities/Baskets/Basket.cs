using SOLIDExample.Entity.Entities.Basket;
using SOLIDExample.Entity.SeedWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Entity.Entities.Baskets
{
    [Table("Basket")]
    public class Basket : EntityBase
    {
        public int UserId { get; set; }
        public bool IsCheckedOut { get; set; }
        public virtual ICollection<BasketProductItem> Products { get; set; }
        public Basket(int userId)
        {
            UserId = userId;
        }

    }
}
