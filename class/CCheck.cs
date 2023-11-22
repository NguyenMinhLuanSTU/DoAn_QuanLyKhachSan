using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CCheck
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        private int pay;
        public CCostomer costomer;
        public CRoom room;
        public CCheck() { }
        public CCheck(DateTime CheckIn, CCostomer costomer, CRoom room)
        {
            this.CheckIn = CheckIn;
            this.costomer = costomer;
            this.room = room;
        }
        public CCheck(DateTime CheckOut)
        {
            this.CheckOut = CheckOut;
        }
        public int checkPay()
        {
            pay = (int)(CheckOut.Day - CheckIn.Day) * int.Parse(room.getPrice());
            return pay;
        }
    }
}
