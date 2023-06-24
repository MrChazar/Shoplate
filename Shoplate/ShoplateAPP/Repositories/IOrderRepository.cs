using ShoplateAPP.Models;

namespace ShoplateAPP.Repositories
{
    public interface IOrderRepository
    {
        public void SaveOrder(Order order);

        IEnumerable<Order> GetAll();

        Order? GetOrder(int id);

        IEnumerable<Order> GetAllUserOrders(int id);
    }
}
