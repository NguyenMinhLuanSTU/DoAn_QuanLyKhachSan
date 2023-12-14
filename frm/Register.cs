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

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static List<CUser> users;

        private void Register_Load(object sender, EventArgs e)
        {
            users = FileControl<CUser>.Read("users.json");
        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picEyeclose_Click(object sender, EventArgs e)
        {
            if (!(txtPassword.UseSystemPasswordChar))
            {
                txtPassword.PasswordChar = '*';
                picEyeclose.Image = Properties.Resources.eye_open;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                picEyeclose.Image = Properties.Resources.closed_eye;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void lbSignin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CUser newUser = new CUser(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            foreach (CUser u in users)
            {
                if (u.Username == txtUsername.Text)
                {
                    MessageBox.Show("Username đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            users.Add(newUser);
            FileControl<CUser>.Write(users,"users.json");
            Login lg = new Login();
            lg.Show();
            this.Close();
        }


    }
}
