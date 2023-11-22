using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CRoom
    {
        public string IDRoom { get; set; }

        public string RCLASS { get; set; }
        public string BTYPE { get; set; }
        public string Price { get; set; }
        public bool Hired { get; set; }
        
        public CRoom() { }
        public CRoom(string IDRoom,  string RCLASS, string BTYPE,string Price, bool Hired)
        {
            this.IDRoom = IDRoom;
            this.RCLASS = RCLASS;
            this.BTYPE = BTYPE;
            this.Price = Price;
            this.Hired = Hired;
        }
        public string getPrice()
        {
            return Price;
        }
    }
}
