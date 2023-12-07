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
        public double pay {  get; set; }
        public CCustomer customer;
        private string idRoom;
        public string IdRoom { get => idRoom; set => idRoom = value; }
        
        public double price {  get; set; }

        public CCheck() { }
        public CCheck(DateTime CheckIn, CCustomer customer, string room, double price)
        {
            this.CheckIn = CheckIn;
            this.customer = customer;
            this.IdRoom = room;
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
