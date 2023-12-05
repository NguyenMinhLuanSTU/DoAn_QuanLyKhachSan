using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    class Processing
    {
        public static List<CRoom> _rooms = FileControl<CRoom>.Read("rooms.json");
        public static List<CCustomer> _customers = FileControl<CCustomer>.Read("customers.json");
        public static List<CCheck> _checks = FileControl<CCheck>.Read("checks.json");
        public static List<CUser> _users = FileControl<CUser>.Read("users.json");


        
    }
}
