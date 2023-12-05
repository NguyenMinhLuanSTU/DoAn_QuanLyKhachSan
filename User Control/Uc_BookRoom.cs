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
        public static List<CCheck> checks = FileControl<CCheck>.Read("checks.json");
        public static List<CRoom> rooms = FileControl<CRoom>.Read("rooms.json");
        public List<String> ids;
        public UC_BookRoom()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
        }

        private bool IsStringValid(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNumberValid(string number, int minLength, int maxLength)
        {
            return Regex.IsMatch(number, $@"^\d{{{minLength},{maxLength}}}$");
        }

        private bool IsDateOfBirthValid(DateTime birthDate, int minimumAgeInYears)
        {
            int age = (DateTime.Now.Date - birthDate.Date).Days;
            return age >= (minimumAgeInYears * 365.25);
        }

        private bool ValidateInput()
        {
            //Conditions: Empty value
            if (string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtPhone.Text)
                || string.IsNullOrWhiteSpace(txtNationality.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text)
                || string.IsNullOrWhiteSpace(txtCCCD.Text)
                || string.IsNullOrWhiteSpace(cbbBTYPE.Text)
                || string.IsNullOrWhiteSpace(cbbRCLASS.Text)
                || string.IsNullOrWhiteSpace(cbbIDRoom.Text)
                || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Date Checkin
            if (DateTime.Compare(dtpCheckIn.Value, DateTime.Now) == -1)
            {
                MessageBox.Show("Lỗi ngày check in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Date Of Birth
            if (!IsDateOfBirthValid(dtpBirth.Value, 18))
            {
                MessageBox.Show("Chưa đủ 18 tuổi !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Name
            if (!IsStringValid(txtName.Text))
            {
                MessageBox.Show("Lỗi Name !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Nationality
            if (!IsStringValid(txtNationality.Text))
            {
                MessageBox.Show("Lỗi Nationality !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Address
            if (!IsStringValid(txtAddress.Text))
            {
                MessageBox.Show("Lỗi address !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: ID Customer
            if (!IsNumberValid(txtCCCD.Text, 9, 12))
            {
                MessageBox.Show("Lỗi ID Customer !!!\nCó 9 hoặc 12 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Conditions: Phone Number
            if (!IsNumberValid(txtPhone.Text, 10, 11))
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

        private void UpdateComboBoxItems()
        {
            // Lấy danh sách các loại phòng và loại giường từ danh sách phòng
            var distinctIDRoom = rooms.Select(r => r.IDRoom).Distinct().ToList();
            var distinctRClasses = rooms.Select(r => r.RCLASS).Distinct().ToList();
            var distinctBTypes = rooms.Select(r => r.BTYPE).Distinct().ToList();
            // Cập nhật Items cho ComboBox
            cbbIDRoom.DataSource = distinctIDRoom;
            cbbRCLASS.DataSource = distinctRClasses;
            cbbBTYPE.DataSource = distinctBTypes;

            cbbIDRoom.Text = null;
            cbbRCLASS.Text = null;
            cbbBTYPE.Text = null;
        }

        private void UpdateComboBoxes()
        {
            // Lấy giá trị đã chọn từ cbbRCLASS
            string selectedRClass = cbbRCLASS.Text;

            // Lấy giá trị đã chọn từ cbbBTYPE
            string selectedBType = cbbBTYPE.Text;

        rooms = FileControl<CRoom>.Read("rooms.json");

        // Lọc danh sách phòng dựa trên loại phòng và loại giường đã chọn
        var filteredRooms = rooms
    .Where(r =>
        (selectedRClass == null || r.RCLASS == selectedRClass) &&
        (selectedBType == null || r.BTYPE == selectedBType))
    .ToList();

            // Lấy danh sách ID phòng từ danh sách đã lọc
            var roomIDs = filteredRooms.Select(r => r.IDRoom).ToList();

            // Cập nhật Items cho ComboBox IDRoom
            cbbIDRoom.DataSource = roomIDs;




        }

        private void UpdatePrice()
        {

            foreach (CRoom r in rooms)
            {
                if (r.IDRoom == cbbIDRoom.Text)
                {
                    txtPrice.Text = r.GetPrice().ToString();
                    return;
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    // làm việc với idRoom
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


                    customers.Add(customer);

                    CCheck check = new CCheck(dtpCheckIn.Value, customer, room.IDRoom, room.Price);

                    checks.Add(check);

                    FileControl<CCustomer>.Write(customers, "customers.json");
                    FileControl<CCheck>.Write(checks, "checks.json");

                    //room statut
                    foreach (CRoom r in rooms)
                    {
                        if (r.IDRoom == cbbIDRoom.Text)
                        {
                            r.Hired = true;
                            return;
                        }
                    }
                    FileControl<CRoom>.Write(rooms, "rooms.json");

                    //end
                    MessageBox.Show("Đặt phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            rooms = FileControl<CRoom>.Read("rooms.json");
            UpdateComboBoxItems();
        }

        private void cbbIDRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void cbbBTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRCLASS.Text != null)
            {
                UpdateComboBoxes();
            }
            else
            {
                // Cập nhật Items cho ComboBox cbbRCLASS
                var rClassList = rooms.Select(r => r.RCLASS).Distinct().ToList();
                cbbRCLASS.DataSource = rClassList;
            }
        }

        private void cbbRCLASS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBTYPE.Text != null)
            {
                UpdateComboBoxes();
            }
            else
            {
                // Cập nhật Items cho ComboBox cbbBTYPE
                var bTypeList = rooms.Select(r => r.BTYPE).Distinct().ToList();
                cbbBTYPE.DataSource = bTypeList;
            }
        }
    }
}
//private void UpdateIDRoomComboBox(string selectedRClass, string selectedBType)
//{
//    // Lọc danh sách phòng dựa trên loại phòng và loại giường đã chọn
//    var filteredRooms = rooms
//        .Where(r => r.RCLASS == selectedRClass && r.BTYPE == selectedBType)
//        .ToList();

//    // Lấy danh sách ID phòng từ danh sách đã lọc
//    var roomIDs = filteredRooms.Select(r => r.IDRoom).ToList();

//    // Cập nhật Items cho ComboBox
//    cbbIDRoom.DataSource = roomIDs;
//}

//private Boolean ValidateInput()
//{
//    //Conditions: Empty value
//    if (txtName.Text == ""
//        || txtPhone.Text == ""
//        || txtNationality.Text == ""
//        || txtAddress.Text == ""
//        || txtCCCD.Text == ""
//        || cbbBTYPE.Text == ""
//        || cbbRCLASS.Text == ""
//        || cbbIDRoom.Text == ""
//        || txtPrice.Text == "")
//    {
//        MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }
//    //Conditions: Date Checkin
//    if (DateTime.Compare(dtpCheckIn.Value, DateTime.Now) == -1)
//    {
//        MessageBox.Show("lỗi ngày check in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }
//    //Conditions: Date Of Birth
//    int age = (DateTime.Now.Date - dtpBirth.Value.Date).Days;
//    if (age < (18 * 365.25))
//    {
//        MessageBox.Show("Chưa đủ 18 tuổi !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }

//    //Conditions: Name
//    bool flag = false; 
//    foreach (char c in txtName.Text)
//    {
//        if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
//        {
//            flag = true;
//            break;
//        }
//    }
//    if (flag)
//    {
//        MessageBox.Show("Lỗi Name !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }

//    //Conditions: Nationality
//    flag = false;
//    foreach (char c in txtNationality.Text)
//    {
//        if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
//        {
//            flag = true;
//            break;
//        }
//    }
//    if (flag)
//    {
//        MessageBox.Show("Lỗi Nationality !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }

//    //Conditions: Address
//    flag = false;
//    foreach (char c in txtAddress.Text)
//    {
//        if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
//        {
//            flag = true;
//            break;
//        }
//    }
//    if (flag)
//    {
//        MessageBox.Show("Lỗi address !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }
//    //Conditions: ID Customer
//    if (!Regex.IsMatch(txtPhone.Text, @"^\d{9,12}$"))
//    {
//        MessageBox.Show("Lỗi Phone ID Customer !!!\nCó 9 hoặc 12 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }
//    //Conditions: Phone Number
//    if (!Regex.IsMatch(txtPhone.Text, @"^\d{10,11}$"))
//    {
//        MessageBox.Show("Lỗi Phone Number !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return false;
//    }
//    return true;
//}