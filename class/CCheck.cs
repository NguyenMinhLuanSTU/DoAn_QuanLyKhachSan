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
        public double pay;
        public CCustomer customer;
        public string idRoom;
        public double price;
        public CCheck() { }
        public CCheck(DateTime CheckIn, CCustomer customer, string room, double price)
        {
            this.CheckIn = CheckIn;
            this.customer = customer;
            this.idRoom = room;
            this.price = price;
            CheckOut = null;
        }
        public void SetCheckOut(DateTime CheckOut)
        {
            this.CheckOut = CheckOut;
        }
        public double CheckPay()
        {
            if (CheckOut.HasValue)
            {
                pay = (double)(CheckOut.Value.Day - CheckIn.Day) * price;
                return pay;
            }

            // Trường hợp không có thông tin CheckOut
            throw new InvalidOperationException("Không thể tính toán pay khi không có thông tin CheckOut.");

        }
    }
}
