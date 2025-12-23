using System.Windows;

namespace MarkTexApp
{
    public partial class App : System.Windows.Application
    {
        private MainWindow? mainWindow;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show(); 
        }
    }
}
