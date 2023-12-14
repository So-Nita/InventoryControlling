namespace InventoryWindowApp.View.Component
{
    partial class StockingView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            productCenterPanel = new Panel();
            btnCreateStock = new Button();
            panel1 = new Panel();
            label9 = new Label();
            label6 = new Label();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridViewStock = new DataGridView();
            label1 = new Label();
            productCenterPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            SuspendLayout();
            // 
            // productCenterPanel
            // 
            productCenterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productCenterPanel.AutoScroll = true;
            productCenterPanel.BackColor = Color.White;
            productCenterPanel.Controls.Add(btnCreateStock);
            productCenterPanel.Controls.Add(panel1);
            productCenterPanel.Controls.Add(dataGridViewStock);
            productCenterPanel.Controls.Add(label1);
            productCenterPanel.Location = new Point(0, 0);
            productCenterPanel.Name = "productCenterPanel";
            productCenterPanel.Size = new Size(1207, 565);
            productCenterPanel.TabIndex = 2;
            // 
            // btnCreateStock
            // 
            btnCreateStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateStock.BackColor = Color.FromArgb(98, 102, 244);
            btnCreateStock.Cursor = Cursors.Hand;
            btnCreateStock.ForeColor = Color.White;
            btnCreateStock.Location = new Point(1068, 16);
            btnCreateStock.Name = "btnCreateStock";
            btnCreateStock.Size = new Size(105, 40);
            btnCreateStock.TabIndex = 6;
            btnCreateStock.Text = "Add New";
            btnCreateStock.UseVisualStyleBackColor = false;
            btnCreateStock.UseWaitCursor = true;
            btnCreateStock.Click += btnCreateStock_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 225, 255);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(52, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 30);
            panel1.TabIndex = 5;
            panel1.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(17, 7);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 7;
            label9.Text = "ID";
            label9.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(1080, 7);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 6;
            label6.Text = "Action";
            label6.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(531, 7);
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
            label8.Location = new Point(925, 7);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 4;
            label8.Text = "Note";
            label8.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(730, 7);
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
            label5.Location = new Point(822, 7);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 2;
            label5.Text = "Status";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(273, 7);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 1;
            label4.Text = "Product ID";
            label4.UseWaitCursor = true;
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.AllowUserToResizeColumns = false;
            dataGridViewStock.AllowUserToResizeRows = false;
            dataGridViewStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStock.BackgroundColor = Color.White;
            dataGridViewStock.BorderStyle = BorderStyle.None;
            dataGridViewStock.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewStock.ColumnHeadersHeight = 30;
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewStock.ColumnHeadersVisible = false;
            dataGridViewStock.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewStock.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStock.Location = new Point(52, 95);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.ReadOnly = true;
            dataGridViewStock.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewStock.RowHeadersVisible = false;
            dataGridViewStock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewStock.RowTemplate.Height = 25;
            dataGridViewStock.ScrollBars = ScrollBars.Vertical;
            dataGridViewStock.Size = new Size(1119, 460);
            dataGridViewStock.TabIndex = 4;
            dataGridViewStock.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 0;
            label1.Text = "List of stock transaction";
            label1.UseWaitCursor = true;
            // 
            // StockingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1207, 565);
            Controls.Add(productCenterPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StockingView";
            Text = "StockingView";
            productCenterPanel.ResumeLayout(false);
            productCenterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel productCenterPanel;
        private Panel panel1;
        private Label label9;
        private Label label6;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private DataGridView dataGridViewStock;
        private Label label1;
        private Button btnCreateStock;
    }
}