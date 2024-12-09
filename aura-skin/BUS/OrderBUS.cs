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
        public int GetTotalOrder()
        {
            return orders.Count;
        }

       
        public int GetTotalOrderAmount()
        {
            // Tổng tiền từ tất cả các đơn hàng
            return (int)orders.Sum(o => o.total_amount); 
        }

        public int GetTotalOrderAmountByStatus()
        {
            // Lọc các đơn hàng theo trạng thái và tính tổng tiền cho tất cả các trạng thái
            var totalAmount = orders
                .Where(o => o.id_status == "STA001" || o.id_status == "STA002" || o.id_status == "STA003")
                .Sum(o => o.total_amount);

            return (int)totalAmount;
        }

        public int GetTotalOrderAmountForTodayByStatus()
        {
            var today = DateTime.Today; // Ngày hôm nay (không có giờ)

            // Lọc các đơn hàng có trạng thái STA001, STA002, STA003 và ngày tạo trong ngày hôm nay
            var totalAmount = orders
                .Where(o => (o.id_status == "STA001" || o.id_status == "STA002" || o.id_status == "STA003")
                            && o.create_at >= today && o.create_at < today.AddDays(1))
                .Sum(o => o.total_amount);

            return (int)totalAmount;
        }

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return ordersDAO.GetOrdersByDateRange(startDate, endDate);
        }
    }
}
