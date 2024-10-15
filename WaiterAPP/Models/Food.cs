using System.ComponentModel;

namespace WaiterAPP.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }

        public FoodCategory? FoodCategory { get; set; }

        public bool IsPopular { get; set; }        

        public bool IsAvailable { get; set; }       

        public int StockQuantity { get; set; }


    }

    public enum FoodCategory
    {
        FastFood =1,
        Kebab = 2,
        SeaFood = 3
    }
}
