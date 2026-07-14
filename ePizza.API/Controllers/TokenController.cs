using ePizza.Application.DTOs.Request;
using ePizza.Application.DTOs.Response;
using ePizza.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase

    {
        private readonly ITokenGeneratorService tokenGeneratorService;

        public TokenController(ITokenGeneratorService tokenGeneratorService)
        {
            this.tokenGeneratorService = tokenGeneratorService;
        }
        [HttpPost]
        public async Task<ActionResult<TokenResponseDto>> Post([FromBody] TokenRequestDto request)
        {
            var token = await tokenGeneratorService.GenerateTokenAsync(request);
            return Ok(token);
        }
    }
}
