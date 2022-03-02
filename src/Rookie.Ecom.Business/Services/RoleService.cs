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
    public class RoleService : IRoleService
    {
        private readonly IBaseRepository<Role> _baseRepository;
        private readonly IMapper _mapper;

        public RoleService(IBaseRepository<Role> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<RoleDto> AddAsync(RoleDto roleDto)
        {
            Ensure.Any.IsNotNull(roleDto, nameof(roleDto));
            var role = _mapper.Map<Role>(roleDto);
            var item = await _baseRepository.AddAsync(role);
            return _mapper.Map<RoleDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task UpdateAsync(RoleDto roleDto)
        {
            var role = _mapper.Map<Role>(roleDto);
            await _baseRepository.UpdateAsync(role);
        }

        public async Task<IEnumerable<RoleDto>> GetAllAsync()
        {
            var roleies = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<RoleDto>>(roleies);
        }

        public async Task<RoleDto> GetByIdAsync(Guid id)
        {
            // map roles and roles: collection (roleid, roleid)
            // upsert: delete, update, insert
            // input vs db
            // input-y vs db-no => insert
            // input-n vs db-yes => delete
            // input-y vs db-y => update
            // unique, distinct, no-duplicate
            var role = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<RoleDto>(role);
        }

        public async Task<PagedResponseModel<RoleDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.RoleName.Contains(name));

            query = query.OrderBy(x => x.RoleName);

            var assets = await query
                .AsNoTracking()
                .PaginateAsync(page, limit);

            return new PagedResponseModel<RoleDto>
            {
                CurrentPage = assets.CurrentPage,
                TotalPages = assets.TotalPages,
                TotalItems = assets.TotalItems,
                Items = _mapper.Map<IEnumerable<RoleDto>>(assets.Items)
            };
        }

    }
}
