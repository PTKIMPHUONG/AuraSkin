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
        public User GetUserByID(string id)
        {
            return db.Users.FirstOrDefault(l => l.id_user == id);
        }
        public User GetUserByUsernameAndEmail(string username, string email)
        {
            return db.Users.FirstOrDefault(u => u.username == username && u.email == email);
        }
        public User GetUserByUsername(string username)
        { 
            return db.Users.FirstOrDefault(u=>u.username == username);

        }
        public bool ResetPassword(string id_user)
        {
            var existingUser = db.Users.FirstOrDefault(u => u.id_user == id_user);
            if (existingUser != null)
            {
                existingUser.password = existingUser.username;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdatePassword(string id_user,string NewPassword)
        {
            var existingUser = db.Users.FirstOrDefault(u => u.id_user == id_user);
            if (existingUser != null)
            {
                existingUser.password = NewPassword;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
