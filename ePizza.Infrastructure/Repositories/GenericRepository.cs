using AutoMapper;
using AutoMapper.QueryableExtensions;
using ePizza.Domain.Interfaces;
using ePizza.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Infrastructure.Repositories
{
    public class GenericRepository<TDomain,TEntity> : IGenericRepository<TDomain> 
        where TDomain : class
        where TEntity : class
    {
        protected readonly ePizzaDbContext _dbContext;
        protected readonly IMapper _mapper;

        public GenericRepository(ePizzaDbContext dbContext, IMapper mapper)
        {
             _dbContext = dbContext;  
             _mapper = mapper;
        }
        public async Task<IEnumerable<TDomain>> GetAllAsync()
        {
            var result= await _dbContext.Set<TEntity>()
                .ProjectTo<TDomain>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return result;
        }

        public async Task<TDomain> GetAsync(object id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);

            return entity == null ? null : _mapper.Map<TDomain>(entity);
        }
    }
}
