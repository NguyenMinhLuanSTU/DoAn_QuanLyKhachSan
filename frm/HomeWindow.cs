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
            guna2DragControl1.SetDrag(uC_BookRoom1);
            guna2DragControl1.SetDrag(uC_AddRoom1);
            guna2DragControl1.SetDrag(uC_Home1);
            guna2DragControl1.SetDrag(uC_Pay);

        }
        private void hideAllUC()
        {
            uC_AddRoom1.Visible = false;
            uC_BookRoom1.Visible = false;
            uC_Home1.Visible = false;
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


        private void btnPayment_Click(object sender, EventArgs e)
        {
            uC_Pay.ReloadData();
            hideAllUC();
            uC_Pay.Visible = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideAllUC();
            uC_Home1.Visible = true;
        }

        private void btnRoomsControl_Click(object sender, EventArgs e)
        {
            hideAllUC();
            uC_AddRoom1.Visible = true;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            hideAllUC();
            uC_BookRoom1.Visible = true;
            UC_BookRoom.rooms = uc_AddRoom.rooms; 
        }

        private void uC_BookRoom1_Load(object sender, EventArgs e)
        {

        }
    }
}
