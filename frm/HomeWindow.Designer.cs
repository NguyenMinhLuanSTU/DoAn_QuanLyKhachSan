namespace WindowsFormsApp1
{
    partial class HomeWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWindow));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDisplayName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomsControl = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.uC_BookRoom1 = new WindowsFormsApp1.User_Control.UC_BookRoom();
            this.uC_Home1 = new WindowsFormsApp1.User_Control.UC_Home();
            this.uC_Pay = new WindowsFormsApp1.User_Control.UC_Pay();
            this.uC_AddRoom1 = new WindowsFormsApp1.User_Control.uc_AddRoom();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.navbar;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.lblDisplayName);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox10);
            this.guna2Panel1.Controls.Add(this.picbClose);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox9);
            this.guna2Panel1.Controls.Add(this.picClose);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox8);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox7);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnPayment);
            this.guna2Panel1.Controls.Add(this.btnBooking);
            this.guna2Panel1.Controls.Add(this.btnRoomsControl);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.btnHome);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(387, 800);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayName.Location = new System.Drawing.Point(81, 746);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(132, 19);
            this.lblDisplayName.TabIndex = 19;
            this.lblDisplayName.Text = "ACCOUNT LOGIN";
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox10.BackgroundImage")));
            this.guna2PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox10.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(36, 4);
            this.guna2PictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(20, 31);
            this.guna2PictureBox10.TabIndex = 18;
            this.guna2PictureBox10.TabStop = false;
            this.guna2PictureBox10.Click += new System.EventHandler(this.guna2PictureBox10_Click);
            // 
            // picbClose
            // 
            this.picbClose.BackColor = System.Drawing.Color.Transparent;
            this.picbClose.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close1;
            this.picbClose.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.picbClose.ImageRotate = 0F;
            this.picbClose.Location = new System.Drawing.Point(3, 4);
            this.picbClose.Margin = new System.Windows.Forms.Padding(4);
            this.picbClose.Name = "picbClose";
            this.picbClose.Size = new System.Drawing.Size(31, 28);
            this.picbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbClose.TabIndex = 17;
            this.picbClose.TabStop = false;
            this.picbClose.Click += new System.EventHandler(this.picbClose_Click);
            // 
            // guna2PictureBox9
            // 
            this.guna2PictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2PictureBox9.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Location = new System.Drawing.Point(35, 4);
            this.guna2PictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.Size = new System.Drawing.Size(25, 30);
            this.guna2PictureBox9.TabIndex = 14;
            this.guna2PictureBox9.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.FillColor = System.Drawing.Color.Transparent;
            this.picClose.ImageRotate = 0F;
            this.picClose.Location = new System.Drawing.Point(3, 4);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 30);
            this.picClose.TabIndex = 13;
            this.picClose.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(27, 718);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(333, 1);
            this.guna2TextBox1.TabIndex = 11;
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox8.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.I;
            this.guna2PictureBox8.ImageRotate = 0F;
            this.guna2PictureBox8.Location = new System.Drawing.Point(295, 729);
            this.guna2PictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.Size = new System.Drawing.Size(24, 55);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox8.TabIndex = 10;
            this.guna2PictureBox8.TabStop = false;
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox7.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(325, 743);
            this.guna2PictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(27, 26);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox7.TabIndex = 10;
            this.guna2PictureBox7.TabStop = false;
            this.guna2PictureBox7.Click += new System.EventHandler(this.guna2PictureBox7_Click);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.booking_payment;
            this.guna2PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(33, 559);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(27, 25);
            this.guna2PictureBox4.TabIndex = 10;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.customer;
            this.guna2PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(33, 487);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(28, 26);
            this.guna2PictureBox3.TabIndex = 10;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.home;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(32, 338);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(31, 28);
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnPayment.BorderRadius = 9;
            this.btnPayment.BorderThickness = 1;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.FillColor = System.Drawing.Color.Transparent;
            this.btnPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPayment.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.btnPayment.Location = new System.Drawing.Point(75, 549);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.PressedColor = System.Drawing.Color.Transparent;
            this.btnPayment.Size = new System.Drawing.Size(163, 42);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnBooking.BorderRadius = 9;
            this.btnBooking.BorderThickness = 1;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.Color.Transparent;
            this.btnBooking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBooking.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.btnBooking.Location = new System.Drawing.Point(75, 479);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.PressedColor = System.Drawing.Color.Transparent;
            this.btnBooking.Size = new System.Drawing.Size(227, 42);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "BOOKING ROOM";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnRoomsControl
            // 
            this.btnRoomsControl.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomsControl.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnRoomsControl.BorderRadius = 9;
            this.btnRoomsControl.BorderThickness = 1;
            this.btnRoomsControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomsControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomsControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomsControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomsControl.FillColor = System.Drawing.Color.Transparent;
            this.btnRoomsControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomsControl.ForeColor = System.Drawing.Color.White;
            this.btnRoomsControl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoomsControl.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.btnRoomsControl.Location = new System.Drawing.Point(73, 406);
            this.btnRoomsControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomsControl.Name = "btnRoomsControl";
            this.btnRoomsControl.PressedColor = System.Drawing.Color.Transparent;
            this.btnRoomsControl.Size = new System.Drawing.Size(245, 42);
            this.btnRoomsControl.TabIndex = 5;
            this.btnRoomsControl.Text = "ROOMS CONTROL";
            this.btnRoomsControl.Click += new System.EventHandler(this.btnRoomsControl_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.NavajoWhite;
            this.guna2Button4.BorderRadius = 9;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.guna2Button4.Location = new System.Drawing.Point(1337, 235);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Size = new System.Drawing.Size(113, 42);
            this.guna2Button4.TabIndex = 4;
            this.guna2Button4.Text = "HOME";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btnHome.BorderRadius = 9;
            this.btnHome.BorderThickness = 1;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.Location = new System.Drawing.Point(73, 332);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.Transparent;
            this.btnHome.Size = new System.Drawing.Size(119, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // uC_BookRoom1
            // 
            this.uC_BookRoom1.BackColor = System.Drawing.Color.White;
            this.uC_BookRoom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_BookRoom1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uC_BookRoom1.Location = new System.Drawing.Point(387, 0);
            this.uC_BookRoom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_BookRoom1.Name = "uC_BookRoom1";
            this.uC_BookRoom1.Size = new System.Drawing.Size(1081, 800);
            this.uC_BookRoom1.TabIndex = 7;
            this.uC_BookRoom1.Visible = false;
            this.uC_BookRoom1.Load += new System.EventHandler(this.uC_BookRoom1_Load);
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Home1.BackgroundImage")));
            this.uC_Home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_Home1.Location = new System.Drawing.Point(387, 0);
            this.uC_Home1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1081, 800);
            this.uC_Home1.TabIndex = 5;
            // 
            // uC_Pay
            // 
            this.uC_Pay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Pay.Location = new System.Drawing.Point(387, 0);
            this.uC_Pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Pay.Name = "uC_Pay";
            this.uC_Pay.Size = new System.Drawing.Size(1081, 800);
            this.uC_Pay.TabIndex = 4;
            this.uC_Pay.Visible = false;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_AddRoom1.Location = new System.Drawing.Point(385, 0);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1081, 800);
            this.uC_AddRoom1.TabIndex = 6;
            this.uC_AddRoom1.Visible = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.room;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(32, 411);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(27, 25);
            this.guna2PictureBox2.TabIndex = 20;
            this.guna2PictureBox2.TabStop = false;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 800);
            this.Controls.Add(this.uC_BookRoom1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.uC_Home1);
            this.Controls.Add(this.uC_Pay);
            this.Controls.Add(this.uC_AddRoom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWindow";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox9;
        private Guna.UI2.WinForms.Guna2PictureBox picClose;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2Button btnRoomsControl;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox10;
        private Guna.UI2.WinForms.Guna2PictureBox picbClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDisplayName;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private User_Control.UC_BookRoom uc_BookRoom;
        private User_Control.UC_Pay uC_Pay;
        private User_Control.uc_AddRoom uC_AddRoom;
        private User_Control.UC_Home uC_Home1;
        private User_Control.uc_AddRoom uC_AddRoom1;
        private User_Control.UC_BookRoom uC_BookRoom1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}