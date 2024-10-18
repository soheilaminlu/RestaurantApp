using WaiterAPP.DataBase;
using WaiterAPP.Dto.OrderDto;
using WaiterAPP.Interfaces;
using Microsoft.EntityFrameworkCore;
using WaiterAPP.Models;
using Microsoft.IdentityModel.Tokens;
using WaiterAPP.Dto.FoodDto;

namespace WaiterAPP.Services
{
    public class OrderService : IOrderService
    {
        private readonly ILogger<OrderService> _logger;
        private readonly AppDbContext _appDbContext;
        public OrderService(ILogger<OrderService> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }
        public async Task<OrdersDto> CreateOrder(CreateOrderDto order)
        {
            var orderModel = MapToOrderModelFromCreate(order);
            await _appDbContext.AddAsync(orderModel);
            await _appDbContext.SaveChangesAsync();
            var orderDto = MapToOrdersDtoFromModel(orderModel);
            return orderDto;
        }

        public async Task DeleteOrderById(int id)
        {
            var order = await _appDbContext.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order != null)
            {
                _appDbContext.Orders.Remove(order);
            }
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<OrdersDto>> GetAllOrders()
        {
           var orders = await _appDbContext.Orders.ToListAsync();
            if(orders == null || !orders.Any())
            {
                return new List<OrdersDto>();
            }
            var orderDto = orders.Select(o => MapToOrdersDtoFromModel(o)).ToList();
            return orderDto;
        }

        public async Task<OrdersDto> GetOrderById(int id)
        {
            var order = _appDbContext.Orders.FirstOrDefault(o => o.Id == id);
            if(order == null)
            {
                return null;
            }
            return MapToOrdersDtoFromModel(order);
        }

        public async Task<OrdersDto> UpdateOrderById(UpdateOrderDto updateOrdersDto, int id)
        {
            var order = await _appDbContext.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if (order == null)
            {
                return null;
            }
            var orderModel = MapToOrderModelFromUpdate(updateOrdersDto , order);
            await _appDbContext.SaveChangesAsync();
            return MapToOrdersDtoFromModel(orderModel);
        }

        private Order MapToOrderModelFromCreate(CreateOrderDto createOrderDto)
        {
            var orderModel = new Order
            {
                Appetizer = createOrderDto.Appetizer,
                AppetizerQuantity = createOrderDto.AppetizerQuantity,
                MainCourse = createOrderDto.MainCourse,
                MainCourseQuantity = createOrderDto.MainCourseQuantity,
                Dessert = createOrderDto.Dessert,
                DessertQuantity = createOrderDto.DessertQuantity
            };
            return orderModel;
        }
        private OrdersDto MapToOrdersDtoFromModel(Order orderModel)
        {
            return new OrdersDto
            {
                Appetizer = orderModel.Appetizer,
                AppetizerPrice = orderModel.AppetizerPrice,
                AppetizerQuantity = orderModel.AppetizerQuantity,
                MainCourse = orderModel.MainCourse,
                MainCoursePrice = orderModel.MainCoursePrice,
                MainCourseQuantity = orderModel.MainCourseQuantity,
                Dessert = orderModel.Dessert,
                DessertPrice = orderModel.DessertPrice,
                DessertQuantity = orderModel.DessertQuantity,
            };
        }
        private Order MapToOrderModelFromUpdate(UpdateOrderDto updateOrderDto , Order order)
        {
            order.Appetizer = updateOrderDto.Appetizer;
            order.AppetizerQuantity = updateOrderDto.AppetizerQuantity;
            order.MainCourse = updateOrderDto.MainCourse;
            order.MainCourseQuantity = updateOrderDto.MainCourseQuantity;
            order.Dessert = updateOrderDto.Dessert;
            order.DessertQuantity = updateOrderDto.DessertQuantity;
       
            return order;
        }
    }
}
