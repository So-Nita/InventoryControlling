using InventoryWindowApp.CustomStyle;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InventoryWindowApp.View
{
    partial class HomeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowLayoutPanelProducts = new FlowLayoutPanel();

        private CustomTouchScroll touchScroll;
        private CustomTouchScroll touchScrollProduct;
        private CustomTouchScroll touchScrollProductCart;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            HomePanel = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            productPanel = new FlowLayoutPanel();
            panelMainCart = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridViewProduct = new DataGridView();
            panelMenuCategory = new FlowLayoutPanel();
            btnPay = new Button();
            panel8 = new Panel();
            textTotalPrice = new TextBox();
            TextPrice = new Label();
            label6 = new Label();
            btnClear = new Button();
            btnAllCategory = new Button();
            label2 = new Label();
            btnAllCatgory = new Label();
            panelCategory = new Panel();
            txtCatgoryName = new Label();
            HomePanel.SuspendLayout();
            panel2.SuspendLayout();
            panelMainCart.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomePanel.BackColor = Color.White;
            HomePanel.Controls.Add(panel2);
            HomePanel.Controls.Add(productPanel);
            HomePanel.Controls.Add(panelMainCart);
            HomePanel.Controls.Add(panelMenuCategory);
            HomePanel.Controls.Add(btnPay);
            HomePanel.Controls.Add(panel8);
            HomePanel.Controls.Add(btnClear);
            HomePanel.Location = new Point(0, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1114, 609);
            HomePanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(824, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 52);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(107, 21);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 0;
            label3.Text = "Order Details";
            // 
            // productPanel
            // 
            productPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productPanel.AutoScroll = true;
            productPanel.BackColor = Color.White;
            productPanel.Cursor = Cursors.Hand;
            productPanel.Location = new Point(-2, 52);
            productPanel.MinimumSize = new Size(822, 539);
            productPanel.Name = "productPanel";
            productPanel.Padding = new Padding(10, 0, 0, 40);
            productPanel.Size = new Size(828, 555);
            productPanel.TabIndex = 19;
            // 
            // panelMainCart
            // 
            panelMainCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainCart.AutoScroll = true;
            panelMainCart.BackColor = Color.FromArgb(224, 225, 255);
            panelMainCart.Controls.Add(panel1);
            panelMainCart.Controls.Add(dataGridViewProduct);
            panelMainCart.Location = new Point(822, 52);
            panelMainCart.Name = "panelMainCart";
            panelMainCart.Size = new Size(293, 466);
            panelMainCart.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 225, 255);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 28);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(226, 7);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 4;
            label8.Text = "Total";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(178, 6);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 3;
            label7.Text = "Qty";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(127, 7);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 2;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(53, 6);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 1;
            label4.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Image";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToResizeColumns = false;
            dataGridViewProduct.AllowUserToResizeRows = false;
            dataGridViewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.BorderStyle = BorderStyle.None;
            dataGridViewProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewProduct.ColumnHeadersHeight = 30;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewProduct.ColumnHeadersVisible = false;
            dataGridViewProduct.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProduct.Location = new Point(0, 27);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProduct.RowHeadersVisible = false;
            dataGridViewProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.ScrollBars = ScrollBars.Vertical;
            dataGridViewProduct.Size = new Size(293, 440);
            dataGridViewProduct.TabIndex = 0;
            // 
            // panelMenuCategory
            // 
            panelMenuCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMenuCategory.AutoScroll = true;
            panelMenuCategory.BackColor = Color.White;
            panelMenuCategory.Cursor = Cursors.Hand;
            panelMenuCategory.Location = new Point(0, 1);
            panelMenuCategory.Name = "panelMenuCategory";
            panelMenuCategory.Padding = new Padding(0, 3, 0, 0);
            panelMenuCategory.Size = new Size(830, 67);
            panelMenuCategory.TabIndex = 11;
            panelMenuCategory.WrapContents = false;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPay.BackColor = Color.FromArgb(98, 102, 244);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Location = new Point(932, 553);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(189, 56);
            btnPay.TabIndex = 16;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel8.BackColor = SystemColors.Window;
            panel8.Controls.Add(textTotalPrice);
            panel8.Controls.Add(TextPrice);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(822, 519);
            panel8.Name = "panel8";
            panel8.Size = new Size(292, 32);
            panel8.TabIndex = 15;
            // 
            // textTotalPrice
            // 
            textTotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textTotalPrice.BackColor = SystemColors.ControlLightLight;
            textTotalPrice.BorderStyle = BorderStyle.None;
            textTotalPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textTotalPrice.ForeColor = Color.Red;
            textTotalPrice.Location = new Point(172, 6);
            textTotalPrice.Name = "textTotalPrice";
            textTotalPrice.ReadOnly = true;
            textTotalPrice.Size = new Size(100, 18);
            textTotalPrice.TabIndex = 4;
            textTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // TextPrice
            // 
            TextPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextPrice.AutoSize = true;
            TextPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextPrice.ForeColor = Color.Red;
            TextPrice.ImageAlign = ContentAlignment.MiddleLeft;
            TextPrice.Location = new Point(209, 13);
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new Size(0, 17);
            TextPrice.TabIndex = 3;
            TextPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(3, 8);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 2;
            label6.Text = "Total Order : ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = SystemColors.Control;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Firebrick;
            btnClear.Location = new Point(825, 554);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 55);
            btnClear.TabIndex = 14;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAllCategory
            // 
            btnAllCategory.Cursor = Cursors.Hand;
            btnAllCategory.FlatAppearance.BorderColor = Color.White;
            btnAllCategory.FlatAppearance.CheckedBackColor = Color.AliceBlue;
            btnAllCategory.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAllCategory.FlatStyle = FlatStyle.Flat;
            btnAllCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllCategory.ForeColor = Color.DarkGray;
            btnAllCategory.Location = new Point(3, 3);
            btnAllCategory.Name = "btnAllCategory";
            btnAllCategory.Size = new Size(105, 40);
            btnAllCategory.TabIndex = 1;
            btnAllCategory.Text = "All Category";
            btnAllCategory.Click += BtnAllCategory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(104, 3);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 3;
            label2.Text = "Reset";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAllCatgory
            // 
            btnAllCatgory.AutoSize = true;
            btnAllCatgory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllCatgory.ForeColor = SystemColors.ControlDarkDark;
            btnAllCatgory.Location = new Point(12, 11);
            btnAllCatgory.Name = "btnAllCatgory";
            btnAllCatgory.Size = new Size(85, 17);
            btnAllCatgory.TabIndex = 1;
            btnAllCatgory.Text = "All Category";
            // 
            // panelCategory
            // 
            panelCategory.Location = new Point(0, 0);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(200, 100);
            panelCategory.TabIndex = 0;
            // 
            // txtCatgoryName
            // 
            txtCatgoryName.AutoSize = true;
            txtCatgoryName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCatgoryName.ForeColor = SystemColors.ControlDarkDark;
            txtCatgoryName.Location = new Point(30, 12);
            txtCatgoryName.Name = "txtCatgoryName";
            txtCatgoryName.Size = new Size(0, 17);
            txtCatgoryName.TabIndex = 1;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 608);
            Controls.Add(HomePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeView";
            Text = "HomeView";
            HomePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMainCart.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HomePanel;
        private Panel panelCategory;
        private Label txtCatgoryName;
        //private Panel btnAllCategory;
        private Button btnAllCategory;
        private Label btnAllCatgory;
        //private Panel btnClear;
        private Button btnClear;
        private Label label2;
        private Panel panel8;
        private TextBox textTotalPrice;
        private Label TextPrice;
        private Label label6;
        //private Panel panelMainCategory;
        private FlowLayoutPanel panelMenuCategory;

        private Point touchStart;

        public Point scrollStart;

        private bool scrolling;
        private int YOffSet = 140;
        private int sizeOfMove = 140;
        private void PMainCategory_MouseDown(object sender, MouseEventArgs e)
        {
            touchStart = e.Location;
        }
        private void PMainCategory_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = touchStart.X - e.X;
                int deltaY = touchStart.Y - e.Y;

                panelMenuCategory.AutoScrollPosition = new Point(Math.Abs(deltaX), Math.Abs(deltaY));
            }
        }

        private Button btnPay;
        private Panel panelMainCart;
        private DataGridView dataGridViewProduct;
        private FlowLayoutPanel productPanel;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}