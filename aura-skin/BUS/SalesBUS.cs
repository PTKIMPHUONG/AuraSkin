using aura_skin.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.BUS
{
    internal class SalesBUS
    {
        private SalesDAO salesDAO = new SalesDAO();
        public List<Sale> sales = new List<Sale>();
        public SalesBUS()
        {
            ReadSalesList();
        }
        public void ReadSalesList()
        {
            this.sales = salesDAO.GetSalesList();
        }
        public Sale GetSaleByID(string id)
        {
            return salesDAO.GetSaleByID(id);
        }
    }
}
