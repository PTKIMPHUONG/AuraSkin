using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class CustomerInfoDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();
        public List<CustomerInfo> GetCustomerInfosList()
        {
            return db.CustomerInfos.ToList();
        }

    }
}
