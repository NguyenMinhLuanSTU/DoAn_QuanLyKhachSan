using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.User_Control
{
    public partial class UC_BookRoom : UserControl
    {
        public static List<CCustomer> customers;
        public static List<CCheck> checks;
        public static List<CRoom> rooms;
        public List<String> ids;
        public UC_BookRoom()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
        }
        private Boolean ValidateInput()
        {
            //Conditions: Empty value
            if (txtName.Text == ""
                || txtPhone.Text == ""
                || txtNationality.Text == ""
                || txtAddress.Text == ""
                || txtCCCD.Text == ""
                || cbbBTYPE.Text == ""
                || cbbRCLASS.Text == ""
                || cbbIDRoom.Text == ""
                || txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Conditions: Date Checkin
            if (DateTime.Compare(dtpCheckIn.Value, DateTime.Now) == -1)
            {
                MessageBox.Show("lỗi ngày check in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Conditions: Date Of Birth
            int age = (DateTime.Now.Date - dtpBirth.Value.Date).Days;
            if (age < (18 * 365.25))
            {
                MessageBox.Show("Chưa đủ 18 tuổi !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Name
            bool flag = false; 
            foreach (char c in txtName.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("Lỗi Name !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Nationality
            flag = false;
            foreach (char c in txtNationality.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("Lỗi Nationality !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Address
            flag = false;
            foreach (char c in txtAddress.Text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("Lỗi address !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Conditions: ID Customer
            if (!Regex.IsMatch(txtPhone.Text, @"^\d{9,12}$"))
            {
                MessageBox.Show("Lỗi Phone ID Customer !!!\nCó 9 hoặc 12 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Conditions: Phone Number
            if (!Regex.IsMatch(txtPhone.Text, @"^\d{10,11}$"))
            {
                MessageBox.Show("Lỗi Phone Number !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private CRoom GetRoomById(string roomId)
        {
            // Tìm phòng theo ID
            foreach (CRoom r in rooms)
            {
                if (r.IDRoom == roomId)
                {
                    return r;
                }
            }

            throw new InvalidOperationException("Không tìm thấy phòng có ID: " + roomId);
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    throw new InvalidOperationException("Input");
                }

                // làm việc với room
                CRoom room = GetRoomById(cbbIDRoom.Text);


                if (cbbBTYPE.Text != room.BTYPE || cbbRCLASS.Text != room.RCLASS)
                {
                    MessageBox.Show("Phòng không đúng ID", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Làm việc với customer
                CCustomer customer = new CCustomer(txtName.Text, txtPhone.Text, txtNationality.Text, dtpBirth.Value, txtAddress.Text, txtCCCD.Text);
                //kiểm tra CCCD với kho lưu trữ class
                foreach (CCustomer ctm in customers)
                {
                    if (ctm.CCCD == customer.CCCD)
                    {
                        // Hiển thị thông báo
                        MessageBox.Show("Người nãy đã đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //add
                customers.Add(customer);


                //Làm việc với check

                //end
                MessageBox.Show("Đặt phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_BookRoom_Load(object sender, EventArgs e)
        {
            
            customers = FileControl<CCustomer>.Read("customers.json");
        }
    }
}
