using ePizza.Application.DTOs.Request;
using ePizza.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application.Interfaces
{
    public interface ITokenGeneratorService
    {
        Task<TokenResponseDto> GenerateTokenAsync(TokenRequestDto request);
    }
}
