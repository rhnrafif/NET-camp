using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOLIDExample.Application.Services.BasketServices;

namespace SOLIDExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly ILogger<BasketController> _logger;
        //private readonly BasketAppService _basketAppService; //cara yang salah
        private readonly IBasketAppService _basketAppService;

    }
}
