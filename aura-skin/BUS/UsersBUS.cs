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
        public User GetUserByUsernameAndEmail(string username, string email)
        {
            return usersDAO.GetUserByUsernameAndEmail(username, email);
        }
        public User GetUserByUsername(string username)
        {
            return usersDAO.GetUserByUsername(username);
        }
        public bool ResetPassword(string id_user)
        {
            return usersDAO.ResetPassword(id_user);
        }
        public bool UpdatePassword(string id_user, string NewPassword)
        {
            return usersDAO.UpdatePassword(id_user, NewPassword);
        }
    }
}
