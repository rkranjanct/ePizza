using ePizza.Application.Interfaces;
using ePizza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserService userService;

        public UserService(IUserService userService) 
        {
            this.userService = userService;
        }
        public async Task<UserDomain> GetUserDetailAsync(string emailAddress)
        {
            var userDomain = await userService.GetUserDetailAsync(emailAddress);
           
            return userDomain;
        }
    }
}
