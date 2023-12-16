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
namespace WindowsFormsApp1.frm
{
    public partial class Bill : Form
    {
        private CCheck _bill;
        public Bill(CCheck b)
        {
            InitializeComponent();
            _bill = b;
        }
        
        private void Bill_Load(object sender, EventArgs e)
        {
            txtAddress.Text = _bill.customer.Address.ToString();
            txtCCCD.Text = _bill.customer.CCCD.ToString();
            txtCustomerName.Text = _bill.customer.CustomerName.ToString();
            txtPhoneNumber.Text = _bill.customer.PhoneNumber.ToString();
            txtPrice.Text = _bill.price.ToString();
            dtpCheckIn.Value = _bill.CheckIn;
            //dtpCheckout.Value = _bill.CheckOut;
            txtIdRoom.Text = _bill.IdRoom.ToString();
            try
            {
                lblTotal.Text = _bill.CheckPay().ToString();
            }
            //Nhận lỗi bên CheckPay báo lỗi 
            catch
            {
                MessageBox.Show("Ngày thanh toán phải lớn hơn ngày đặt phòng!");
                this.Close();
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.No;
                MessageBox.Show("Đã hủy thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnThanhtoanbill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Yes;
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK);
                //Thay đổi dũ liệu bên form pay




                this.Close();
            }
        }
    }
}
