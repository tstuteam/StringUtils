using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMinutesToRead(object sender, RoutedEventArgs e)
        {
            tbResult.Text = StringUtils.StringUtils.MinutesToRead(textInput.Text, 200).ToString();
        }
    }
}
