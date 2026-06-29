using ePizza.Application.Implementation;
using ePizza.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;    
        }

        [HttpGet]

        public async Task<IActionResult>Get()
        {
            var items = await _itemService.GetItemsAsync();

            return Ok(items);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var items = await _itemService.GetItemAsync(id);

            return Ok(items);
        }
    }
}
