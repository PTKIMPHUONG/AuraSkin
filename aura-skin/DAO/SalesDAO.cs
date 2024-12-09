using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class SalesDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();
        public List<Sale> GetSalesList()
        {
            return db.Sales.ToList();
        }
        public Sale GetSaleByID(string id)
        {
            return db.Sales.FirstOrDefault(l => l.id_sale == id);
        }
    }
}
