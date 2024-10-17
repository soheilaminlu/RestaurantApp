namespace WaiterAPP.Dto.OrderDto
{
    public class OrdersDto
    {
        public string? Appetizer { get; set; }
        public int AppetizerQuantity { get; set; }

        public string? MainCourse { get; set; }
        public int MainCourseQuantity { get; set; }

        public string? Dessert { get; set; }
        public int DessertQuantity { get; set; }
        public decimal AppetizerPrice { get; set; }
        public decimal MainCoursePrice { get; set; }
        public decimal DessertPrice { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return
                    (AppetizerPrice * AppetizerQuantity) +
                    (MainCoursePrice * MainCourseQuantity) +
                    (DessertPrice * DessertQuantity);
            }
        }

    }
    public class CreateOrderDto
    {
        public string? Appetizer { get; set; }
        public int AppetizerQuantity { get; set; }

        public string? MainCourse { get; set; }
        public int MainCourseQuantity { get; set; }

        public string? Dessert { get; set; }
        public int DessertQuantity { get; set; }
    }
    public class UpdateOrderDto
    {
        public string? Appetizer { get; set; }
        public int AppetizerQuantity { get; set; }

        public string? MainCourse { get; set; }
        public int MainCourseQuantity { get; set; }

        public string? Dessert { get; set; }
        public int DessertQuantity { get; set; }
    }
}
