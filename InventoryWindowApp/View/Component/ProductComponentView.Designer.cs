namespace InventoryWindowApp.View.Component
{
    partial class ProductComponentView
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
            panel5 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            Save = new Button();
            btnCancel = new Button();
            panelProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelProductForm
            // 
            panelProductForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProductForm.Controls.Add(panel4);
            panelProductForm.Controls.Add(panel5);
            panelProductForm.Controls.Add(panel1);
            panelProductForm.Controls.Add(panel2);
            panelProductForm.Controls.Add(panel3);
            panelProductForm.Controls.Add(label1);
            panelProductForm.Controls.Add(Save);
            panelProductForm.Controls.Add(btnCancel);
            panelProductForm.Location = new Point(2, -1);
            panelProductForm.Name = "panelProductForm";
            panelProductForm.Size = new Size(797, 488);
            panelProductForm.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(448, 53);
            panel5.Name = "panel5";
            panel5.Size = new Size(306, 36);
            panel5.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Location = new Point(22, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 351);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(448, 340);
            panel4.Name = "panel4";
            panel4.Size = new Size(306, 36);
            panel4.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(448, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 36);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(448, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 36);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(98, 102, 244);
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Save.BackColor = Color.FromArgb(98, 102, 244);
            Save.Cursor = Cursors.Hand;
            Save.ForeColor = Color.White;
            Save.Location = new Point(649, 410);
            Save.Name = "Save";
            Save.Size = new Size(105, 40);
            Save.TabIndex = 3;
            Save.Text = "Add New";
            Save.UseVisualStyleBackColor = false;
            Save.UseWaitCursor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(507, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.UseWaitCursor = true;
            // 
            // ProductComponentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 487);
            Controls.Add(panelProductForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductComponentView";
            Text = "ProductComponentView";
            panelProductForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProductForm;
        private Button Save;
        private Button btnCancel;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
    }
}