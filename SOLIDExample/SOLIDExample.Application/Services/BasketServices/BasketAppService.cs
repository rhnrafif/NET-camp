using SOLIDExample.Application.SeedWorks;
using SOLIDExample.Entity.Entities.Baskets;
using SOLIDExample.Infrastructure.SeedWorks;
using SOLIDExample.Entity.Entities.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDExample.Application.Services.ProductServices;

namespace SOLIDExample.Application.Services.BasketServices
{
    public class BasketAppService : BaseService, IBasketAppService
    {
        private readonly IRepository<Basket> _basketRepo;
        private IProductAppService _productAppService;

        public BasketAppService(IUnitOfWorks unitOfWork, IRepository<Basket> basketRepo, 
            IProductAppService productAppService) : base(unitOfWork)
        {
            _basketRepo = basketRepo;
            _productAppService = productAppService;
        }


        public async Task AddItem(int basketId, int productId)
        {
            var basket = await _basketRepo.GetAsync(basketId);
            var productItem = basket.Products.FirstOrDefault(w => w.Id == productId);
            if( productItem == null)
            {
                var product = await _productAppService.GetById(productId);
                productItem = new BasketProductItem(product);
                basket.Products.Add(productItem);

            }
            else
            {
                productItem.Quantity += 1;
            }

            await UnitOfWork.SaveChangesAsync();
        }

        public async Task<Basket> Create(int userId)
        {
            var basket = new Basket(userId);
            _basketRepo.Add(basket);
            await UnitOfWork.SaveChangesAsync();
            return basket;
        }

        public async Task<Basket> Get(int id)
        {
            return await _basketRepo.GetAsync(id);
        }

        public async Task MarkAsResolved(int basketId)
        {
            var basket = await _basketRepo.GetAsync(basketId);
            basket.IsCheckedOut = true;
            await UnitOfWork.SaveChangesAsync();
        }

        public async Task RemoveItem(int basketId, int productId)
        {
            var basket = await _basketRepo.GetAsync(basketId);
            var productItem = basket.Products.FirstOrDefault(w => w.Id == productId);
            if(productItem != null)
            {
                basket.Products.Remove(productItem);
                await UnitOfWork.SaveChangesAsync();
            }
        }
    }
}
