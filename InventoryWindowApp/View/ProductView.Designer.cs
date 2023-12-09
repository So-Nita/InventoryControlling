namespace POSDesignDemo.View
{
    partial class ProductView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            productCenterPanel = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dataGridViewProduct = new DataGridView();
            btnCreateProduct = new Button();
            label1 = new Label();
            productCenterPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // productCenterPanel
            // 
            productCenterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productCenterPanel.AutoScroll = true;
            productCenterPanel.BackColor = Color.White;
            productCenterPanel.Controls.Add(panel1);
            productCenterPanel.Controls.Add(dataGridViewProduct);
            productCenterPanel.Controls.Add(btnCreateProduct);
            productCenterPanel.Controls.Add(label1);
            productCenterPanel.Location = new Point(0, 0);
            productCenterPanel.Name = "productCenterPanel";
            productCenterPanel.Size = new Size(1100, 540);
            productCenterPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 225, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(52, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 30);
            panel1.TabIndex = 5;
            panel1.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(288, 7);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Name";
            label3.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(698, 7);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 4;
            label8.Text = "Category";
            label8.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(584, 7);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 3;
            label7.Text = "Quantity";
            label7.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(489, 7);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 2;
            label5.Text = "Price";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(126, 7);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 1;
            label4.Text = "Product Code ";
            label4.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(39, 7);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Image";
            label2.UseWaitCursor = true;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToResizeColumns = false;
            dataGridViewProduct.AllowUserToResizeRows = false;
            dataGridViewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.BorderStyle = BorderStyle.None;
            dataGridViewProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewProduct.ColumnHeadersHeight = 30;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewProduct.ColumnHeadersVisible = false;
            dataGridViewProduct.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProduct.Location = new Point(52, 95);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProduct.RowHeadersVisible = false;
            dataGridViewProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.ScrollBars = ScrollBars.Vertical;
            dataGridViewProduct.Size = new Size(1000, 433);
            dataGridViewProduct.TabIndex = 4;
            dataGridViewProduct.UseWaitCursor = true;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateProduct.BackColor = Color.FromArgb(98, 102, 244);
            btnCreateProduct.Cursor = Cursors.Hand;
            btnCreateProduct.ForeColor = Color.White;
            btnCreateProduct.Location = new Point(943, 19);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(105, 40);
            btnCreateProduct.TabIndex = 1;
            btnCreateProduct.Text = "Add New";
            btnCreateProduct.UseVisualStyleBackColor = false;
            btnCreateProduct.UseWaitCursor = true;
            btnCreateProduct.Click += btnCreatePro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 30);
            label1.TabIndex = 0;
            label1.Text = "List of Product";
            label1.UseWaitCursor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 540);
            Controls.Add(productCenterPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductView";
            Text = "ProductView";
            productCenterPanel.ResumeLayout(false);
            productCenterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel productCenterPanel;
        private Button btnCreateProduct;
        private Label label1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private DataGridView dataGridViewProduct;
        private Label label3;
    }
}