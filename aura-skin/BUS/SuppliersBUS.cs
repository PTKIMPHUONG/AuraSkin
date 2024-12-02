using aura_skin.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.BUS
{
    internal class SuppliersBUS
    {
        private SuppliersDAO suppliersDAO = new SuppliersDAO();
        public List<Supplier> suppliers;
        public SuppliersBUS()
        {
            ReadSuppliersList();
        }
        public void ReadSuppliersList()
        { 
            this.suppliers = suppliersDAO.GetSuppliersList();
        }
        public Supplier GetSupplierByID(string id)
        {
            return suppliersDAO.GetSupplierByID(id);
        }
    }
}
