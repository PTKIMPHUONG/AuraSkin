using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DTO
{
    public class OrderDTO
    {
        public string id_order { get; set; }
        public string id_user { get; set; }
        public string Username { get; set; }
        public string id_status { get; set; }
        public string StatusName { get; set; }
        public DateTime create_at { get; set; }
        public decimal total_amount { get; set; }
        public decimal delivery_fee { get; set; }  // Nếu có thể là null, cần xử lý khi nhận giá trị này từ CSDL
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
}
