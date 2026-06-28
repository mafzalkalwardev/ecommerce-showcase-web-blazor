using ECommerceShowcaseWeb.Models;

namespace ECommerceShowcaseWeb.Services
{
    public class OrderService
    {
        private readonly List<Order> _orders = new List<Order>();
        private int _nextOrderId = 1;

        public int PlaceOrder(Order order)
        {
            order.Id = _nextOrderId++;
            order.OrderDate = DateTime.Now;
            _orders.Add(order);
            return order.Id;
        }

        public Order? GetOrderById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }
    }
}