using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class RolesDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();
        public List<Role> GetRolesList()
        {
            return db.Roles.ToList();
        }
        public Role GetRoleByID(string id)
        {
            return db.Roles.FirstOrDefault(l => l.id_role == id);
        }
    }
}
