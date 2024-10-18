using Microsoft.IdentityModel.Tokens;
using WaiterAPP.DataBase;
using WaiterAPP.Dto.FoodDto;
using WaiterAPP.Interfaces;
using WaiterAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace WaiterAPP.Services
{
    public class FoodService : IFoodService
    {
        private readonly ILogger<FoodService> _logger;
        private readonly AppDbContext _appDbContext;
        public FoodService(ILogger<FoodService> logger , AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }
        public async Task<FoodDto> CreateFood(CreateFoodDto createFoodDto)
        {
           var newFood = MapToFoodModelFromCreate(createFoodDto);
            if (newFood == null)
            {
                return null;
            }
            await _appDbContext.Foods.AddAsync(newFood);
            await _appDbContext.SaveChangesAsync();
            var foodDto = MapToFoodDtoFromModel(newFood);
            return foodDto;
        }

        public Task DeleteFoodById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FoodDto>> GetAllFoods()
        {
            var foods = await _appDbContext.Foods.ToListAsync();
            if (foods == null || foods.Any())
            {
                return new List<FoodDto>();
            }
            return foods.Select(o => MapToFoodDtoFromModel(o)).ToList();
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

        private Food MapToFoodModelFromCreate(CreateFoodDto createFoodDto)
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