using BCrypt.Net;
using ePizza.Application.DTOs.Request;
using ePizza.Application.DTOs.Response;
using ePizza.Application.Interfaces;
using ePizza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ePizza.Application.Implementation
{
    public class TokenGeneratorService : ITokenGeneratorService
    {
        private readonly IUserService userService;
        public TokenGeneratorService(IUserService userService) 
        {
            this.userService = userService;
        }
        public async Task<TokenResponseDto> GenerateTokenAsync(TokenRequestDto tokenrequestDto)
        {
            var userDomain = await userService.GetUserDetailAsync(tokenrequestDto.Username);

            if (userDomain == null)
            {
                throw new Exception($"User with email address {tokenrequestDto.Username} not found.");
            }

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(tokenrequestDto.Password, userDomain.Password);
            if (!isPasswordValid)
            {
                throw new Exception("Invalid password.");
            }

            // Implementation for token generation
            return new TokenResponseDto
            {
                AccessToken = "hard coded token"
            };
        }
    }
}
