using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace InventoryWindowApp.CustomStyle
{
    public partial class CustomMessageBox : Form
    {
        private readonly Timer timer = new Timer();
        private readonly string successImg = "https://www.vidhyarthidarpan.com/public/images/success.gif";
        private readonly string failImg = "https://cdn.dribbble.com/users/251873/screenshots/9388228/error-img.gif";

        public CustomMessageBox(string message, bool isFail)
        {
            InitializeComponent();
            InitTitle(message, isFail);
            InitDelay();
            FormBorderStyle = FormBorderStyle.None; // Set border style to None
            Paint += CustomMessageBox_Paint;
        }

        public static void ShowMessageBox(string message, bool ifFailed)
        {
            using (var form = new CustomMessageBox(message, ifFailed))
            {
                form.ShowDialog();
            }
        }

        private void InitDelay()
        {
            // Set the timer interval to 5000 milliseconds (5 seconds)
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Close the form when the timer ticks
            this.Close();
        }

        private async void InitTitle(string message, bool checkFail)
        {
            lableMessage.Text = message;
            if (!checkFail)
            {
                icon.Image = await ItemComponent.GetImageFromUrl(failImg);
            }
            icon.Image = await ItemComponent.GetImageFromUrl(successImg);
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CustomMessageBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 10), e.ClipRectangle);
        }

    }
}
