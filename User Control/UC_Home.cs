using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.User_Control
{
    public partial class UC_Home : UserControl
    {
        public event EventHandler ButtonClick;
        public UC_Home()
        {
            InitializeComponent();
        }
    }
}
