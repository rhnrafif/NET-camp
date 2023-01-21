using SOLIDExample.Entity.Entities.Baskets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.Services.BasketServices
{
    public interface IBasketAppService
    {
        Task<Basket> Get(int id);
        Task<Basket> Create(int userId);
        Task AddItem(int basketId, int productId);
        Task RemoveItem(int basketId, int productId);
        Task MarkAsResolved (int basketId);
    }
}
