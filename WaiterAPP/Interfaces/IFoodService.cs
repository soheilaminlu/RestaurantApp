
namespace WaiterAPP.Interfaces
{
    public interface IFoodService
    {
        Task<FoodDto> GetAllFoods();

        Task<CreateFoodDto> CreateFood();

        Task<FoodDto> GetFoodByCategory(string categoryName);

        Task<UpdateFoodDto> UpdateFoodById(int Id);

        Task DeleteFoodById(int Id);

        Task<FoodDto> GetFoodById(int Id);


    }
}
