using ePizza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDomain> GetUserDetailAsync(string emailAddress);
    }
}
