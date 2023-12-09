using InventoryWindowApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWindowApp.CustomStyle
{
    public partial class CustomMessageBox : Form
    {
         
        public CustomMessageBox(string message, bool isFail)
        {
            InitializeComponent();
            InitDelay();
            InitTitle(message,isFail);
            
        }
        public static void ShowMessageBox(string message/*, Color txtColor*/, bool ifFailed)
        {
            using (var form = new CustomMessageBox(message, ifFailed))
            {
                form.ShowDialog();
            }
        }
        private void InitDelay()
        {
            icon_delay.Start();
            icon.Enabled = true;
        }
        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icon_delay.Stop();
        }

        private void InitTitle(string message,bool checkfail)
        {
            lableMessage.Text = message;
            if(!checkfail)
            {
                icon.Image = (Image)resources.GetObject("icon.Image")!;
            }
            icon.Image = (Image)resources.GetObject("icon.Image")!;
        }


        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
