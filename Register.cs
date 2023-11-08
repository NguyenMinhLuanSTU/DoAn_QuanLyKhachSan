﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
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
            CUser newUser = new CUser();
            newUser.Username = txtUsername.Text;
            newUser.Email = txtEmail.Text;
            newUser.Password = txtPassword.Text;
            var users = UserData.getAllUser();
            
            if (users.Find(u => string.Compare(u.Username,newUser.Username) == 0) == null)
            {
                users.Add(newUser);
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
         }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}