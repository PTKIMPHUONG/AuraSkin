using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DTO
{
    internal class Users
    {
        private string id_user { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private string full_name { get; set; }
        private string email { get; set; }
        private string gender { get; set; }
        private string phone_number { get; set; }
        private string address { get; set; }

        public Users() { }
        public Users(string id_user, string username, string password, string full_name, string email, string gender, string phone_number, string address)
        {
            this.id_user = id_user;
            this.username = username;
            this.password = password;
            this.full_name = full_name;
            this.email = email;
            this.gender = gender;
            this.phone_number = phone_number;
            this.address = address;
        }
    }
}
