using ePizza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Domain.Interfaces
{
    public interface IUserRepository:IGenericRepository<UserDomain>
    {
        Task<UserDomain> GetUserByEmailAsync(string emailAddress);
    }
}
