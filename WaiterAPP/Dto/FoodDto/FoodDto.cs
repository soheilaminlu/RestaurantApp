using WaiterAPP.Models;

namespace WaiterAPP.Dto.FoodDto
{
    public class FoodDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }

        public FoodCategory? FoodCategory { get; set; }

        public bool IsAvailable { get; set; }

        public int StockQuantity { get; set; }
    }

    public class CreateFoodDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }

        public FoodCategory? FoodCategory { get; set; }

        public int StockQuantity { get; set; }
    }

    public class UpdateFoodDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }

        public FoodCategory? FoodCaegory { get; set; }

        public int StockQuantity { get; set; }
    }
}
