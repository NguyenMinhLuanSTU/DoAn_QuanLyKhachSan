using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
       
        private bool Condition()
        {
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
                    r.Rent = false;
                    return;
                }
            }
        }
        private void Updatecheck(string IDRoom)
        {
            foreach (CCheck c in checks)
            {
                if (c.IdRoom == IDRoom && c.CheckOut == null)
                {
                    c.SetCheckOut(dtpCheckOut.Value);
                    c.pay = c.CheckPay();
                    return;
                }
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvPay.SelectedRows.Count > 0)
            {
                if (Condition())
                {
                    string idRoom = dgvPay.SelectedRows[0].Cells[4].Value.ToString();
                    CCheck rs = checks.Find(c => c.IdRoom == idRoom);
                    int row = dgvPay.SelectedRows[0].Index;

                    rs.SetCheckOut(dtpCheckOut.Value);
                    Bill b = new Bill(rs);

                    if (b.ShowDialog() == DialogResult.Yes)
                    {
                        UpdateRoom(rs.IdRoom);

                        Updatecheck(rs.IdRoom);

                        FileControl<CCheck>.Write(checks, "checks.json");
                        FileControl<CRoom>.Write(rooms, "rooms.json");
                        dgvUpdate();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hoá đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
