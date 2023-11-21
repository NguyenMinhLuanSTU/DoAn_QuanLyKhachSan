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

        private int Price;
        public string RCLASS { get; set; }
        public string BTYPE { get; set; }
        public bool Hired { get; set; }
        //public enum  RCLASS
        //{
        //    VIP,
        //    Class1,
        //    Class2
        //}
        //public enum BTYPE
        //{
        //    SIGLE,
        //    DOUBLE,
        //    TRIPLE
        //}
        public CRoom() { }
        public CRoom(string IDRoom, int Price, string RCLASS, string BTYPE, bool Hired)
        {
            this.IDRoom = IDRoom;
            this.Price = Price;
            this.RCLASS = RCLASS;
            this.BTYPE = BTYPE;
            this.Hired = Hired;
        }
        public int getPrice()
        {
            return this.Price;
        }
    }
}
