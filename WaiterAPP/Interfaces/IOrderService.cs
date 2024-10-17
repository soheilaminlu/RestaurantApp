
namespace WaiterAPP.Interfaces
{
    public interface IOrderService
    {
        Task GetAllOrders();

        Task<CreateOrderDto> CreateOrder()

        Task<OrderDto> GetOrderById(int id);

        Task<UpdateOrderDto> UpdateOrderById (int id);

        Task DeleteOrderById(int id);


    }
}
