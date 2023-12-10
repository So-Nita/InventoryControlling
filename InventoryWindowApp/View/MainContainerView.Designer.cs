namespace InventoryWindowApp.View
{
    partial class MainContainerView
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
            panelMenu = new Panel();
            panelPurOrdSubMenu = new Panel();
            panelIventorySubMenu = new Panel();
            btnStockPurSub = new FontAwesome.Sharp.IconButton();
            btnStockSubMenu = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnInventoryMenu = new FontAwesome.Sharp.IconButton();
            btnSignOut = new FontAwesome.Sharp.IconButton();
            btnSellDetailMenu = new FontAwesome.Sharp.IconButton();
            btnCategoryMenu = new FontAwesome.Sharp.IconButton();
            btnProductMenu = new FontAwesome.Sharp.IconButton();
            btnHomeMenu = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureLogo = new PictureBox();
            btnMenu = new PictureBox();
            panelTitelBar = new Panel();
            panel2 = new Panel();
            btnClose = new PictureBox();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelIventorySubMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panelTitelBar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(98, 102, 244);
            panelMenu.Controls.Add(panelPurOrdSubMenu);
            panelMenu.Controls.Add(panelIventorySubMenu);
            panelMenu.Controls.Add(btnInventoryMenu);
            panelMenu.Controls.Add(btnSignOut);
            panelMenu.Controls.Add(btnSellDetailMenu);
            panelMenu.Controls.Add(btnCategoryMenu);
            panelMenu.Controls.Add(btnProductMenu);
            panelMenu.Controls.Add(btnHomeMenu);
            panelMenu.Controls.Add(panel1);
            panelMenu.Cursor = Cursors.Hand;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = SystemColors.ControlDark;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(263, 815);
            panelMenu.TabIndex = 18;
            // 
            // panelPurOrdSubMenu
            // 
            panelPurOrdSubMenu.BackColor = Color.FromArgb(128, 128, 255);
            panelPurOrdSubMenu.Dock = DockStyle.Top;
            panelPurOrdSubMenu.Location = new Point(0, 572);
            panelPurOrdSubMenu.Margin = new Padding(3, 4, 3, 4);
            panelPurOrdSubMenu.Name = "panelPurOrdSubMenu";
            panelPurOrdSubMenu.Size = new Size(263, 157);
            panelPurOrdSubMenu.TabIndex = 23;
            // 
            // panelIventorySubMenu
            // 
            panelIventorySubMenu.BackColor = Color.FromArgb(128, 128, 255);
            panelIventorySubMenu.Controls.Add(btnStockPurSub);
            panelIventorySubMenu.Controls.Add(btnStockSubMenu);
            panelIventorySubMenu.Controls.Add(iconButton2);
            panelIventorySubMenu.Dock = DockStyle.Top;
            panelIventorySubMenu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panelIventorySubMenu.ForeColor = Color.White;
            panelIventorySubMenu.Location = new Point(0, 472);
            panelIventorySubMenu.Margin = new Padding(3, 4, 3, 4);
            panelIventorySubMenu.Name = "panelIventorySubMenu";
            panelIventorySubMenu.Size = new Size(263, 100);
            panelIventorySubMenu.TabIndex = 2;
            // 
            // btnStockPurSub
            // 
            btnStockPurSub.Dock = DockStyle.Top;
            btnStockPurSub.FlatAppearance.BorderSize = 0;
            btnStockPurSub.FlatStyle = FlatStyle.Flat;
            btnStockPurSub.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnStockPurSub.ForeColor = Color.White;
            btnStockPurSub.IconChar = FontAwesome.Sharp.IconChar.None;
            btnStockPurSub.IconColor = Color.White;
            btnStockPurSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStockPurSub.IconSize = 20;
            btnStockPurSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockPurSub.Location = new Point(0, 47);
            btnStockPurSub.Margin = new Padding(3, 13, 3, 13);
            btnStockPurSub.Name = "btnStockPurSub";
            btnStockPurSub.Padding = new Padding(11, 0, 11, 0);
            btnStockPurSub.Size = new Size(263, 47);
            btnStockPurSub.TabIndex = 24;
            btnStockPurSub.Tag = "";
            btnStockPurSub.TextAlign = ContentAlignment.MiddleLeft;
            btnStockPurSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockPurSub.UseVisualStyleBackColor = true;
            btnStockPurSub.Click += btnStockPurSub_Click;
            // 
            // btnStockSubMenu
            // 
            btnStockSubMenu.Dock = DockStyle.Top;
            btnStockSubMenu.FlatAppearance.BorderSize = 0;
            btnStockSubMenu.FlatStyle = FlatStyle.Flat;
            btnStockSubMenu.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnStockSubMenu.ForeColor = Color.White;
            btnStockSubMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            btnStockSubMenu.IconColor = Color.White;
            btnStockSubMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStockSubMenu.IconSize = 20;
            btnStockSubMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockSubMenu.Location = new Point(0, 0);
            btnStockSubMenu.Margin = new Padding(3, 13, 3, 13);
            btnStockSubMenu.Name = "btnStockSubMenu";
            btnStockSubMenu.Padding = new Padding(11, 0, 11, 0);
            btnStockSubMenu.Size = new Size(263, 47);
            btnStockSubMenu.TabIndex = 23;
            btnStockSubMenu.Tag = "Create Stocking";
            btnStockSubMenu.Text = "     Create Stocking";
            btnStockSubMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnStockSubMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockSubMenu.UseVisualStyleBackColor = true;
            btnStockSubMenu.Click += btnProductSub_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Margin = new Padding(3, 13, 3, 13);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(11, 0, 11, 0);
            iconButton2.Size = new Size(243, 47);
            iconButton2.TabIndex = 22;
            iconButton2.Tag = "Child DropDown";
            iconButton2.Text = "   Menu DropDown-1";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnInventoryMenu
            // 
            btnInventoryMenu.Dock = DockStyle.Top;
            btnInventoryMenu.FlatAppearance.BorderSize = 0;
            btnInventoryMenu.FlatStyle = FlatStyle.Flat;
            btnInventoryMenu.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInventoryMenu.ForeColor = Color.White;
            btnInventoryMenu.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnInventoryMenu.IconColor = Color.White;
            btnInventoryMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventoryMenu.IconSize = 30;
            btnInventoryMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventoryMenu.Location = new Point(0, 408);
            btnInventoryMenu.Margin = new Padding(3, 13, 3, 13);
            btnInventoryMenu.Name = "btnInventoryMenu";
            btnInventoryMenu.Padding = new Padding(11, 0, 11, 5);
            btnInventoryMenu.Size = new Size(263, 64);
            btnInventoryMenu.TabIndex = 21;
            btnInventoryMenu.Tag = "Stock";
            btnInventoryMenu.Text = "   Stock";
            btnInventoryMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnInventoryMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventoryMenu.UseVisualStyleBackColor = true;
            btnInventoryMenu.Click += btnMenu1_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Dock = DockStyle.Bottom;
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btnSignOut.IconColor = Color.White;
            btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSignOut.IconSize = 30;
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(0, 751);
            btnSignOut.Margin = new Padding(3, 13, 3, 13);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Padding = new Padding(11, 0, 11, 20);
            btnSignOut.Size = new Size(263, 64);
            btnSignOut.TabIndex = 20;
            btnSignOut.Tag = "SignOut";
            btnSignOut.Text = "   SignOut";
            btnSignOut.TextAlign = ContentAlignment.MiddleLeft;
            btnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnSellDetailMenu
            // 
            btnSellDetailMenu.Dock = DockStyle.Top;
            btnSellDetailMenu.FlatAppearance.BorderSize = 0;
            btnSellDetailMenu.FlatStyle = FlatStyle.Flat;
            btnSellDetailMenu.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSellDetailMenu.ForeColor = Color.White;
            btnSellDetailMenu.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnSellDetailMenu.IconColor = Color.White;
            btnSellDetailMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSellDetailMenu.IconSize = 30;
            btnSellDetailMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnSellDetailMenu.Location = new Point(0, 344);
            btnSellDetailMenu.Margin = new Padding(3, 13, 3, 13);
            btnSellDetailMenu.Name = "btnSellDetailMenu";
            btnSellDetailMenu.Padding = new Padding(11, 0, 11, 5);
            btnSellDetailMenu.Size = new Size(263, 64);
            btnSellDetailMenu.TabIndex = 19;
            btnSellDetailMenu.Tag = "Sell Detail";
            btnSellDetailMenu.Text = "   Sell Detail";
            btnSellDetailMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnSellDetailMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSellDetailMenu.UseVisualStyleBackColor = true;
            btnSellDetailMenu.Click += btnSellDetailMenu_Click;
            // 
            // btnCategoryMenu
            // 
            btnCategoryMenu.Dock = DockStyle.Top;
            btnCategoryMenu.FlatAppearance.BorderSize = 0;
            btnCategoryMenu.FlatStyle = FlatStyle.Flat;
            btnCategoryMenu.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoryMenu.ForeColor = Color.White;
            btnCategoryMenu.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            btnCategoryMenu.IconColor = Color.White;
            btnCategoryMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategoryMenu.IconSize = 30;
            btnCategoryMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategoryMenu.Location = new Point(0, 280);
            btnCategoryMenu.Margin = new Padding(3, 13, 3, 13);
            btnCategoryMenu.Name = "btnCategoryMenu";
            btnCategoryMenu.Padding = new Padding(11, 0, 11, 5);
            btnCategoryMenu.Size = new Size(263, 64);
            btnCategoryMenu.TabIndex = 18;
            btnCategoryMenu.Tag = "Category";
            btnCategoryMenu.Text = "   Category";
            btnCategoryMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnCategoryMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategoryMenu.UseVisualStyleBackColor = true;
            btnCategoryMenu.Click += btnCategoryMenu_Click;
            // 
            // btnProductMenu
            // 
            btnProductMenu.Dock = DockStyle.Top;
            btnProductMenu.FlatAppearance.BorderSize = 0;
            btnProductMenu.FlatStyle = FlatStyle.Flat;
            btnProductMenu.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductMenu.ForeColor = Color.White;
            btnProductMenu.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            btnProductMenu.IconColor = Color.White;
            btnProductMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductMenu.IconSize = 30;
            btnProductMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductMenu.Location = new Point(0, 216);
            btnProductMenu.Margin = new Padding(3, 13, 3, 13);
            btnProductMenu.Name = "btnProductMenu";
            btnProductMenu.Padding = new Padding(11, 0, 11, 5);
            btnProductMenu.Size = new Size(263, 64);
            btnProductMenu.TabIndex = 17;
            btnProductMenu.Tag = "Product";
            btnProductMenu.Text = "   Product";
            btnProductMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnProductMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductMenu.UseVisualStyleBackColor = true;
            btnProductMenu.Click += btnProductMenu_Click;
            // 
            // btnHomeMenu
            // 
            btnHomeMenu.Dock = DockStyle.Top;
            btnHomeMenu.FlatAppearance.BorderSize = 0;
            btnHomeMenu.FlatStyle = FlatStyle.Flat;
            btnHomeMenu.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomeMenu.ForeColor = Color.White;
            btnHomeMenu.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            btnHomeMenu.IconColor = Color.White;
            btnHomeMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHomeMenu.IconSize = 30;
            btnHomeMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomeMenu.Location = new Point(0, 152);
            btnHomeMenu.Margin = new Padding(3, 13, 3, 13);
            btnHomeMenu.Name = "btnHomeMenu";
            btnHomeMenu.Padding = new Padding(11, 0, 11, 5);
            btnHomeMenu.Size = new Size(263, 64);
            btnHomeMenu.TabIndex = 16;
            btnHomeMenu.Tag = "Home";
            btnHomeMenu.Text = "   Home";
            btnHomeMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnHomeMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomeMenu.UseVisualStyleBackColor = true;
            btnHomeMenu.Click += btnHomeMenu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureLogo);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 152);
            panel1.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.Logo_Visa;
            pictureLogo.Location = new Point(14, 11);
            pictureLogo.Margin = new Padding(3, 4, 3, 4);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(160, 69);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = Properties.Resources.Menubar;
            btnMenu.Location = new Point(216, 11);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 45);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Tag = "btnMenu";
            btnMenu.Click += btnMenu_Click;
            // 
            // panelTitelBar
            // 
            panelTitelBar.BackColor = Color.FromArgb(192, 192, 255);
            panelTitelBar.Controls.Add(panel2);
            panelTitelBar.Dock = DockStyle.Top;
            panelTitelBar.Location = new Point(263, 0);
            panelTitelBar.Margin = new Padding(3, 4, 3, 4);
            panelTitelBar.Name = "panelTitelBar";
            panelTitelBar.Size = new Size(1090, 67);
            panelTitelBar.TabIndex = 19;
            panelTitelBar.MouseDown += panelTitle_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1044, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(46, 67);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Image = Properties.Resources.icon_close;
            btnClose.Location = new Point(7, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 27);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(263, 67);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1090, 748);
            panelDesktop.TabIndex = 20;
            // 
            // MainContainerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1353, 815);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitelBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainContainerView";
            Text = "MainContainerView";
            panelMenu.ResumeLayout(false);
            panelIventorySubMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panelTitelBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitelBar;
        private Panel panel1;
        private Panel panelDesktop;
        private PictureBox btnMenu;
        private FontAwesome.Sharp.IconButton btnHomeMenu;
        private FontAwesome.Sharp.IconButton btnSellDetailMenu;
        private FontAwesome.Sharp.IconButton btnCategoryMenu;
        private FontAwesome.Sharp.IconButton btnProductMenu;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private PictureBox pictureLogo;
        private PictureBox btnClose;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnInventoryMenu;
        private Panel panelIventorySubMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnStockPurSub;
        private FontAwesome.Sharp.IconButton btnStockSubMenu;
        private Panel panelPurOrdSubMenu;
    }
}