using WaiterAPP.DataBase;

namespace WaiterAPP.Models
{
    public class Waiter
    {

        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }



        public int Age { get; set; }    

        public ICollection<Order>? Orders { get; set; }
      
    }
}
