using Microsoft.EntityFrameworkCore;
using ShoplateAPP.Data;
using ShoplateAPP.Models;

namespace ShoplateAPP.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private DatabaseContext context;

        public OrderRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void SaveOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public Order? GetOrder(int id)
        {
            var order = context.Orders
                .Include(o => o.Items)
                .Include(o => o.User)
                .FirstOrDefault(o => o.Id == id);

            return order;
        }

        public IEnumerable<Order> GetAllUserOrders(int id) 
        {
            return context.Orders.Where(items => items.UserId == id).ToList();
        }

    }
}
