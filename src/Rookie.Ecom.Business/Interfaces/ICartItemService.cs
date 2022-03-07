using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Interfaces
{
    public interface ICartItemService
    {
        Task<IEnumerable<CartItemDto>> GetAllAsync();

        Task<PagedResponseModel<CartItemDto>> PagedQueryAsync(string name, int page, int limit);

        Task<CartItemDto> GetByIdAsync(Guid id);

        Task<CartItemDto> AddAsync(CartItemDto cartitemDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(CartItemDto cartitemDto);
    }
}
