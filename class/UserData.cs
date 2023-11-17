using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class UserData
    {
        private static List<CUser> users = new List<CUser>();
        public static List<CUser> getAllUser()
        {
            return users;
        }
        public void saveUserData()
        {

        }
        public void readUserData()
        {

        }
    }
}
