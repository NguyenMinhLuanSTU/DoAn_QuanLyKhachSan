using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class CUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public CUser(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public CUser()
        {
        }
    }
}
