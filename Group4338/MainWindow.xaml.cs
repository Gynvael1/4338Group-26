using System.Windows;

namespace Group4338
{
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void ShowAuthorInfo(object sender, RoutedEventArgs e)
        {
            var win = new _4338_Malykh();
            win.Show();
        }
    }
}