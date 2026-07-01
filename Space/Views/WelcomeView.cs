using System.Windows;
using System.Windows.Controls;

namespace SpaceResearchProject
{
    public partial class WelcomeView : UserControl
    {
        private MainWindow _parentWindow;

        // We pass the parent MainWindow here so this control can talk back to it
        public WelcomeView(MainWindow parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void InitializeButton_Click(object sender, RoutedEventArgs e)
        {
            // Call the method in MainWindow to change screens
            _parentWindow.LoadDashboard();
        }
    }
}