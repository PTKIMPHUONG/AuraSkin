using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class OrdersDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();

        // Lấy lịch sử mua hàng của khách hàng
        public List<string> GetCustomerProductIDs(string customerID)
        {
            return db.OrderItems
                     .Where(o => o.Order.CustomerInfo.id_customer_info == customerID)
                     .Select(o => o.id_product)
                     .ToList();
        }

        // Lấy danh sách sản phẩm và số lần được mua (cho Collaborative Filtering)
        public Dictionary<string, int> GetProductPurchaseFrequency()
        {
            return db.OrderItems
                     .GroupBy(o => o.id_product)
                     .ToDictionary(g => g.Key, g => g.Count());
        }
         public List<Order> GetOrdersList()
        {
            return db.Orders.ToList();
        }

        // Lấy tổng số đơn hàng tạo trong ngày hôm nay
        public int GetTodayOrderCount()
        {
            DateTime today = DateTime.Today;
            return db.Orders
                     .Where(o => o.create_at.Date == today)
                     .Count();
        }

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return db.Orders
                .Where(o => o.create_at >= startDate && o.create_at <= endDate)
                .ToList();
        }

        public int GetTodayNewCustomerCount()
        {
            DateTime today = DateTime.Today;

            return db.Orders
                     .GroupBy(o => o.CustomerInfo.id_customer_info) // Nhóm theo khách hàng
                     .Where(g => g.Min(o => o.create_at).Date == today) // Ngày đầu tiên tạo đơn hàng là hôm nay
                     .Count(); // Đếm số lượng khách hàng
        }
    }
}
