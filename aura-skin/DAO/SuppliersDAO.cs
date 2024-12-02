using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class SuppliersDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();
        public List<Supplier> GetSuppliersList()
        {
            return db.Suppliers.ToList();
        }
        public Supplier GetSupplierByID(string id)
        {
            return db.Suppliers.FirstOrDefault(l => l.id_supplier == id);
        }
    }
}
