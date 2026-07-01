using System.Windows;

namespace SpaceResearchProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadWelcomeScreen();
        }

        public void LoadWelcomeScreen()
        {
            MainContentContainer.Content = new WelcomeView(this);
        }

        public void LoadDashboard()
        {
            MessageBox.Show("C# Backend: Initializing Radio Telescope Dashboard...", "System Notification");
        }
    }
}
