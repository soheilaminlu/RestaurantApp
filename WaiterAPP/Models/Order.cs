namespace WaiterAPP.Models
{
    public class Order
    {
        public int Id { get; set; }

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
        public Waiter? Waiter { get; set; }

        public int WaiterId { get; set; }

        public OrderStatus? OrderStatus { get; set; }

    }

    public enum OrderStatus
    {
        Pending =1,
        Preparing =2,
        Delivered =3
    }
}
