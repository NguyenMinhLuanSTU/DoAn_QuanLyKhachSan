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

        public string RoomClass { get; set; }
        public string BedType { get; set; }
        public double Price { get; set; }
        public bool Rent { get; set; }
        
        public CRoom() { }
        public CRoom(string IDRoom,  string RCLASS, string BTYPE,double Price, bool Rent)
        {
            this.IDRoom = IDRoom;
            this.RoomClass = RCLASS;
            this.BedType = BTYPE;
            this.Price = Price;
            this.Rent = Rent;
        }
        
        public double GetPrice()
        {
            return Price;
        }
    }
}
