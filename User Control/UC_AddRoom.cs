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
    public partial class UC_AddRoom : UserControl
    {
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (cbbRCLASS.Text != "" && cbbBTYPE.Text != "" && txtIDRoom.Text != "" && txtPrice.Text != "")
            {
                CRoom newRoom = new CRoom(txtIDRoom.Text, int.Parse(txtPrice.Text), cbbRCLASS.Text, cbbBTYPE.Text, false);

                if (CRoomData.Find(txtIDRoom.Text, ref newRoom) == false)
                {
                    CRoomData.Add(newRoom);
                    CRoomData.SaveRoomData();
                }
            }
        }
    }
}
