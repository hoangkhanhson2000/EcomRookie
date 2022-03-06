using EnsureThat;
using Microsoft.AspNetCore.Mvc;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.Web.Controllers
{
    [Route("api/[controller]")]
    public class CartItemController : Controller
    {
        private readonly ICartItemService _cartitemService;
        public CartItemController(ICartItemService cartitemService)
        {
            _cartitemService = cartitemService;
        }

        [HttpPost]
        public async Task<ActionResult<CartItemDto>> CreateAsync([FromBody] CartItemDto cartitemDto)
        {
            Ensure.Any.IsNotNull(cartitemDto, nameof(cartitemDto));
            var asset = await _cartitemService.AddAsync(cartitemDto);
            return Created(Endpoints.CartItem, asset);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] CartItemDto cartitemDto)
        {
            Ensure.Any.IsNotNull(cartitemDto, nameof(cartitemDto));
            Ensure.Any.IsNotNull(cartitemDto.Id, nameof(cartitemDto.Id));
            await _cartitemService.UpdateAsync(cartitemDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAssetAsync([FromRoute] Guid id)
        {
            var cartitemDto = await _cartitemService.GetByIdAsync(id);
            Ensure.Any.IsNotNull(cartitemDto, nameof(cartitemDto));
            await _cartitemService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<CartItemDto> GetByIdAsync(Guid id)
            => await _cartitemService.GetByIdAsync(id);

        [HttpGet]
        public async Task<IEnumerable<CartItemDto>> GetAsync()
            => await _cartitemService.GetAllAsync();

        [HttpGet("find")]
        public async Task<PagedResponseModel<CartItemDto>>
            FindAsync(string name, int page = 1, int limit = 10)
            => await _cartitemService.PagedQueryAsync(name, page, limit);
    }
}
