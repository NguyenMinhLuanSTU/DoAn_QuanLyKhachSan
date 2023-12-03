using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CCustomer
    {
        public string CustomerName {  get; set; }
        public string PhoneNumber {  get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string CCCD { get; set; }
        public CCustomer() { }
        public CCustomer(string customerName, string phoneNumber, string nationality, DateTime dateOfBirth, string address, string cCCD)
        {
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
            Address = address;
            CCCD = cCCD;
        }
    }
}
