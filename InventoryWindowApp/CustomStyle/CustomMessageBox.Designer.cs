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
            btnOkay = new Bunifu.Framework.UI.BunifuThinButton2();
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
            /*icon.Image = (Image)resources.GetObject("icon.Image");*/
            icon.Location = new Point(13, -41);
            icon.Margin = new Padding(4, 3, 4, 3);
            icon.Name = "icon";
            icon.Size = new Size(397, 252);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.TabIndex = 1;
            icon.TabStop = false;
            // 
            // icon_delay
            // 
            icon_delay.Enabled = true;
            icon_delay.Interval = 1500;
            icon_delay.Tick += icon_delay_Tick;
            // 
            // btnOkay
            // 
            btnOkay.ActiveBorderThickness = 1;
            btnOkay.ActiveCornerRadius = 15;
            btnOkay.ActiveFillColor = Color.White;
            btnOkay.ActiveForecolor = Color.FromArgb(51, 153, 255);
            btnOkay.ActiveLineColor = Color.FromArgb(51, 153, 255);
            btnOkay.BackColor = Color.White;
            btnOkay.BackgroundImage = (Image)resources.GetObject("btnOkay.BackgroundImage");
            btnOkay.ButtonText = "Okay";
            btnOkay.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOkay.ForeColor = Color.SeaGreen;
            btnOkay.IdleBorderThickness = 1;
            btnOkay.IdleCornerRadius = 18;
            btnOkay.IdleFillColor = Color.FromArgb(102, 179, 255);
            btnOkay.IdleForecolor = Color.White;
            btnOkay.IdleLineColor = Color.White;
            btnOkay.Location = new Point(168, 204);
            btnOkay.Margin = new Padding(4, 5, 4, 5);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(81, 40);
            btnOkay.TabIndex = 6;
            btnOkay.TextAlign = ContentAlignment.MiddleCenter;
            btnOkay.Click += btnOkay_Click;
            // 
            // lableMessage
            // 
            lableMessage.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lableMessage.Location = new Point(-1, 153);
            lableMessage.Name = "lableMessage";
            lableMessage.Size = new Size(424, 37);
            lableMessage.TabIndex = 8;
            lableMessage.Text = "Successfully";
            lableMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 272);
            Controls.Add(lableMessage);
            Controls.Add(btnOkay);
            Controls.Add(icon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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
        private Bunifu.Framework.UI.BunifuThinButton2 btnOkay;
        private Label lableMessage;
    }
}