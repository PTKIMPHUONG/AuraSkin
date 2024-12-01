using aura_skin.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class UsersDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();
        public List<User> GetUsersList()
        {
            return db.Users.ToList();
        }
    }
}
