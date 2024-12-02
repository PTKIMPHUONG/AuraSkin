using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aura_skin.DAO;

namespace aura_skin.BUS
{
    internal class UsersBUS
    {   
        private UsersDAO usersDAO=new UsersDAO();
        public List<User> users = new List<User>();
        public UsersBUS() 
        {
            ReadUsersList();
        }
        public void ReadUsersList()
        {
            this.users=usersDAO.GetUsersList();
        }
        public User GetUserByID(string id)
        {
            return usersDAO.GetUserByID(id);
        }
    }
}
