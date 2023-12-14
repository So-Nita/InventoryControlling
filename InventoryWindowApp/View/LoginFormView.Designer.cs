namespace InventoryWindowApp.View
{
    partial class LoginFormView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormView));
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            checkBoxShowPass = new CheckBox();
            btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            pictureBox1 = new PictureBox();
            panelUsername = new Panel();
            elipseUsername = new Bunifu.Framework.UI.BunifuElipse(components);
            panelPassword = new Panel();
            txtPassword = new TextBox();
            elipsePassword = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelUsername.SuspendLayout();
            panelPassword.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 18;
            bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(535, 40);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(164, 165, 169);
            label2.Location = new Point(448, 102);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ButtonFace;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(8, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 21);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(448, 197);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowPass.Location = new Point(613, 259);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(113, 21);
            checkBoxShowPass.TabIndex = 5;
            checkBoxShowPass.Text = "Show Passwod";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Active = false;
            btnLogin.Activecolor = Color.FromArgb(77, 136, 255);
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.BorderRadius = 7;
            btnLogin.ButtonText = "LOGIN";
            btnLogin.DisabledColor = Color.Gray;
            btnLogin.Iconcolor = Color.Transparent;
            btnLogin.Iconimage = (Image)resources.GetObject("btnLogin.Iconimage");
            btnLogin.Iconimage_right = null;
            btnLogin.Iconimage_right_Selected = null;
            btnLogin.Iconimage_Selected = null;
            btnLogin.IconMarginLeft = 0;
            btnLogin.IconMarginRight = 0;
            btnLogin.IconRightVisible = false;
            btnLogin.IconRightZoom = 0D;
            btnLogin.IconVisible = false;
            btnLogin.IconZoom = 0D;
            btnLogin.IsTab = false;
            btnLogin.Location = new Point(447, 313);
            btnLogin.Margin = new Padding(0, 3, 5, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Normalcolor = Color.CornflowerBlue;
            btnLogin.OnHovercolor = Color.FromArgb(77, 136, 255);
            btnLogin.OnHoverTextColor = Color.White;
            btnLogin.selected = false;
            btnLogin.Size = new Size(229, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.TextAlign = ContentAlignment.MiddleCenter;
            btnLogin.Textcolor = Color.White;
            btnLogin.TextFont = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Img_LogIn;
            pictureBox1.Location = new Point(29, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = SystemColors.ButtonFace;
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Location = new Point(448, 131);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(272, 35);
            panelUsername.TabIndex = 7;
            // 
            // elipseUsername
            // 
            elipseUsername.ElipseRadius = 10;
            elipseUsername.TargetControl = panelUsername;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = SystemColors.ButtonFace;
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Location = new Point(448, 223);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(272, 35);
            panelPassword.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ButtonFace;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(8, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 22);
            txtPassword.TabIndex = 3;
            // 
            // elipsePassword
            // 
            elipsePassword.ElipseRadius = 10;
            elipsePassword.TargetControl = panelPassword;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 5;
            bunifuElipse2.TargetControl = this;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(panelPassword);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(panelUsername);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(checkBoxShowPass);
            materialCard1.Controls.Add(btnLogin);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(23, 23);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(765, 415);
            materialCard1.TabIndex = 9;
            // 
            // LoginFormView
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(811, 463);
            Controls.Add(materialCard1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFormView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private CheckBox checkBoxShowPass;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panelUsername;
        private Bunifu.Framework.UI.BunifuElipse elipseUsername;
        private Panel panelPassword;
        private Bunifu.Framework.UI.BunifuElipse elipsePassword;
        private TextBox txtPassword;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
    }
}