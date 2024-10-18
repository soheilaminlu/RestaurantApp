
using WaiterAPP.Dto.FoodDto;

namespace WaiterAPP.Interfaces
{
    public interface IFoodService
    {
        Task<FoodDto> GetAllFoods();

        Task<FoodDto> CreateFood(CreateFoodDto createFoodDto);

        Task<FoodDto> GetFoodByCategory(string categoryName);

        Task<FoodDto> UpdateFoodById(UpdateFoodDto updateFoodDto , int Id);

        Task DeleteFoodById(int Id);

        Task<FoodDto> GetFoodById(int Id);


    }
}
