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
            btnPurSumSub = new FontAwesome.Sharp.IconButton();
            btnPurfilterSub = new FontAwesome.Sharp.IconButton();
            btnPurCreateSub = new FontAwesome.Sharp.IconButton();
            btnPurchaseOrdSub = new FontAwesome.Sharp.IconButton();
            panelIventorySubMenu = new Panel();
            btnSupplierSub = new FontAwesome.Sharp.IconButton();
            btnProductExpSub = new FontAwesome.Sharp.IconButton();
            btnStockPurSub = new FontAwesome.Sharp.IconButton();
            btnProductSub = new FontAwesome.Sharp.IconButton();
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
            panelPurOrdSubMenu.SuspendLayout();
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
            panelMenu.Controls.Add(btnPurchaseOrdSub);
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
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 611);
            panelMenu.TabIndex = 18;
            // 
            // panelPurOrdSubMenu
            // 
            panelPurOrdSubMenu.BackColor = Color.FromArgb(128, 128, 255);
            panelPurOrdSubMenu.Controls.Add(btnPurSumSub);
            panelPurOrdSubMenu.Controls.Add(btnPurfilterSub);
            panelPurOrdSubMenu.Controls.Add(btnPurCreateSub);
            panelPurOrdSubMenu.Dock = DockStyle.Top;
            panelPurOrdSubMenu.Location = new Point(0, 554);
            panelPurOrdSubMenu.Name = "panelPurOrdSubMenu";
            panelPurOrdSubMenu.Size = new Size(213, 118);
            panelPurOrdSubMenu.TabIndex = 23;
            // 
            // btnPurSumSub
            // 
            btnPurSumSub.Dock = DockStyle.Top;
            btnPurSumSub.FlatAppearance.BorderSize = 0;
            btnPurSumSub.FlatStyle = FlatStyle.Flat;
            btnPurSumSub.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPurSumSub.ForeColor = Color.White;
            btnPurSumSub.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPurSumSub.IconColor = Color.White;
            btnPurSumSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPurSumSub.IconSize = 20;
            btnPurSumSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurSumSub.Location = new Point(0, 70);
            btnPurSumSub.Margin = new Padding(3, 10, 3, 10);
            btnPurSumSub.Name = "btnPurSumSub";
            btnPurSumSub.Padding = new Padding(30, 0, 10, 0);
            btnPurSumSub.Size = new Size(213, 35);
            btnPurSumSub.TabIndex = 24;
            btnPurSumSub.Tag = "Summary";
            btnPurSumSub.Text = "Summary";
            btnPurSumSub.TextAlign = ContentAlignment.MiddleLeft;
            btnPurSumSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurSumSub.UseVisualStyleBackColor = true;
            btnPurSumSub.Click += btnPurSumSub_Click;
            // 
            // btnPurfilterSub
            // 
            btnPurfilterSub.Dock = DockStyle.Top;
            btnPurfilterSub.FlatAppearance.BorderSize = 0;
            btnPurfilterSub.FlatStyle = FlatStyle.Flat;
            btnPurfilterSub.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPurfilterSub.ForeColor = Color.White;
            btnPurfilterSub.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPurfilterSub.IconColor = Color.White;
            btnPurfilterSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPurfilterSub.IconSize = 20;
            btnPurfilterSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurfilterSub.Location = new Point(0, 35);
            btnPurfilterSub.Margin = new Padding(3, 10, 3, 10);
            btnPurfilterSub.Name = "btnPurfilterSub";
            btnPurfilterSub.Padding = new Padding(30, 0, 10, 0);
            btnPurfilterSub.Size = new Size(213, 35);
            btnPurfilterSub.TabIndex = 23;
            btnPurfilterSub.Tag = "Filtering";
            btnPurfilterSub.Text = "Filtering";
            btnPurfilterSub.TextAlign = ContentAlignment.MiddleLeft;
            btnPurfilterSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurfilterSub.UseVisualStyleBackColor = true;
            btnPurfilterSub.Click += btnPurfilterSub_Click;
            // 
            // btnPurCreateSub
            // 
            btnPurCreateSub.Dock = DockStyle.Top;
            btnPurCreateSub.FlatAppearance.BorderSize = 0;
            btnPurCreateSub.FlatStyle = FlatStyle.Flat;
            btnPurCreateSub.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPurCreateSub.ForeColor = Color.White;
            btnPurCreateSub.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPurCreateSub.IconColor = Color.White;
            btnPurCreateSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPurCreateSub.IconSize = 20;
            btnPurCreateSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurCreateSub.Location = new Point(0, 0);
            btnPurCreateSub.Margin = new Padding(3, 10, 3, 10);
            btnPurCreateSub.Name = "btnPurCreateSub";
            btnPurCreateSub.Padding = new Padding(33, 0, 10, 0);
            btnPurCreateSub.Size = new Size(213, 35);
            btnPurCreateSub.TabIndex = 22;
            btnPurCreateSub.Tag = "Create";
            btnPurCreateSub.Text = "Create";
            btnPurCreateSub.TextAlign = ContentAlignment.MiddleLeft;
            btnPurCreateSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurCreateSub.UseVisualStyleBackColor = true;
            btnPurCreateSub.Click += btnPurCreateSub_Click;
            // 
            // btnPurchaseOrdSub
            // 
            btnPurchaseOrdSub.Dock = DockStyle.Top;
            btnPurchaseOrdSub.FlatAppearance.BorderSize = 0;
            btnPurchaseOrdSub.FlatStyle = FlatStyle.Flat;
            btnPurchaseOrdSub.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPurchaseOrdSub.ForeColor = Color.White;
            btnPurchaseOrdSub.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnPurchaseOrdSub.IconColor = Color.White;
            btnPurchaseOrdSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPurchaseOrdSub.IconSize = 30;
            btnPurchaseOrdSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchaseOrdSub.Location = new Point(0, 506);
            btnPurchaseOrdSub.Margin = new Padding(3, 10, 3, 10);
            btnPurchaseOrdSub.Name = "btnPurchaseOrdSub";
            btnPurchaseOrdSub.Padding = new Padding(10, 0, 10, 4);
            btnPurchaseOrdSub.Size = new Size(213, 48);
            btnPurchaseOrdSub.TabIndex = 22;
            btnPurchaseOrdSub.Tag = "Purchase Order";
            btnPurchaseOrdSub.Text = "  Purchase Order";
            btnPurchaseOrdSub.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchaseOrdSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurchaseOrdSub.UseVisualStyleBackColor = true;
            btnPurchaseOrdSub.Click += btnPurchaseOrdSub_Click;
            // 
            // panelIventorySubMenu
            // 
            panelIventorySubMenu.BackColor = Color.FromArgb(128, 128, 255);
            panelIventorySubMenu.Controls.Add(btnSupplierSub);
            panelIventorySubMenu.Controls.Add(btnProductExpSub);
            panelIventorySubMenu.Controls.Add(btnStockPurSub);
            panelIventorySubMenu.Controls.Add(btnProductSub);
            panelIventorySubMenu.Controls.Add(iconButton2);
            panelIventorySubMenu.Dock = DockStyle.Top;
            panelIventorySubMenu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panelIventorySubMenu.ForeColor = Color.White;
            panelIventorySubMenu.Location = new Point(0, 354);
            panelIventorySubMenu.Name = "panelIventorySubMenu";
            panelIventorySubMenu.Size = new Size(213, 152);
            panelIventorySubMenu.TabIndex = 2;
            // 
            // btnSupplierSub
            // 
            btnSupplierSub.Dock = DockStyle.Top;
            btnSupplierSub.FlatAppearance.BorderSize = 0;
            btnSupplierSub.FlatStyle = FlatStyle.Flat;
            btnSupplierSub.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupplierSub.ForeColor = Color.White;
            btnSupplierSub.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSupplierSub.IconColor = Color.White;
            btnSupplierSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSupplierSub.IconSize = 20;
            btnSupplierSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplierSub.Location = new Point(0, 105);
            btnSupplierSub.Margin = new Padding(3, 10, 3, 10);
            btnSupplierSub.Name = "btnSupplierSub";
            btnSupplierSub.Padding = new Padding(10, 0, 10, 0);
            btnSupplierSub.Size = new Size(213, 35);
            btnSupplierSub.TabIndex = 26;
            btnSupplierSub.Tag = "Supplier";
            btnSupplierSub.Text = "     Supplier";
            btnSupplierSub.TextAlign = ContentAlignment.MiddleLeft;
            btnSupplierSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSupplierSub.UseVisualStyleBackColor = true;
            btnSupplierSub.Click += btnSupplierSub_Click;
            // 
            // btnProductExpSub
            // 
            btnProductExpSub.Dock = DockStyle.Top;
            btnProductExpSub.FlatAppearance.BorderSize = 0;
            btnProductExpSub.FlatStyle = FlatStyle.Flat;
            btnProductExpSub.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductExpSub.ForeColor = Color.White;
            btnProductExpSub.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProductExpSub.IconColor = Color.White;
            btnProductExpSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductExpSub.IconSize = 20;
            btnProductExpSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductExpSub.Location = new Point(0, 70);
            btnProductExpSub.Margin = new Padding(3, 10, 3, 10);
            btnProductExpSub.Name = "btnProductExpSub";
            btnProductExpSub.Padding = new Padding(10, 0, 10, 0);
            btnProductExpSub.Size = new Size(213, 35);
            btnProductExpSub.TabIndex = 25;
            btnProductExpSub.Tag = "ProductExpire";
            btnProductExpSub.Text = "     Product Expire";
            btnProductExpSub.TextAlign = ContentAlignment.MiddleLeft;
            btnProductExpSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductExpSub.UseVisualStyleBackColor = true;
            btnProductExpSub.Click += btnProductExpSub_Click;
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
            btnStockPurSub.Location = new Point(0, 35);
            btnStockPurSub.Margin = new Padding(3, 10, 3, 10);
            btnStockPurSub.Name = "btnStockPurSub";
            btnStockPurSub.Padding = new Padding(10, 0, 10, 0);
            btnStockPurSub.Size = new Size(213, 35);
            btnStockPurSub.TabIndex = 24;
            btnStockPurSub.Tag = "Stock Purchase";
            btnStockPurSub.Text = "     Stock Purchase";
            btnStockPurSub.TextAlign = ContentAlignment.MiddleLeft;
            btnStockPurSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockPurSub.UseVisualStyleBackColor = true;
            btnStockPurSub.Click += btnStockPurSub_Click;
            // 
            // btnProductSub
            // 
            btnProductSub.Dock = DockStyle.Top;
            btnProductSub.FlatAppearance.BorderSize = 0;
            btnProductSub.FlatStyle = FlatStyle.Flat;
            btnProductSub.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductSub.ForeColor = Color.White;
            btnProductSub.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProductSub.IconColor = Color.White;
            btnProductSub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductSub.IconSize = 20;
            btnProductSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductSub.Location = new Point(0, 0);
            btnProductSub.Margin = new Padding(3, 10, 3, 10);
            btnProductSub.Name = "btnProductSub";
            btnProductSub.Padding = new Padding(10, 0, 10, 0);
            btnProductSub.Size = new Size(213, 35);
            btnProductSub.TabIndex = 23;
            btnProductSub.Tag = "Prouduct";
            btnProductSub.Text = "     Product";
            btnProductSub.TextAlign = ContentAlignment.MiddleLeft;
            btnProductSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductSub.UseVisualStyleBackColor = true;
            btnProductSub.Click += btnProductSub_Click;
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
            iconButton2.Margin = new Padding(3, 10, 3, 10);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 10, 0);
            iconButton2.Size = new Size(213, 35);
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
            btnInventoryMenu.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnInventoryMenu.IconColor = Color.White;
            btnInventoryMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventoryMenu.IconSize = 30;
            btnInventoryMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventoryMenu.Location = new Point(0, 306);
            btnInventoryMenu.Margin = new Padding(3, 10, 3, 10);
            btnInventoryMenu.Name = "btnInventoryMenu";
            btnInventoryMenu.Padding = new Padding(10, 0, 10, 4);
            btnInventoryMenu.Size = new Size(213, 48);
            btnInventoryMenu.TabIndex = 21;
            btnInventoryMenu.Tag = "Inventory";
            btnInventoryMenu.Text = "   Inventory";
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
            btnSignOut.Location = new Point(0, 672);
            btnSignOut.Margin = new Padding(3, 10, 3, 10);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Padding = new Padding(10, 0, 10, 15);
            btnSignOut.Size = new Size(213, 48);
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
            btnSellDetailMenu.Location = new Point(0, 258);
            btnSellDetailMenu.Margin = new Padding(3, 10, 3, 10);
            btnSellDetailMenu.Name = "btnSellDetailMenu";
            btnSellDetailMenu.Padding = new Padding(10, 0, 10, 4);
            btnSellDetailMenu.Size = new Size(213, 48);
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
            btnCategoryMenu.Location = new Point(0, 210);
            btnCategoryMenu.Margin = new Padding(3, 10, 3, 10);
            btnCategoryMenu.Name = "btnCategoryMenu";
            btnCategoryMenu.Padding = new Padding(10, 0, 10, 4);
            btnCategoryMenu.Size = new Size(213, 48);
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
            btnProductMenu.Location = new Point(0, 162);
            btnProductMenu.Margin = new Padding(3, 10, 3, 10);
            btnProductMenu.Name = "btnProductMenu";
            btnProductMenu.Padding = new Padding(10, 0, 10, 4);
            btnProductMenu.Size = new Size(213, 48);
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
            btnHomeMenu.Location = new Point(0, 114);
            btnHomeMenu.Margin = new Padding(3, 10, 3, 10);
            btnHomeMenu.Name = "btnHomeMenu";
            btnHomeMenu.Padding = new Padding(10, 0, 10, 4);
            btnHomeMenu.Size = new Size(213, 48);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 114);
            panel1.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.Logo_Visa;
            pictureLogo.Location = new Point(12, 8);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(140, 52);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = Properties.Resources.Menubar;
            btnMenu.Location = new Point(189, 8);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 34);
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
            panelTitelBar.Location = new Point(230, 0);
            panelTitelBar.Name = "panelTitelBar";
            panelTitelBar.Size = new Size(954, 50);
            panelTitelBar.TabIndex = 19;
            panelTitelBar.MouseDown += panelTitle_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(914, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(40, 50);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Image = Properties.Resources.icon_close;
            btnClose.Location = new Point(6, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 20);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(230, 50);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(954, 561);
            panelDesktop.TabIndex = 20;
            // 
            // MainContainerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 611);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitelBar);
            Controls.Add(panelMenu);
            Name = "MainContainerView";
            Text = "MainContainerView";
            panelMenu.ResumeLayout(false);
            panelPurOrdSubMenu.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnProductExpSub;
        private FontAwesome.Sharp.IconButton btnStockPurSub;
        private FontAwesome.Sharp.IconButton btnProductSub;
        private Panel panelPurOrdSubMenu;
        private FontAwesome.Sharp.IconButton btnPurCreateSub;
        private FontAwesome.Sharp.IconButton btnPurchaseOrdSub;
        private FontAwesome.Sharp.IconButton btnSupplierSub;
        private FontAwesome.Sharp.IconButton btnPurSumSub;
        private FontAwesome.Sharp.IconButton btnPurfilterSub;
    }
}