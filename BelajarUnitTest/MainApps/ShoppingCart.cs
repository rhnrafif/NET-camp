using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApps
{
    public record Product(int Id, string name, double price);

    public interface IDbService
    {
        bool SaveCartItem(Product product);
        bool UpdateCartItem(Product product);
        bool RemoveCartItem(int? id);
    }
    public class ShoppingCart
    {
        private IDbService _dbService;
        public ShoppingCart(IDbService dbService)
        {
            _dbService = dbService;
        }

        public bool AddProduct(Product ? product)
        {
            if (product == null)
                return false;
            if (product.Id == 0)
                return false;

            _dbService.SaveCartItem(product);
            return true;
        }

        public bool UpdateProduct(Product? product)
        {
            if(product == null)
                return false;
            if(product.Id == 0)
                return false;

            _dbService.UpdateCartItem(product);
            return true;            
        }

        public bool DeleteProduct (int? id)
        {
            if (id == 0)
                return false;
            if (id == null)
                return false;

            _dbService.RemoveCartItem(id);
            return true;
        }
    }
}
