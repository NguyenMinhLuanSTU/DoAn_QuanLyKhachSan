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
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.User_Control
{
    public partial class uc_AddRoom : UserControl
    {
        public static List<CRoom> rooms;

        public uc_AddRoom()
        {
            InitializeComponent();
        }
        private void moneyChanged()
        {
            //luôn cập nhật giá trị cho price
            double money = 1.0;
            if (cbbBTYPE.Text == "Double") money *= 1.5;
            if (cbbBTYPE.Text == "Triple") money *= 2;
            if (cbbRCLASS.Text == "Business Class") money *= 2;
            if (cbbRCLASS.Text == "VIP") money *= 5;
            txtPrice.Text = money.ToString();
        }
        private void dgvUpdate()
        {
            dgvAddRoom.DataSource = null;
            dgvAddRoom.DataSource = rooms;
        }
        private void resetText()
        {
            txtIDRoom.Text = "";
            txtPrice.Text = "";
            cbbBTYPE.Text = "";
            cbbRCLASS.Text = "";
        }
        // luôn gọi khi có sự thay đổi trong form
        protected override void OnPaint(PaintEventArgs e)
        {
            moneyChanged();
        }

        private bool IsValidRoomID(string roomID)
        {
            // Kiểm tra xem roomID có đúng định dạng hay không
            string pattern = "^[A-Z]\\d{3}$";
            return Regex.IsMatch(roomID, pattern);
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (cbbRCLASS.Text == "" || cbbBTYPE.Text == "" || txtIDRoom.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Giá trị giá phòng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidRoomID(txtIDRoom.Text))
            {
                MessageBox.Show("Mã phòng không hợp lệ. Định dạng phải là một chữ in hoa và ba số. [VD: A000]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //add dữ liệu hiện có vào class
            CRoom room = new CRoom(txtIDRoom.Text, cbbRCLASS.Text, cbbBTYPE.Text, double.Parse(txtPrice.Text), false);

            //kiểm tra id room với kho lưu trữ class
            foreach (CRoom r in rooms)
            {
                if (r.IDRoom == room.IDRoom)
                {
                    // Hiển thị thông báo
                    MessageBox.Show("Mã phòng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //if (rooms.Any(r => r.IDRoom == txtIDRoom.Text))
            //{
            //    MessageBox.Show("Mã phòng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            //add
            rooms.Add(room);

            //Đưa dữ liệu vào DataGridView
            dgvUpdate();
            resetText();
            // ghi nội dung vào json
            FileControl<CRoom>.Write(rooms, "rooms.json");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddRoom.SelectedRows.Count > 0)
            {
                int row = dgvAddRoom.SelectedRows[0].Index;
                rooms.RemoveAt(row);
                dgvUpdate();
                FileControl<CRoom>.Write(rooms, "rooms.json");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            rooms = FileControl<CRoom>.Read("rooms.json");
            dgvUpdate();
        }


        private void cbbRCLASS_TextChanged(object sender, EventArgs e)
        {
            moneyChanged();
        }

        private void cbbBTYPE_TextChanged(object sender, EventArgs e)
        {
            moneyChanged();
        }
    }
}
