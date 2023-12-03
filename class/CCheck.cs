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
        public DateTime? CheckOut { get; set; }
        private double pay;
        public CCustomer customer;
        public CRoom room;
        public CCheck() { }
        public CCheck(DateTime CheckIn, CCustomer customer, CRoom room)
        {
            this.CheckIn = CheckIn;
            this.customer = customer;
            this.room = room;
        }
        public void SetCheckOut(DateTime CheckOut)
        {
            this.CheckOut = CheckOut;
        }
        public double CheckPay()
        {
            if (CheckOut.HasValue)
            {
                pay = (double)(CheckOut.Value.Day - CheckIn.Day) * room.GetPrice();
                return pay;
            }

            // Trường hợp không có thông tin CheckOut
            throw new InvalidOperationException("Không thể tính toán pay khi không có thông tin CheckOut.");

        }
    }
}
