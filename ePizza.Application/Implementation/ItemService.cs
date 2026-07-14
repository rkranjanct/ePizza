using ePizza.Application.DTOs.Response;
using ePizza.Application.Interfaces;
using ePizza.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application.Implementation
{
    public class ItemService : IItemService
    {
       private readonly IItemRepository _itemRepository;
        public ItemService( IItemRepository itemRepository)
        {
             _itemRepository = itemRepository;   
        }
       

        public async Task<List<ItemResponseDto>> GetItemsAsync()
        {
            var items = await _itemRepository.GetAllAsync();

            List<ItemResponseDto> itemsResponse
                = new List<ItemResponseDto>();

            foreach (var item in items)
            {
                ItemResponseDto data = new()
                {
                    Description = item.Description,
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    UnitPrice = item.UnitPrice,
                    Name = item.Name,
                };
                itemsResponse.Add(data);
            }

            return itemsResponse;
        }



        public async Task<ItemResponseDto> GetItemAsync(int id)
        {
          var item 
                = await _itemRepository.GetAsync(id);
            return new ItemResponseDto()
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                UnitPrice = item.UnitPrice,
                ImageUrl = item.ImageUrl,
            };
        }
    }
}
