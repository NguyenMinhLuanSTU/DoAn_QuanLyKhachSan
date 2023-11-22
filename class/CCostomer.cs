using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CCostomer
    {
        public string CostomerName {  get; set; }
        public string PhoneNumber {  get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string CCCD { get; set; }
        public CCostomer() { }
        public CCostomer(string costomerName, string phoneNumber, string nationality, DateTime dateOfBirth, string address, string cCCD)
        {
            CostomerName = costomerName;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
            Address = address;
            CCCD = cCCD;
        }
    }
}
