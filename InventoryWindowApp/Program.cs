using InventoryApiClient.Services;
using InventoryWindowApp.CustomStyle;
using InventoryWindowApp.View;
using POSDesignDemo.View;

namespace InventoryWindowApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Application.Run(new MainContainerView());

            //Application.Run(new HomeView());
            Application.Run(new LoginFormView());

            //Application.Run(new CustomMessageBox("Successfully",true));
        }
    }
}