using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.User_Control
{
    public partial class uc_AddRoom : UserControl
    {
        public static List<CRoom> rooms = FileControl<CRoom>.Read("rooms.json");

        public uc_AddRoom()
        {
            InitializeComponent();
        }
        private void moneyChanged()
        {
            //luôn cập nhật giá trị cho price
            double money = 1.0;
            if (cbbBTYPE.Text == "Đôi") money *= 1.5;
            if (cbbBTYPE.Text == "Ba") money *= 2;
            if (cbbRCLASS.Text == "Thương gia") money *= 2;
            if (cbbRCLASS.Text == "VIP") money *= 5;
            txtPrice.Text = money.ToString();
        }
        private void dgvUpdate()
        {
            dgvAddRoom.DataSource = null;
            if (rooms == null) return;
            rooms = rooms.OrderBy(r => r.IDRoom).ToList();
            dgvAddRoom.DataSource = rooms;
        }
        private void resetText()
        {
            txtIDRoom.Text = "";
            txtPrice.Text = "";
            cbbBTYPE.Text = "";
            cbbRCLASS.Text = "";
        }
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
            if (rooms != null)
            {
                foreach (CRoom r in rooms)
                {
                    if (r.IDRoom == room.IDRoom)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            rooms.Add(room);

            //Đưa dữ liệu vào DataGridView
            dgvUpdate();
            dgvAddRoom.Update();
            resetText();
            
            FileControl<CRoom>.Write(rooms, "rooms.json");
            MessageBox.Show("Cập nhật thành công", "ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddRoom.SelectedRows.Count > 0)
            {
                int row = dgvAddRoom.SelectedRows[0].Index;

                bool isRoomHired = (bool)dgvAddRoom.Rows[row].Cells["Rent"].Value;
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

    }
}
