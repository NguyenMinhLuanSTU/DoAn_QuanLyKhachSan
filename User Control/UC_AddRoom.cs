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

            //kiểm tra id idRoom với kho lưu trữ class
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
            dgvAddRoom.Update();

            resetText();
            // ghi nội dung vào json
            FileControl<CRoom>.Write(rooms, "rooms.json");
            MessageBox.Show("Cập nhật thành công", "ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddRoom.SelectedRows.Count > 0)
            {
                int row = dgvAddRoom.SelectedRows[0].Index;

                bool isRoomHired = (bool)dgvAddRoom.Rows[row].Cells["Column5"].Value;
                if (isRoomHired)
                {
                    MessageBox.Show("Phòng đang được thuê, không thể xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Xác nhận xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rooms.RemoveAt(row);
                    dgvUpdate();
                    dgvAddRoom.Update();

                    FileControl<CRoom>.Write(rooms, "rooms.json");
                    MessageBox.Show("Cập nhật thành công", "ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            if (cbbRCLASS.Focused)  
            {
                moneyChanged();
            }
        }

        private void cbbBTYPE_TextChanged(object sender, EventArgs e)
        {
            if (cbbBTYPE.Focused)  
            {
                moneyChanged();
            }
        }

        private void dgvAddRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value)
                return;

            var columnName = dgvAddRoom.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "Column2":
                    if (e.Value is string)
                    {
                        string value = (string)e.Value;
                        e.Value = GetRoomTypeDisplayName(value);
                        e.FormattingApplied = true;
                    }
                    break;

                case "Column3":
                    if (e.Value is string)
                    {
                        string value = (string)e.Value;
                        e.Value = GetBedTypeDisplayName(value);
                        e.FormattingApplied = true;
                    }
                    break;

                case "Column4":
                    if (e.Value is double)
                    {
                        double value = (double)e.Value * 1000000;
                        string formattedValue = value.ToString("N0") + " VND";
                        e.Value = formattedValue;
                        e.FormattingApplied = true;
                    }
                    break;

                case "Column5":
                    if (e.Value is bool)
                    {
                        bool value = (bool)e.Value;
                        e.Value = value ? "Có Người" : "Không Người";
                        e.FormattingApplied = true;
                    }
                    break;
            }
        }
        private string GetRoomTypeDisplayName(string roomType)
        {
            switch (roomType)
            {
                case "VIP":
                    return "VIP";
                case "Business Class":
                    return "Thương gia";
                case "Economy Class":
                    return "Bình dân";
                default:
                    return roomType;
            }
        }
        private string GetBedTypeDisplayName(string bedType)
        {
            switch (bedType)
            {
                case "Single":
                    return "Đơn";
                case "Double":
                    return "Đôi";
                case "Triple":
                    return "BA";
                default:
                    return bedType;
            }
        }
    }
}
