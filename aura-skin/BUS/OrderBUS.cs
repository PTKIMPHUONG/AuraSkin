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
            var query = orders
          .Where(o => o.create_at >= startDate && o.create_at <= endDate)
          .Select(o => new
          {
              o.id_order,
              o.id_user,
              Username = o.User.username, // Lấy username từ bảng User
              o.id_status,
              StatusName = o.StatusOrder.status_name, // Lấy status name từ bảng OrderStatus
              o.create_at,
              o.total_amount,
              o.delivery_fee,
              CustomerID = o.CustomerInfo, // Lấy ID khách hàng từ bảng Orders
              CustomerName = o.CustomerInfo.customer_name // Lấy tên khách hàng từ bảng CustomerInfo
          })
          .ToList();

            // Chuyển đổi kết quả thành danh sách các đối tượng Order
            var result = query.Select(o => new Order
            {
                id_order = o.id_order,
                id_user = o.id_user,
                id_status = o.StatusName,
                create_at = o.create_at,
                total_amount = o.total_amount,
                delivery_fee = o.delivery_fee,
                customer_info = o.CustomerName // Gán tên khách hàng vào trường customer_info
            }).ToList();

            return result;
        }

        public int GetTodayNewCustomerCount()
        {
            return ordersDAO.GetTodayNewCustomerCount();
        }
    }
}
