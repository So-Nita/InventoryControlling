using InventoryApiClient.Services;
using POSDesignDemo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWindowApp.View
{
    public partial class MainContainerView : Form
    {
        //private readonly ProductService _productService;
        private int borderSize = 2;
        private int minWidthSize = 1200;
        private int maxWidthSize = 1350;
        private Size formSize;

        public MainContainerView()
        {
            //_productService = new ProductService();
            InitializeComponent();
            InitializeItemComponent();
            CustomeDesign();
        }
        private void CustomeDesign()
        {
            panelIventorySubMenu.Visible = false;
            panelPurOrdSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelIventorySubMenu.Visible == true)
            {
                panelIventorySubMenu.Visible = false;
            }
            if (panelPurOrdSubMenu.Visible == true)
            {
                panelPurOrdSubMenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void InitializeItemComponent()
        {
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            AddControlls(new HomeView());
            this.Width = maxWidthSize;
            //CollapseMenu();
        }
        public void AddControlls(Form form)
        {
            if (this.panelDesktop.Controls.Count > 0)
            {
                this.panelDesktop.Controls.RemoveAt(0);
            }
            panelDesktop.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelDesktop.Controls.Add(form);
            form.Show();
        }
        private void btnHomeMenu_Click(object sender, EventArgs e)
        {
            AddControlls(new HomeView());
        }
        private void btnProductMenu_Click(object sender, EventArgs e)
        {
            AddControlls(new ProductView());
        }

        private void btnCategoryMenu_Click(object sender, EventArgs e)
        {
            AddControlls(new CategoryView());
        }

        private void btnSellDetailMenu_Click(object sender, EventArgs e)
        {
            //AddControlls(new SaleDetailView());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            /*var loginForm = new FormLogin();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //Drag Form
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0X0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }*/
        private void Form_Resize(object sender, EventArgs args)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) // Callapse the Panel
            {
                panelMenu.Width = 100;
                pictureLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    panelMenu.Padding = new Padding(0, 20, 0, 0);
                    //this.Width = 954;
                }
                this.Width = minWidthSize;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else // Expand the Panel
            {
                panelMenu.Width = 230;
                pictureLogo.Visible = true;
                panelMenu.Visible = true;
                panelMenu.Padding = new Padding(0, 10, 0, 0);
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    //menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Width = maxWidthSize;
            }
        }

        //Overridden methods for response size
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1;  
            const int HTLEFT = 10;   
            const int HTRIGHT = 11; 
            const int HTTOP = 12;    
            const int HTTOPLEFT = 13; 
            const int HTTOPRIGHT = 14; 
            const int HTBOTTOM = 15;  
            const int HTBOTTOMLEFT = 16; 
            const int HTBOTTOMRIGHT = 17; 

            if (m.Msg == WM_NCHITTEST)
            {  
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }


        #region Menu: Iventory
        private void btnMenu1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelIventorySubMenu);
        }
        private void btnProductSub_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnStockPurSub_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnProductExpSub_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnSupplierSub_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //AddControlls(new SupplierView());
        }
        #endregion


        #region Menu : Purchase Order
        private void btnPurchaseOrdSub_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPurOrdSubMenu);
        }
        private void btnPurCreateSub_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnPurfilterSub_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void btnPurSumSub_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion





    }
}
