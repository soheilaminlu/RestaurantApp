using Microsoft.IdentityModel.Tokens;
using WaiterAPP.Dto.FoodDto;
using WaiterAPP.Interfaces;
using WaiterAPP.Models;

namespace WaiterAPP.Services
{
    public class FoodService : IFoodService
    {
        public Task<FoodDto> CreateFood(CreateFoodDto createFoodDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFoodById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FoodDto>> GetAllFoods()
        {
            throw new NotImplementedException();
        }

        public Task<FoodDto> GetFoodByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<FoodDto> GetFoodById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<FoodDto> UpdateFoodById(UpdateFoodDto updateFoodDto , int Id)
        {
            throw new NotImplementedException();
        }

        private Food MapToFoodDtoFromCreate(CreateFoodDto createFoodDto)
        {
            return new Food
            {
                Name = createFoodDto.Name,
                Description = createFoodDto.Description,
                Price = createFoodDto.Price,
                FoodCategory = createFoodDto.FoodCategory,
                StockQuantity = createFoodDto.StockQuantity,
            };
        }
        private FoodDto MapToFoodDtoFromModel(Food food)
        {
            return new FoodDto
            {
                Name = food.Name,
                Description = food.Description,
                Price = food.Price,
                FoodCategory = food.FoodCategory,
                StockQuantity = food.StockQuantity,
                IsAvailable = food.IsAvailable,
            };
        }
        private Food MapToFoodFromUpdate(UpdateFoodDto updateFoodDto , Food food)
        {
            food.Name= updateFoodDto.Name;
            food.Description= updateFoodDto.Description;
            food.Price= updateFoodDto.Price;
            food.FoodCategory = updateFoodDto.FoodCaegory;
            food.StockQuantity = updateFoodDto.StockQuantity;

            return food;
        }
    }
}