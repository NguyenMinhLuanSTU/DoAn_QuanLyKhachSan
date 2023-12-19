using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.User_Control
{
    public partial class UC_BookRoom : UserControl
    {
        public static List<CCustomer> customers;
        public static List<CCheck> checks;
        public static List<CRoom> rooms;
        public static List<string> province;
        public static List<string> countries;
        public List<String> ids;
        public UC_BookRoom()
        {
            InitializeComponent();
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

        private bool isNumber(string itring, int length)
        {
            if (itring.Length == length)
            {
                foreach (var i in itring)
                {
                    if (i - '0' > 10)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
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
                || string.IsNullOrWhiteSpace(cbbNationality.Text)
                || string.IsNullOrWhiteSpace(cbbAddress.Text)
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
            if (!IsStringValid(cbbNationality.Text))
            {
                MessageBox.Show("Lỗi Nationality !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Conditions: Phone Number
            if (!isNumber(txtPhone.Text, 10))
            {
                MessageBox.Show("Lỗi Phone Number!!! \n - Có 10 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Conditions: ID Customer
            if (!isNumber(txtCCCD.Text, 12))
            {
                MessageBox.Show("Lỗi ID Customer !!!\n - Có 12 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var distinctRClasses = rooms.Select(r => r.RoomClass).Distinct().ToList();
            var distinctBTypes = rooms.Select(r => r.BedType).Distinct().ToList();
            // Cập nhật Items cho ComboBox
            cbbIDRoom.DataSource = distinctIDRoom;
            cbbRCLASS.DataSource = distinctRClasses;
            cbbBTYPE.DataSource = distinctBTypes;
            cbbAddress.DataSource = province;
            cbbNationality.DataSource = countries;

            cbbIDRoom.Text = null;
            cbbRCLASS.Text = null;
            cbbBTYPE.Text = null;
            cbbAddress.Text = null;
        }

        private void UpdateCbbIDRoom()
        {
            rooms = FileControl<CRoom>.Read("rooms.json");

            string selectedRClass = cbbRCLASS.Text;
            string selectedBType = cbbBTYPE.Text;
            // Lọc danh sách phòng dựa trên loại phòng và loại giường đã chọn và cả trạng thái thuê hiện tại
            var filteredRooms = rooms.Where(
                r => (selectedRClass == null || r.RoomClass == selectedRClass) && (selectedBType == null || r.BedType == selectedBType) && !r.Rent
            ).ToList();

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


                    if (cbbBTYPE.Text != room.BedType || cbbRCLASS.Text != room.RoomClass)
                    {
                        MessageBox.Show("Phòng không đúng ID", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Làm việc với customer
                    CCustomer customer = new CCustomer(txtName.Text, txtPhone.Text, cbbNationality.Text, dtpBirth.Value, cbbAddress.Text, txtCCCD.Text);

                    //kiểm tra CCCD với kho lưu trữ class
                    foreach (CCustomer ctm in customers)
                    {
                        if (ctm.CCCD == customer.CCCD)
                        {
                            MessageBox.Show("Người nãy đã đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    //room statut
                    foreach (CRoom r in rooms)
                    {
                        if (r.IDRoom == cbbIDRoom.Text)
                        {
                            if (r.Rent)
                            {
                                MessageBox.Show("Phòng đã được đặt!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            r.Rent = true;
                        }
                    }

                    customers.Add(customer);
                    CCheck check = new CCheck(dtpCheckIn.Value, customer, room.IDRoom, room.Price);
                    checks.Add(check);

                    FileControl<CCustomer>.Write(customers, "customers.json");
                    FileControl<CCheck>.Write(checks, "checks.json");
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
            checks = FileControl<CCheck>.Read("checks.json");
            rooms = FileControl<CRoom>.Read("rooms.json");
            province = FileControl<string>.Read("63province.json");
            countries = FileControl<string>.Read("196countries.json");
            dtpBirth.Value = DateTime.Now.Date;
            dtpCheckIn.Value = DateTime.Now.Date;
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
                UpdateCbbIDRoom();
            }
            else
            {
                var rClassList = rooms.Select(r => r.RoomClass).Distinct().ToList();
                cbbRCLASS.DataSource = rClassList;
            }
        }

        private void cbbRCLASS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBTYPE.Text != null)
            {
                UpdateCbbIDRoom();
            }
            else
            {
                var bTypeList = rooms.Select(r => r.BedType).Distinct().ToList();
                cbbBTYPE.DataSource = bTypeList;
            }
        }
    }
}
