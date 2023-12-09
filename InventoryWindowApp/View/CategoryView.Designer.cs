namespace POSDesignDemo.View
{
    partial class CategoryView
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
            CenterPanel = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            dataGridViewCategory = new DataGridView();
            btnCreateCategory = new Button();
            label1 = new Label();
            CenterPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // CenterPanel
            // 
            CenterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CenterPanel.AutoScroll = true;
            CenterPanel.BackColor = Color.White;
            CenterPanel.Controls.Add(panel1);
            CenterPanel.Controls.Add(dataGridViewCategory);
            CenterPanel.Controls.Add(btnCreateCategory);
            CenterPanel.Controls.Add(label1);
            CenterPanel.Location = new Point(0, 0);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(1100, 540);
            CenterPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 225, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(50, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 30);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 7);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 6;
            label4.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 7);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(688, 7);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 4;
            label8.Text = "Description";
            label8.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 7);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Image";
            label2.UseWaitCursor = true;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AllowUserToResizeColumns = false;
            dataGridViewCategory.AllowUserToResizeRows = false;
            dataGridViewCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCategory.BackgroundColor = Color.White;
            dataGridViewCategory.BorderStyle = BorderStyle.None;
            dataGridViewCategory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCategory.ColumnHeadersHeight = 30;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCategory.ColumnHeadersVisible = false;
            dataGridViewCategory.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCategory.Location = new Point(50, 95);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.ReadOnly = true;
            dataGridViewCategory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCategory.RowHeadersVisible = false;
            dataGridViewCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCategory.RowTemplate.Height = 25;
            dataGridViewCategory.ScrollBars = ScrollBars.Vertical;
            dataGridViewCategory.Size = new Size(1000, 433);
            dataGridViewCategory.TabIndex = 6;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateCategory.BackColor = Color.FromArgb(98, 102, 244);
            btnCreateCategory.ForeColor = Color.White;
            btnCreateCategory.Location = new Point(941, 16);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Size = new Size(105, 40);
            btnCreateCategory.TabIndex = 1;
            btnCreateCategory.Text = "Add New";
            btnCreateCategory.UseVisualStyleBackColor = false;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 0;
            label1.Text = "List of Categories";
            label1.UseWaitCursor = true;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 540);
            Controls.Add(CenterPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryView";
            Text = "CategoryView";
            CenterPanel.ResumeLayout(false);
            CenterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CenterPanel;
        private Button btnCreateCategory;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label8;
        private Label label2;
        private DataGridView dataGridViewCategory;
        private Label label4;
    }
}