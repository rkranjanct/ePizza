using AutoMapper;
using ePizza.Domain.Interfaces;
using ePizza.Domain.Models;
using ePizza.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Infrastructure.Repositories
{
    public class ItemRepository : GenericRepository<ItemDomain, Item>, IItemRepository
    {
        public ItemRepository(ePizzaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
