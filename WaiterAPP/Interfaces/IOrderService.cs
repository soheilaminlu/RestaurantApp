
using WaiterAPP.Dto.OrderDto;
using WaiterAPP.Models;

namespace WaiterAPP.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrdersDto>> GetAllOrders();

        Task<OrdersDto> CreateOrder(CreateOrderDto order);

        Task<OrdersDto> GetOrderById(int id);

        Task<OrdersDto> UpdateOrderById ( UpdateOrderDto updateOrderDto , int id);

        Task DeleteOrderById(int id);


    }
}
