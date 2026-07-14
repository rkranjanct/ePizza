using AutoMapper;
using ePizza.Domain.Interfaces;
using ePizza.Domain.Models;
using ePizza.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Infrastructure.Repositories
{
    public class UserRepository :GenericRepository<UserDomain,User> ,IUserRepository
    {
        public UserRepository(ePizzaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<UserDomain> GetUserByEmailAsync(string emailAddress)
        {
            var UserDetails = await _dbContext.Users
                .Include(u=>u.Roles)
                .FirstOrDefaultAsync(u => u.Email == emailAddress);

            return _mapper.Map<UserDomain>(UserDetails);
        }
    }
}
