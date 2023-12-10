namespace InventoryWindowApp.View.Component
{
    partial class StockComonentView
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
            panelProductForm = new Panel();
            btnSave = new Button();
            btn_Cancel = new Button();
            label8 = new Label();
            panel2 = new Panel();
            txtNote = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            comboStatus = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            paneltxtName = new Panel();
            comboProduct = new ComboBox();
            panel4 = new Panel();
            txtQty = new TextBox();
            labelTitle = new Label();
            panelProductForm.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            paneltxtName.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelProductForm
            // 
            panelProductForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProductForm.BackColor = Color.White;
            panelProductForm.Controls.Add(btnSave);
            panelProductForm.Controls.Add(btn_Cancel);
            panelProductForm.Controls.Add(label8);
            panelProductForm.Controls.Add(panel2);
            panelProductForm.Controls.Add(label5);
            panelProductForm.Controls.Add(label4);
            panelProductForm.Controls.Add(panel1);
            panelProductForm.Controls.Add(label2);
            panelProductForm.Controls.Add(label1);
            panelProductForm.Controls.Add(paneltxtName);
            panelProductForm.Controls.Add(panel4);
            panelProductForm.Controls.Add(labelTitle);
            panelProductForm.Location = new Point(3, 4);
            panelProductForm.Margin = new Padding(3, 4, 3, 4);
            panelProductForm.Name = "panelProductForm";
            panelProductForm.Size = new Size(1067, 699);
            panelProductForm.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(98, 102, 244);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(641, 587);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 53);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.UseWaitCursor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Cancel.BackColor = SystemColors.ActiveBorder;
            btn_Cancel.Cursor = Cursors.Hand;
            btn_Cancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(485, 587);
            btn_Cancel.Margin = new Padding(3, 4, 3, 4);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(120, 53);
            btn_Cancel.TabIndex = 25;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.UseWaitCursor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI Light", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(98, 102, 244);
            label8.Location = new Point(192, 522);
            label8.Name = "label8";
            label8.Size = new Size(569, 31);
            label8.TabIndex = 24;
            label8.Text = "Note : All fields are required.";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtNote);
            panel2.Location = new Point(196, 442);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 47);
            panel2.TabIndex = 18;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.BackColor = Color.White;
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNote.ForeColor = SystemColors.WindowFrame;
            txtNote.Location = new Point(9, 9);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(555, 27);
            txtNote.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(192, 407);
            label5.Name = "label5";
            label5.Size = new Size(569, 31);
            label5.TabIndex = 19;
            label5.Text = "Note";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(190, 76);
            label4.Name = "label4";
            label4.Size = new Size(571, 31);
            label4.TabIndex = 16;
            label4.Text = "Product";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboStatus);
            panel1.Location = new Point(196, 329);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 47);
            panel1.TabIndex = 15;
            // 
            // comboStatus
            // 
            comboStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboStatus.Cursor = Cursors.Hand;
            comboStatus.FlatStyle = FlatStyle.Flat;
            comboStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(10, 7);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(550, 31);
            comboStatus.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(190, 182);
            label2.Name = "label2";
            label2.Size = new Size(571, 31);
            label2.TabIndex = 15;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(192, 293);
            label1.Name = "label1";
            label1.Size = new Size(571, 31);
            label1.TabIndex = 14;
            label1.Text = "Status";
            // 
            // paneltxtName
            // 
            paneltxtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paneltxtName.BorderStyle = BorderStyle.FixedSingle;
            paneltxtName.Controls.Add(comboProduct);
            paneltxtName.Location = new Point(196, 114);
            paneltxtName.Margin = new Padding(3, 4, 3, 4);
            paneltxtName.Name = "paneltxtName";
            paneltxtName.Size = new Size(565, 47);
            paneltxtName.TabIndex = 13;
            // 
            // comboProduct
            // 
            comboProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboProduct.BackColor = Color.White;
            comboProduct.Cursor = Cursors.Hand;
            comboProduct.FlatStyle = FlatStyle.Flat;
            comboProduct.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new Point(6, 7);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(550, 31);
            comboProduct.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtQty);
            panel4.Location = new Point(196, 221);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(565, 47);
            panel4.TabIndex = 11;
            // 
            // txtQty
            // 
            txtQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQty.BackColor = Color.White;
            txtQty.BorderStyle = BorderStyle.None;
            txtQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQty.ForeColor = SystemColors.WindowFrame;
            txtQty.Location = new Point(10, 9);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(550, 27);
            txtQty.TabIndex = 4;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(98, 102, 244);
            labelTitle.Location = new Point(25, 7);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(624, 31);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Create New Product Stock";
            // 
            // btnCancel
            // 
            // 
            // StockComonentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 706);
            Controls.Add(panelProductForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockComonentView";
            Text = "StockUpdateForm";
            panelProductForm.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            paneltxtName.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProductForm;
        private Label label8;
        private Panel panel2;
        private TextBox txtNote;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel paneltxtName;
        private Panel panel4;
        private TextBox txtQty;
        private Label labelTitle;
        private Button btnSave;
        private Button btn_Cancel;
        private ComboBox comboStatus;
        private ComboBox comboProduct;
    }
}