using aura_skin.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.BUS
{
    internal class CustomerInfoBUS
    {
        private CustomerInfoDAO customersDAO = new CustomerInfoDAO();
        public List<CustomerInfo> customers;

        public CustomerInfoBUS()
        {
            ReadCustomerInfoList();
        }

        public void ReadCustomerInfoList()
        {
            this.customers = customersDAO.GetCustomerInfosList() ;
        }

        public int GetTotalCustomer()
        {
            return customers.Count;
        }
    }
}
