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

namespace WindowsFormsApp1.User_Control
{
    public partial class UC_Pay : UserControl
    {
        public static List<CCheck> checks = FileControl<CCheck>.Read("checks.json");
        public static List<CRoom> rooms = FileControl<CRoom>.Read("rooms.json");
        public UC_Pay()
        {
            InitializeComponent();
        }
        private bool Condition()
        {
            //Conditions: Date Checkin
            if (DateTime.Compare(dtpCheckOut.Value, DateTime.Now) == -1 || DateTime.Compare(dtpCheckOut.Value, DateTime.Now) == -1)
            {
                MessageBox.Show("Lỗi ngày check in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void dgvUpdate()
        {
            dgvPay.DataSource = null;
            dgvPay.DataSource = checks;
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
            if (dgvPay.SelectedRows.Count > 0)
            {
                int row = dgvPay.SelectedRows[0].Index;
                dgvUpdate();
                //UpdateRoom();
                FileControl<CCheck>.Write(checks, "rooms.json");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hoá đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIDRoom_TextChanged(object sender, EventArgs e)
        {
            //lList<CCheck> lc = 
        }
    }
}
