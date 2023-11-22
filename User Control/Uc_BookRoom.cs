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
using System.Web.Security;
using System.Windows.Forms;

namespace WindowsFormsApp1.User_Control
{
    public partial class Uc_BookRoom : UserControl
    {
        public List<CCostomer> costomers;
        public List<CCheck> checks;
        public List<CRoom> rooms;
        public List<String> ids;
        public Uc_BookRoom()
        {
            InitializeComponent();
        }
        //Chưa xong phần cập nhật liên tục
        protected override void OnPaint(PaintEventArgs e)
        {

            double money = 1.0;
            if (cbbBTYPE.Text == "Double") money *= 1.5;
            if (cbbBTYPE.Text == "Triple") money *= 2;
            if (cbbRCLASS.Text == "Business Class") money *= 2;
            if (cbbRCLASS.Text == "VIP") money *= 5;

            txtPrice.Text = money.ToString();
            //cbbIDRoom.Items.AddRange(ids);
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (txtName.Text != ""
                && txtPhone.Text != ""
                && txtNationality.Text != ""
                && txtAddress.Text != ""
                && txtCCCD.Text != ""
                && cbbBTYPE.Text != ""
                && cbbRCLASS.Text != ""
                && cbbIDRoom.Text != ""
                && txtPrice.Text != "")
            {
                //điều kiện của date
                if (DateTime.Compare(dtpCheckIn.Value, DateTime.Now) == -1) {
                    MessageBox.Show("lỗi ngày check in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DateTime.Compare(dtpBirth.Value, DateTime.Now) > -1)
                {
                    MessageBox.Show("lỗi ngày sinh, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // làm việc với room
                CRoom room = new CRoom();
                //Đọc rooms.json
                string jsonrm = File.ReadAllText(@"D:\studyNam\projs\DoAn\QLKS\Data\rooms.json");
                rooms = JsonConvert.DeserializeObject<List<CRoom>>(jsonrm);
                //tìm kiếm phòng
                foreach (CRoom r in rooms)
                {
                    if (r.IDRoom == cbbIDRoom.Text)
                    {
                        room = r;
                        break;
                    }
                }
                if (cbbBTYPE.Text != room.BTYPE || cbbRCLASS.Text != room.RCLASS)
                {
                    MessageBox.Show("Phòng không đúng ID", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                // Làm việc với costomer
                //Đọc costomer json
                string jsonCtm = File.ReadAllText(@"D:\studyNam\projs\DoAn\QLKS\Data\costomers.json");
                costomers = JsonConvert.DeserializeObject<List<CCostomer>>(jsonCtm);
                //add dữ liệu hiện có vào class
                CCostomer costomer = new CCostomer(txtName.Text, txtPhone.Text, txtNationality.Text, dtpBirth.Value, txtAddress.Text, txtCCCD.Text);

                //kiểm tra CCCD với kho lưu trữ class
                foreach (CCostomer ctm in costomers)
                {
                    if (ctm.CCCD == costomer.CCCD)
                    {
                        // Hiển thị thông báo
                        MessageBox.Show("Người nãy đã ở trong kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //add
                costomers.Add(costomer);
                // ghi nội dung vào json
                jsonCtm = JsonConvert.SerializeObject(costomers);
                File.WriteAllText(@"D:\studyNam\projs\DoAn\QLKS\Data\costomers.json", jsonCtm);


                //Làm việc với check
                //Đọc check json
                //string jsonChk = File.ReadAllText(@"D:\studyNam\projs\DoAn\QLKS\Data\checks.json");
                //checks = JsonConvert.DeserializeObject<List<CCheck>>(jsonChk);
                ////add dữ liệu hiện có vào class
                //CCheck check = new CCheck(dtpCheckIn.Value,costomer,room);
                //// ghi nội dung vào json
                //jsonChk = JsonConvert.SerializeObject(check);
                //File.WriteAllText(@"D:\studyNam\projs\DoAn\QLKS\Data\checks.json", jsonChk);

            }
            else
            {
                MessageBox.Show("Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
