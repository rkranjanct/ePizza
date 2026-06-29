using AutoMapper;
using ePizza.Domain.Models;
using ePizza.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Infrastructure.Mapper
{
    public class ItemRepositoryMappingExtension:Profile
    {
        public ItemRepositoryMappingExtension()
        {
            CreateMap<Item, ItemDomain>();
        }
    }
}
