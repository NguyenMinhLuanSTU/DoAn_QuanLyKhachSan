﻿using Guna.UI2.WinForms;
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
    public partial class Login : Form
    {
        public static List<CUser> users;

        public Login()
        {
            InitializeComponent();
            guna2DragControl1.SetDrag(pnlMainLeft);
            guna2DragControl1.SetDrag(picbwelcom);
        }
        public Login(string userName)
        {
            InitializeComponent();
            guna2DragControl1.SetDrag(pnlMainLeft);
            guna2DragControl1.SetDrag(picbwelcom);
            txtUsername.Text = userName;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlMainLeft = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picEyeclose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMainRight = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbwelcom = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlMainLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlMainRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbwelcom)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlMainLeft
            // 
            this.pnlMainLeft.Controls.Add(this.guna2PictureBox3);
            this.pnlMainLeft.Controls.Add(this.picbClose);
            this.pnlMainLeft.Controls.Add(this.picEyeclose);
            this.pnlMainLeft.Controls.Add(this.label4);
            this.pnlMainLeft.Controls.Add(this.btnSignIn);
            this.pnlMainLeft.Controls.Add(this.guna2CustomGradientPanel2);
            this.pnlMainLeft.Controls.Add(this.guna2HtmlLabel4);
            this.pnlMainLeft.Controls.Add(this.guna2HtmlLabel2);
            this.pnlMainLeft.Controls.Add(this.guna2HtmlLabel5);
            this.pnlMainLeft.Controls.Add(this.guna2PictureBox2);
            this.pnlMainLeft.Controls.Add(this.guna2PictureBox1);
            this.pnlMainLeft.Controls.Add(this.txtPassword);
            this.pnlMainLeft.Controls.Add(this.txtUsername);
            this.pnlMainLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLeft.Name = "pnlMainLeft";
            this.pnlMainLeft.Size = new System.Drawing.Size(398, 500);
            this.pnlMainLeft.TabIndex = 1;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.BackgroundImage")));
            this.guna2PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(27, 3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(15, 25);
            this.guna2PictureBox3.TabIndex = 16;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // picbClose
            // 
            this.picbClose.BackColor = System.Drawing.Color.Transparent;
            this.picbClose.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close1;
            this.picbClose.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.picbClose.ImageRotate = 0F;
            this.picbClose.Location = new System.Drawing.Point(2, 3);
            this.picbClose.Name = "picbClose";
            this.picbClose.Size = new System.Drawing.Size(23, 23);
            this.picbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbClose.TabIndex = 9;
            this.picbClose.TabStop = false;
            this.picbClose.Click += new System.EventHandler(this.picbClose_Click);
            // 
            // picEyeclose
            // 
            this.picEyeclose.BackColor = System.Drawing.Color.Transparent;
            this.picEyeclose.Image = global::WindowsFormsApp1.Properties.Resources.closed_eye;
            this.picEyeclose.ImageRotate = 0F;
            this.picEyeclose.Location = new System.Drawing.Point(331, 252);
            this.picEyeclose.Name = "picEyeclose";
            this.picEyeclose.Size = new System.Drawing.Size(17, 23);
            this.picEyeclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeclose.TabIndex = 15;
            this.picEyeclose.TabStop = false;
            this.picEyeclose.Click += new System.EventHandler(this.picEyeclose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(230, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tạo mới";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BorderRadius = 20;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSignIn.FillColor2 = System.Drawing.Color.MediumOrchid;
            this.btnSignIn.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSignIn.HoverState.FillColor = System.Drawing.Color.MediumOrchid;
            this.btnSignIn.HoverState.FillColor2 = System.Drawing.Color.Violet;
            this.btnSignIn.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(129, 334);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(171, 43);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "ĐĂNG NHẬP";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(449, 0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(399, 500);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(135, 116);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(155, 32);
            this.guna2HtmlLabel4.TabIndex = 11;
            this.guna2HtmlLabel4.Text = "Đăng nhập tài khoản";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Sitka Subheading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(125, 73);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(183, 44);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Xin chào!";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(110, 413);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(151, 31);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.Text = "Chưa có tài khoản?";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.password2;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(35, 251);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(24, 23);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.username3;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(35, 187);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 25);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(67, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(298, 37);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(67, 180);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(298, 37);
            this.txtUsername.TabIndex = 0;
            // 
            // pnlMainRight
            // 
            this.pnlMainRight.Controls.Add(this.label3);
            this.pnlMainRight.Controls.Add(this.label2);
            this.pnlMainRight.Controls.Add(this.guna2PictureBox6);
            this.pnlMainRight.Controls.Add(this.picbwelcom);
            this.pnlMainRight.Location = new System.Drawing.Point(394, 0);
            this.pnlMainRight.Name = "pnlMainRight";
            this.pnlMainRight.Size = new System.Drawing.Size(451, 500);
            this.pnlMainRight.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHÀO MỪNG ĐẾN VỚI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.z482241;
            this.guna2PictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.z482242;
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(0, 336);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(451, 164);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox6.TabIndex = 1;
            this.guna2PictureBox6.TabStop = false;
            // 
            // picbwelcom
            // 
            this.picbwelcom.BackColor = System.Drawing.Color.Transparent;
            this.picbwelcom.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._7d0e24;
            this.picbwelcom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbwelcom.FillColor = System.Drawing.Color.Transparent;
            this.picbwelcom.ImageRotate = 0F;
            this.picbwelcom.Location = new System.Drawing.Point(0, -1);
            this.picbwelcom.Name = "picbwelcom";
            this.picbwelcom.Size = new System.Drawing.Size(454, 320);
            this.picbwelcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbwelcom.TabIndex = 0;
            this.picbwelcom.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.pnlMainRight);
            this.Controls.Add(this.pnlMainLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlMainLeft.ResumeLayout(false);
            this.pnlMainLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnlMainRight.ResumeLayout(false);
            this.pnlMainRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbwelcom)).EndInit();
            this.ResumeLayout(false);

        }
        private void Login_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            Register signup = new Register();
            this.Hide();
            signup.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                return;
            }
            CUser user = new CUser(txtUsername.Text, txtPassword.Text);
            foreach (CUser u in users)
            {
                if (u.Username == user.Username)
                {
                    if (u.Password == user.Password)
                    {
                        HomeWindow mainWindow = new HomeWindow(txtUsername.Text);
                        mainWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
            }
            MessageBox.Show("Không có tài khoản này", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
