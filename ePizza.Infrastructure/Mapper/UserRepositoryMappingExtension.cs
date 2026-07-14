using AutoMapper;
using ePizza.Domain.Models;
using ePizza.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Infrastructure.Mapper
{
    public class UserRepositoryMappingExtension:Profile
    {
        public UserRepositoryMappingExtension()
        {
                CreateMap<User, UserDomain>();
        }
    }
}
