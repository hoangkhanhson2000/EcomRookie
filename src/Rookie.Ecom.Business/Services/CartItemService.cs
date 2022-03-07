using AutoMapper;
using EnsureThat;
using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly IBaseRepository<CartItem> _baseRepository;
        private readonly IMapper _mapper;

        public CartItemService(IBaseRepository<CartItem> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<CartItemDto> AddAsync(CartItemDto cartitemDto)
        {
            Ensure.Any.IsNotNull(cartitemDto, nameof(cartitemDto));
            var cartitem = _mapper.Map<CartItem>(cartitemDto);
            var item = await _baseRepository.AddAsync(cartitem);
            return _mapper.Map<CartItemDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task UpdateAsync(CartItemDto cartitemDto)
        {
            var cartitem = _mapper.Map<CartItem>(cartitemDto);
            await _baseRepository.UpdateAsync(cartitem);
        }

        public async Task<IEnumerable<CartItemDto>> GetAllAsync()
        {
            var cartitemies = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<CartItemDto>>(cartitemies);
        }

        public async Task<CartItemDto> GetByIdAsync(Guid id)
        {
            // map roles and cartitems: collection (roleid, cartitemid)
            // upsert: delete, update, insert
            // input vs db
            // input-y vs db-no => insert
            // input-n vs db-yes => delete
            // input-y vs db-y => update
            // unique, distinct, no-duplicate
            var cartitem = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<CartItemDto>(cartitem);
        }

        public async Task<PagedResponseModel<CartItemDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Cart.ToString().Contains(name));

            query = query.OrderBy(x => x.Cart);

            var assets = await query
                .AsNoTracking()
                .PaginateAsync(page, limit);

            return new PagedResponseModel<CartItemDto>
            {
                CurrentPage = assets.CurrentPage,
                TotalPages = assets.TotalPages,
                TotalItems = assets.TotalItems,
                Items = _mapper.Map<IEnumerable<CartItemDto>>(assets.Items)
            };
        }

    }
}
