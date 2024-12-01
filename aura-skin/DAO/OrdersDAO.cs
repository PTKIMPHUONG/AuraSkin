﻿using System;
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
    }
}
