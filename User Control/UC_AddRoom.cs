using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        public List<CRoom> rooms;
        //public List<int> list;

        public UC_AddRoom()
        {
            InitializeComponent();

            //list = new List<int>();
            using (StreamReader reader = new StreamReader(@"D:\Test@ABCD\Data\rooms.json"))
            {
                while (!reader.EndOfStream)
                {
                    string json = reader.ReadToEnd();
                    rooms = JsonConvert.DeserializeObject<List<CRoom>>(json);
                }
            }
            dgvAddRoom.DataSource = rooms;
            btnDelete.Click += new EventHandler(btnDelete_Click);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //đưa data trong file json vào dgv
            dgvAddRoom.DataSource = JsonConvert.DeserializeObject<List<CRoom>>(File.ReadAllText(@"D:\Test@ABCD\Data\rooms.json"));

            //luôn cập nhật giá trị cho price
            double money = 1.0;
            if (cbbBTYPE.Text == "Double") money *= 1.5;
            if (cbbBTYPE.Text == "Triple") money *= 2;
            if (cbbRCLASS.Text == "Business Class") money *= 2;
            if (cbbRCLASS.Text == "VIP") money *= 5;

            txtPrice.Text = money.ToString();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (cbbRCLASS.Text != "" && cbbBTYPE.Text != "" && txtIDRoom.Text != "" && txtPrice.Text != "")
            {
                //Đọc json
                string json = File.ReadAllText(@"D:\Test@ABCD\Data\rooms.json");
                rooms = JsonConvert.DeserializeObject<List<CRoom>>(json);

                //add dữ liệu hiện có vào class
                CRoom room = new CRoom(txtIDRoom.Text, cbbRCLASS.Text, cbbBTYPE.Text, txtPrice.Text, false);


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

                //add
                rooms.Add(room);


                // ghi nội dung vào json
                json = JsonConvert.SerializeObject(rooms);
                File.WriteAllText(@"D:\Test@ABCD\Data\rooms.json", json);

                //Đưa dữ liệu ra DataGridView
                dgvAddRoom.DataSource = rooms;


            }
            else
            {
                MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = dgvAddRoom.SelectedRows[0].Index;
            rooms.RemoveAt(row);
            using (StreamWriter writer = new StreamWriter(@"D:\Test@ABCD\Data\rooms.json"))
            {
                string json = JsonConvert.SerializeObject(rooms);
                writer.Write(json);
            }
        }
    }
}
