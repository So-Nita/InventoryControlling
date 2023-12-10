namespace InventoryWindowApp.CustomStyle
{
    partial class CustomMessageBox
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
        /// 
        protected System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            icon = new PictureBox();
            icon_delay = new System.Windows.Forms.Timer(components);
            lableMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = this;
            bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // icon
            // 
            icon.Location = new Point(15, 1);
            icon.Margin = new Padding(5, 4, 5, 4);
            icon.Name = "icon";
            icon.Size = new Size(454, 336);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.TabIndex = 1;
            icon.TabStop = false;
            // 
            // icon_delay
            // 
            icon_delay.Enabled = true;
            icon_delay.Interval = 1500;
            // 
            // lableMessage
            // 
            lableMessage.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lableMessage.Location = new Point(5, 262);
            lableMessage.Name = "lableMessage";
            lableMessage.Size = new Size(470, 49);
            lableMessage.TabIndex = 8;
            lableMessage.Text = "Successfully";
            lableMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(483, 363);
            Controls.Add(lableMessage);
            Controls.Add(icon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox icon;
        private System.Windows.Forms.Timer icon_delay;
        private Label lableMessage;
    }
}