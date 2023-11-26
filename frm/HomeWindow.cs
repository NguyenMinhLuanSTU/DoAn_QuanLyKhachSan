using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.User_Control;

namespace WindowsFormsApp1
{
    public partial class HomeWindow : Form
    {
        string displayName;
        public HomeWindow(string name)
        {
            InitializeComponent();
            displayName = name;
            guna2DragControl1.SetDrag(guna2Panel1);
           
        }
        private void hideAllUC()
        {
            uC_AddRoom.Visible = false;
            uc_BookRoom.Visible = false;
            uC_Pay.Visible = false;
        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = displayName;
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void btnBookingandpayment_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            hideAllUC();
            uc_BookRoom.Visible = true;
        }

        private void btnRoommanagerment_Click(object sender, EventArgs e)
        {

            hideAllUC();
            uC_AddRoom.Visible = true;

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            hideAllUC();
            uC_Pay.Visible = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
