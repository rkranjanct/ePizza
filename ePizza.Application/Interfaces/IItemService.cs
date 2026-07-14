using ePizza.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application.Interfaces
{
    public interface IItemService
    {
        Task<List<ItemResponseDto>> GetItemsAsync();
        Task<ItemResponseDto> GetItemAsync(int id);
    }
}
