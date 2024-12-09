using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aura_skin.DAO;

namespace aura_skin.BUS
{
    internal class OrderBUS
    {
        private OrdersDAO ordersDAO = new OrdersDAO();
        public List<Order> orders;

        public OrderBUS() 
        {
            ReadOrdersList();
        }

        public void ReadOrdersList()
        {
            this.orders = ordersDAO.GetOrdersList();
        }

        public int GetTodayOrderCount()
        {
            return ordersDAO.GetTodayOrderCount();
        }
        public decimal GetTotalOrder()
        {
            return orders.Count;
        }
    }
}
