using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.frm;

namespace WindowsFormsApp1.User_Control
{
    public partial class UC_Pay : UserControl
    {
        public static List<CCheck> checks;
        public static List<CRoom> rooms;
        public UC_Pay()
        {
            InitializeComponent();
        }

        public void ReloadData()
        {
            checks = FileControl<CCheck>.Read("checks.json");
            rooms = FileControl<CRoom>.Read("rooms.json");
            dgvUpdate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            checks = FileControl<CCheck>.Read("checks.json");
        }

        private bool Condition()
        {
            //Conditions: Date Checkin
            if (DateTime.Compare(dtpCheckOut.Value.Date, DateTime.Now.Date) == -1 || DateTime.Compare(dtpCheckOut.Value.Date, DateTime.Now.Date) == -1)
            {
                MessageBox.Show("Lỗi ngày check in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void dgvUpdate()
        {
            var filter = checks.Where(check => check.CheckOut == null).ToList();

            dgvPay.DataSource = filter;
        }
        private void UpdateRoom(string IDRoom)
        {
            foreach (CRoom r in rooms)
            {
                if (r.IDRoom == IDRoom)
                {
                    r.Hired = false;
                    return;
                }
            }
            FileControl<CRoom>.Write(rooms, "rooms.json");

        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            //if (dgvPay.SelectedRows.Count > 0)
            //{
            //    int row = dgvPay.SelectedRows[0].Index;
            //    //Bill bill = new Bill();
            //    //bill.Show();
            //    UpdateRoom((string)dgvPay.Rows[row].Cells["Column1"].Value);
            //    dgvUpdate();
            //    FileControl<CCheck>.Write(checks, "checks.json");
            //}

            if (dgvPay.SelectedRows.Count > 0)
            {
                string idRoom = dgvPay.SelectedRows[0].Cells[4].Value.ToString();
                CCheck rs = checks.Find(c => c.IdRoom == idRoom);
                int row = dgvPay.SelectedRows[0].Index;

                rs.SetCheckOut(dtpCheckOut.Value);//Dua gia tri checkout vo
                                                  //Truyen thang dang chon vo form
                Bill b = new Bill(rs);

                if (b.ShowDialog() == DialogResult.Yes)
                {
                    UpdateRoom((string)dgvPay.Rows[row].Cells["Column1"].Value);
                    //FileControl<CCheck>.Write(checks, "checks.json");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hoá đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
