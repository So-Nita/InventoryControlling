using InventoryApiClient.Model.User;
using InventoryApiClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace InventoryWindowApp.View
{
    public partial class LoginFormView : Form
    {
        private readonly UserService _userservice;
        private const int CS_DROPSHADOW = 0x20000;
        private bool isPasswordVisible = false;

        public LoginFormView()
        {
            _userservice = new UserService();
            InitializeComponent();
            InitVisiblePasword();
        }

        private void InitVisiblePasword()
        {
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            checkBoxShowPass.CheckedChanged += CheckBoxShowPass_CheckedChanged!;
        }
        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.UseSystemPasswordChar = !isPasswordVisible; // false => show password 
            isPasswordVisible = checkBoxShowPass.Checked;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new UserRequest()
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
            };
            var data = await _userservice.GetUserAsync(user);
            if (data == null)
            {
                return;
            }
            //this.Close();
            new LoginFormView().Close();
            var homeView = new MainContainerView();
            homeView.StartPosition = FormStartPosition.CenterScreen;
            homeView.ShowDialog();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
