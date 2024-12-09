using aura_skin.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.BUS
{
    internal class RolesBUS
    {
        private RolesDAO rolesDAO = new RolesDAO();
        public List<Role> roles = new List<Role>();
        public RolesBUS()
        {
            ReadRolesList();
        }
        public void ReadRolesList()
        {
            this.roles = rolesDAO.GetRolesList();
        }
        public Role GetRoleByID(string id)
        {
            return rolesDAO.GetRoleByID(id);
        }
    }
}
